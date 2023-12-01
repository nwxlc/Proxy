using System.Text;
using Proxy;

IFile file = new FileProxy("./../../../text.txt");

var size = file.GetSize();
var path = file.GetPath();
var bytes = file.Show();

Console.WriteLine($"Size: {size}");
Console.WriteLine($"Path: {path}");
Console.WriteLine($"Show: {Encoding.UTF8.GetString(bytes)}");