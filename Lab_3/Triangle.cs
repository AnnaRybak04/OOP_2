using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Triangle
    {
        protected float side1, side2, side3;

        public Triangle(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Triangle sides must be positive numbers");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Invalid triangle sides");
            }

            side1 = a;  
            side2 = b;
            side3 = c;
        }
       
    }
}
