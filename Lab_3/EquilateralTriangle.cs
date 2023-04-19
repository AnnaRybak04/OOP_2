using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class EquilateralTriangle : Triangle, IEquilateralTriangle
    {
        public EquilateralTriangle(float a): base(a, a, a) { }
        
        public float GetPerimeter()
        {
            return GetSide() * 3;
        }

        public float GetArea()
        {
            return (float)(Math.Pow(GetSide(), 2) * Math.Sqrt(3)) / 4;
        }

        public float GetCircumscribedCircleRadius()
        {
            return (float)(GetSide() / Math.Sqrt(3));
        }

        public float GetInscribedCircleRadius()
        {
            return (float)(GetSide() * Math.Pow(3, -1 / 2) / 2);
        }

       
        public float GetSide()
        {
            return base.side1;
        }
    }
}
