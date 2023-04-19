using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal interface IIsoscelesTriangle
    {
        float GetSide();
        float GetBase();
        float GetPerimeter();
        float GetArea();
        float GetInscribedCircleRadius();
        float GetCircumscribedCircleRadius();
    }
}
