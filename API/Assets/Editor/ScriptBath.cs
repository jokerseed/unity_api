using System.Diagnostics;
using UnityEditor;

public class ScriptBath
{
    [MenuItem("MyTools/Windows Build With Postprocess")]
    public static void BuildGame()
    {
        //获取文件名
        string path = EditorUtility.SaveFolderPanel("Choose Location od Built Game", "", "");
        string[] levels = new string[] { "Assets/Scene1.unity", "Assets/Scene2.unity" };

        //构建播放
        BuildPipeline.BuildPlayer(levels, path + "/BuiltGame.exe", BuildTarget.StandaloneWindows, BuildOptions.None);

        //将文件从项目文件夹复制到构建文件夹，与构建的游戏放在一起
        FileUtil.CopyFileOrDirectory("Assets/Templates/Readme.txt", path + "Readme.txt");

        //运行游戏（System.Diagnostics中的Process类）
        Process proc = new Process();
        proc.StartInfo.FileName = path + "/BuiltGame.exe";
        proc.Start();
    }
}
