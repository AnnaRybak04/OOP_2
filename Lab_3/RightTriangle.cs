using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class RightTriangle : Triangle, IRightTriangle
    {
        public RightTriangle(float a, float b, float c) : base(a, b, c) { }
        public float GetSide1()
        {
            return base.side1;
        }
        public float GetSide2()
        {
            return base.side2;
        }
        public float GetHypotenuse()
        {
            return base.side3;
        }
        public float GetPerimeter()
        {
            return GetSide1() + GetSide2() + GetHypotenuse();
        }
        public float GetArea()
        {
            return (float)GetSide1() * GetSide2() / 2;
        }
        public float GetCircumscribedCircleRadius()
        {
            return (float)GetHypotenuse() / 2;
        }

        public float GetInscribedCircleRadius()
        {
            return (float)(GetSide1() + GetSide2() - GetHypotenuse()) / 2;
        }
    }
}
