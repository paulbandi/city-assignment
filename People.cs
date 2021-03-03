using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Genre { get; set; }
        public string Profession { get; set; }

        public People(string name, int age, string genre, string profession)
        {
            Name = name;
            Age = age;
            Genre = genre;
            Profession = profession;
        }
    }
}
