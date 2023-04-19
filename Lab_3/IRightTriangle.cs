using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal interface IRightTriangle
    {
        float GetSide1();
        float GetSide2();
        float GetHypotenuse();

        float GetPerimeter();
        float GetArea();
        float GetInscribedCircleRadius();
        float GetCircumscribedCircleRadius();
    }
}
