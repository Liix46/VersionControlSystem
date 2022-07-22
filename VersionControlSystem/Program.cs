// See https://aka.ms/new-console-template for more information
using VersionControlSystem;

Console.WriteLine("Hello, World!");

User user = new();
user.Name = "Tom Holland";
user.Age = 23;

Console.WriteLine(user.ToString());

user.Age += 1;
Console.WriteLine(user.ToString());

user.Name = "name";
user.Name = "lastname";
