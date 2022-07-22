using VersionControlSystem;

User user = new();
user.Name = "Tom Holland";


user.Sex = "Male";
user.RememberMe = true;

user.Age = 25;

Console.WriteLine(user.ToString());

Company company = new("Vision");

Console.WriteLine(company.ToString());

