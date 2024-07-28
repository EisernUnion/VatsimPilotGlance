using System.Diagnostics;
using System.Runtime.CompilerServices;

string path = Directory.GetCurrentDirectory();
string appPath = Path.Combine(path, "vpg.exe");

Console.Write("Please enter the ICAO Code to observe?: ");
string input = Console.ReadLine();
Console.WriteLine($"Your input: {input}");

string icao = input.ToUpper();
Process.Start(appPath, icao);

