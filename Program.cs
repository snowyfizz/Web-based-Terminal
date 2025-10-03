// Program.cs - A comprehensive C# starter script
using System;
using System.Collections.Generic;
public class Project {
    public string Name { get; }
    public string Version { get; } = "1.0.0";
    public Project(string name) { Name = name; }
    public void DisplayInfo() => Console.WriteLine($"Project: {Name}, v{Version}");
}
public class Program {
    public static void Main(String[] args) {
        var myProject = new Project("GitHub Auto-Repo Project");
        myProject.DisplayInfo();
        Console.WriteLine("\nFeatures: Classes, Properties, Loops");
        for (int i = 0; i < 5; i++) { Console.WriteLine($"  - Loop {i + 1}"); }
    }
}
