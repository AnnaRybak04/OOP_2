using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class IsoscelesTriangle : Triangle, IIsoscelesTriangle
    {
        public IsoscelesTriangle(float a, float b) : base(b, b, a) { }
        
        public float GetSide()
        {
            return base.side1;
        }
        public float GetBase()
        {
            return base.side3;
        }
        public float GetPerimeter()
        {
            return GetSide() * 2 + GetBase();
        }
        public float GetArea()
        {
            float p = GetPerimeter() / 2;
            return (float)Math.Sqrt(p * Math.Pow((p - GetSide()), 2) * (p - GetBase()));
        }
        public float GetCircumscribedCircleRadius()
        {
            return (float)(Math.Pow(GetSide(), 2) / Math.Sqrt(4 * Math.Pow(GetSide(), 2) - Math.Pow(GetBase(), 2)));
        }

        public float GetInscribedCircleRadius()
        {
            float p = GetPerimeter() / 2;
            return (float)Math.Sqrt((Math.Pow(p - GetSide(), 2) * (p - GetBase())) / p);
        }
   
    }
}
