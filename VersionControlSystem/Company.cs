using System;
namespace VersionControlSystem
{
    public class Company
    {
        public string Name { get; set; }
        public Company(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

