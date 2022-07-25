using System;
namespace VersionControlSystem
{
    public class User
    {
        public string? Name { get; set; }
        public string? Nickname {get;set;}
        public int? Age { get; set; }

        public string? Sex {get;set;}
        public bool RememberMe {get;set;} 

         public override string ToString()
        {
            return $"Name:{Name}  Age: {Age}";
        }


    }
}

