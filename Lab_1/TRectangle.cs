using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class TRectangle
    {
        protected float width, length;

        public TRectangle() { }
        public TRectangle(float w, float l)
        {
            try
            {
                if(w <= 0 || l <= 0)
                {
                    throw new ArgumentOutOfRangeException("Wrong values!");
                }
                else
                {
                    width = w;
                    length = l;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public TRectangle(TRectangle rectangle)
        {
            width = rectangle.width;
            length = rectangle.length;
        }/*
        public virtual void SetData(float w, float l)
        {
            try
            {
                if (w <= 0 || l <= 0)
                {
                    throw new ArgumentOutOfRangeException("Wrong values!");
                }
                else
                {
                    width = w;
                    length = l;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public virtual void GetData() {
            Console.WriteLine("Width : " + width);
            Console.WriteLine("Length: " + length);
           
        }*/

        public virtual float Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }
        public virtual float Length
        {
            get { return length; }
            set { if (value > 0) length = value; }
        }
       
        public virtual float GetSquare()
        {
            return Width * Length;
        }
        public virtual float GetPerimeter()
        {
            return (Width + Length) * 2;
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
            return new TRectangle(rectangle1.Width + rectangle2.Width, rectangle1.Length + rectangle2.Length);
        }
        public static TRectangle operator -(TRectangle rectangle1, TRectangle rectangle2)
        {
            return new TRectangle(Math.Abs(rectangle1.Width - rectangle2.Width), Math.Abs(rectangle1.Length - rectangle2.Length));
        }
        public static TRectangle operator *(TRectangle rectangle, float num)
        {
            return new TRectangle(rectangle.Width * num, rectangle.Length * num);
        }
    
    }
}
