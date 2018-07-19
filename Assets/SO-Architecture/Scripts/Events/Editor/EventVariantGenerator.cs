using System;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
using System.Reflection;

public class EventVariantGenerator : EditorWindow {

    private string eventType = "";
    private string displayName = "";
    private const string TEMPLATE_DIR = "Templates/";
    private const string VARIANTS_DIR = "EventVariants/";
    private static readonly string[] TEMPLATE_FILES = {"TypeGameEvent","TypeEventListener","TypeUnityEvent"};

    [MenuItem("SO Architecture/Show Event Variant Generator")]
    public static void ShowWindow() {
        GetWindow<EventVariantGenerator>();
    }

    private void OnGUI() {
        EditorGUILayout.LabelField("Generate Scriptable Object Event Variant", EditorStyles.boldLabel);
        EditorGUILayout.LabelField("This will generate three files: [Type]GameEvent, [Type]GameEventListener and [Type]UnityEvent");

        eventType = EditorGUILayout.TextField("Event for type: (Eg. int)", eventType);
        displayName = EditorGUILayout.TextField("Name of type: (Eg. Integer)", displayName);

        if(GUILayout.Button("Generate")) {
            GenerateEventVariantFiles();
        }
    }

    private void GenerateEventVariantFiles() {
        if (HasType(eventType)) {
            string editorDir = GetEditorDirectory();
            string scriptDir = GetScriptDirectory();

            if(string.IsNullOrEmpty(displayName)) {
                displayName = eventType;
            }

            displayName = ToPascalCase(displayName);

            foreach (string fileName in TEMPLATE_FILES) {
                GenerateVariantFile(fileName, editorDir, scriptDir, eventType, displayName);
            }

            AssetDatabase.Refresh();
        } else {
            Debug.LogError("Could not generate for undefined type: " + eventType);
        }
    }

    private bool HasType(string typeName) {
        if(Type.GetType("System." +ConvertBasicTypeToClassType(typeName)) != null) {
            return true;
        }

        foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies()) {
            foreach (Type type in assembly.GetTypes()) {
                if (type.Name == typeName)
                    return true;
            }
        }

        return false;
    }

    public string ToPascalCase(string s) {
        string[] words = s.Split(new char[2] { '-', '_' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new StringBuilder(words.Sum(x => x.Length));

        foreach (string word in words) {
            sb.Append(word[0].ToString().ToUpper() + word.Substring(1));
        }

        return sb.ToString();
    }

    private string ConvertBasicTypeToClassType(string basicType) {
        switch(basicType) {
            case "int":
                return "Int32";
            case "bool":
                return "Boolean";
            case "float":
                return "Single";
            case "string":
                return "String";
            case "long":
                return "Long";
            default:
                return basicType;
        }
    }

    private void GenerateVariantFile(string fileName, string editorDir, string scriptDir, string eventType, string displayName) {
        string fileFullPath = editorDir + TEMPLATE_DIR + fileName + ".txt";
        string pascalType = displayName;
        string newFileName = fileName.Replace("Type", pascalType);
        string variantDirFullPath = Application.dataPath + "/" + VARIANTS_DIR + pascalType;
        string variantPath = variantDirFullPath + "/{0}.cs";

        TextAsset textAsset = AssetDatabase.LoadAssetAtPath(fileFullPath, typeof(TextAsset)) as TextAsset;
        string replacedContents = "";

        if (textAsset != null) {
            replacedContents = textAsset.text;
            replacedContents = replacedContents.Replace("TYPE_PASCAL", pascalType);
            replacedContents = replacedContents.Replace("TYPE_DEFAULT", eventType);
        } else {
            Debug.LogError("Cannot find template file at: " + fileFullPath);
        }

        Directory.CreateDirectory(variantDirFullPath);

        using (StreamWriter sw = new StreamWriter(string.Format(variantPath,
                                                new object[] { newFileName }))) {
            sw.Write(replacedContents);
            Debug.Log("Generated file: " + newFileName);
        }
    }

    private string GetEditorDirectory() {
        MonoScript ms = MonoScript.FromScriptableObject(this);
        string[] slicedPath = AssetDatabase.GetAssetPath(ms).Split('/');

        string editorDir = "";

        for(int i = 0; i < (slicedPath.Length - 1); i++) {
            editorDir += slicedPath[i] + '/';
        }

        return editorDir;
    }

    private string GetScriptDirectory() {
        MonoScript ms = MonoScript.FromScriptableObject(this);
        string[] slicedPath = AssetDatabase.GetAssetPath(ms).Split('/');

        string scriptDirectory = "";

        for (int i = 1; i < (slicedPath.Length - 2); i++) {
            scriptDirectory += slicedPath[i] + '/';
        }

        return scriptDirectory;
    }
}
