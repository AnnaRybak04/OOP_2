using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class TRectangle
    {
        public float width, length;

        public TRectangle() { }
        public TRectangle(float side_1, float side_2)
        {
            width = side_1;
            length = side_2;
        }
        public TRectangle(TRectangle rectangle)
        {
            width = rectangle.width;
            length = rectangle.length;
        }
        public void SetData(float w, float l)
        {
            width = w;
            length = l;
        }
        public void GetData()
        {
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Length: " + length);
        }
        public float GetSquare()
        {
            return width * length;
        }
        public float GetPerimeter()
        {
            return (width + length) * 2;
        }
        public void CompareRectangles(TRectangle rectangle)
        {
            if (this.GetSquare() == rectangle.GetSquare())
            {
                Console.WriteLine("Rectangles are the same");
            }
            else if (this.GetSquare() > rectangle.GetSquare())
            {
                Console.WriteLine("Rectangle 1 bigger than rectangle 2");
            }
            else
            {
                Console.WriteLine("Rectangle 2 bigger than rectangle 1");
            }
        }
        public static TRectangle operator +(TRectangle rectangle1, TRectangle rectangle2)
        {
            return new TRectangle(rectangle1.width + rectangle2.width, rectangle1.length + rectangle2.length);
        }
        public static TRectangle operator -(TRectangle rectangle1, TRectangle rectangle2)
        {
            return new TRectangle(Math.Abs(rectangle1.width - rectangle2.width), Math.Abs(rectangle1.length - rectangle2.length));
        }
        public static TRectangle operator *(TRectangle rectangle, float num)
        {
            return new TRectangle(rectangle.width * num, rectangle.length * num);
        }
    
    }
}
