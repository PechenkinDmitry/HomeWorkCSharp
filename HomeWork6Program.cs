using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Runtime;

if (!Directory.Exists("C:\\Lessons\\ConsoleApp5\\ZipInfo"))
{
    Directory.CreateDirectory("C:\\Lessons\\ConsoleApp5\\ZipInfo");
}
ZipFile.ExtractToDirectory("C:\\Lessons\\ConsoleApp5\\WorkPAPKA.zip", "C:\\Lessons\\ConsoleApp5\\ZipInfo");

if (!File.Exists("C:\\Lessons\\ConsoleApp5\\NewInfo.csv"))
{
    File.Create("C:\\Lessons\\ConsoleApp5\\NewInfo.csv");
}
var newInfo = "C:\\Lessons\\ConsoleApp5\\NewInfo.csv";

using FileStream fileCSV = new FileStream(newInfo, FileMode.OpenOrCreate);
using var streamWriter = new StreamWriter(fileCSV);
DirectoryInfo di = new DirectoryInfo("C:\\Lessons\\ConsoleApp5\\ZipInfo");
DirectoryInfo[] diArr = di.GetDirectories();
for (var i = 0; i < diArr.Length; i++)
{

    streamWriter.WriteLineAsync("Directory");
    streamWriter.WriteLineAsync(diArr[i].Name);
    streamWriter.WriteLineAsync(diArr[i].LastWriteTime);
    var del = "C:\\Lessons\\ConsoleApp5\\ZipInfo" + diArr[i].Name;
    Directory.Delete(del);

}
Directory.Delete("C:\\Lessons\\ConsoleApp5\\ZipInfo");
var fileTxt = "C:\\Lessons\\AppData\\Roaming\\Lesson12Homework.txt";
using var fileStreamSecond = new FileStream(fileTxt, FileMode.OpenOrCreate);
using var newStreamWriter = new StreamWriter(fileStreamSecond);
newStreamWriter.WriteLineAsync(Path.GetFullPath("C:\\Lessons\\ConsoleApp5\\NewInfo.csv"));