using System;
namespace VersionControlSystem
{
    public class User
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public override string ToString()
        {
            return $"Name:{Name}  Age: {Age}";
        }

        public string? Password {get;set;}
    }
}

