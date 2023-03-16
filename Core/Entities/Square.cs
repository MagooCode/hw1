using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Square : Figure
    {
        private int _side;

        public Square(int side1)
        {
            _side = side1;
        }

        public override int CalcArea()
        {
            return _side * _side;
        }

        public int Side
        {
            get 
            {
                return _side;
            }
            set 
            {
                if (value > 0)
                {
                    _side = value;
                }
                else
                    _side = 1;
            }
        }
    }

}
