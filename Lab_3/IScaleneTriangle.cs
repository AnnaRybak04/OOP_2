using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal interface IScaleneTriangle
    {
        float GetSide1();
        float GetSide2();
        float GetSide3();
        float GetPerimeter();
        float GetArea();
        float GetInscribedCircleRadius();
        float GetCircumscribedCircleRadius();
    }
}
