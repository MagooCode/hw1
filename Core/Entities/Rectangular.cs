using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Rectangular : Figure
    {
        private int _width;
        private int _length;

        public Rectangular(int width, int length)
        {
            _width = width;
            _length = length;
        }

        public sealed override int CalcArea()
        {
            return _length * _width;
        }

        public int Width
        {
            get 
            {
                return _width;
            }
            set
            {
                if (value > 0)
                { 
                    _width = value;
                }
                else
                    _width = 1;
            }
        }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                    _length = 1;
            }
        }
    }
}
