using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class ScaleneTriangle : Triangle, IScaleneTriangle
    {
        public ScaleneTriangle(float a, float b, float c) : base(a, b, c) { }
        public float GetSide1()
        {
            return base.side1;
        }
        public float GetSide2()
        {
            return base.side2;
        }
        public float GetSide3()
        {
            return base.side3;
        }
        public float GetPerimeter()
        {
            return GetSide1() + GetSide2() + GetSide3();
        }
        public float GetArea()
        {
            float p = GetPerimeter() / 2;
            return (float)Math.Sqrt(p * (p - GetSide1()) * (p - GetSide2()) * (p - GetSide3()));
        }

        public float GetCircumscribedCircleRadius()
        {
            float p = GetPerimeter() / 2;
            return (float)(GetSide1() * GetSide2() * GetSide3() / (4 * Math.Sqrt(p * (p - GetSide1()) * (p - GetSide2()) * (p - GetSide3()))));
        }

        public float GetInscribedCircleRadius()
        {
            float p = GetPerimeter() / 2;
            return (float)Math.Sqrt(((p - GetSide1()) * (p - GetSide2()) * (p - GetSide3())) / p);
        }
    }
}
