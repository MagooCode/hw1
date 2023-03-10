using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10032023.Models
{
    public class Person
    {
        private string Name { get; set; }

        public string Name2
        {
            get
            {
                return Name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                    Name = value;
                else
                {
                    Name = "wrong Namelength";
                }
                    value = char.ToUpper(value[0]) + value.Substring(1);
                    Name = value;
            }
        }
        private string Surname { get; set; }

        public string Surname2
        {
            get
            { 
                return Surname;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 35)
                    Surname = value;
                else
                {
                    Surname = "wrong length";
                }
                    value = char.ToUpper(value[0]) + value.Substring(1);
                    Surname = value;
            }
        }
        public byte Age { get; set; }

        public Person(string name,string surname, byte age)
        {
            Name2 = name;
            Surname2 = surname;
            Age = age;

        }
    }
}
