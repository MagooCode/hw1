using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10032023.Models
{
    public class Student : Person
    {
        public byte Point;


        public byte Point2
        {
            get
            { 
                return Point;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    Point = value;
                }
                else
                {
                    Point = 0;
                }
            }        
        }
        public Student(string name, string surname,byte age, byte point) : base (name, surname, age)
        {
            Point = point;
        }
    }
}
