using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class TParallelepiped : TRectangle
    {
        private float height;
        public TParallelepiped() { }
        public TParallelepiped(float side1, float side2, float height) : base(side1, side2)
        {
            this.height = height;
        }
        public TParallelepiped(TParallelepiped parall)
        {
            this.height = parall.height;
            this.width = parall.width;
            this.length = parall.length;
        }
        public new void SetData(float w, float l, float h)
        {
            width = w;
            length = l;
            height = h;
        }
        public new void GetData()
        {
            Console.WriteLine("Width of the base: " + width);
            Console.WriteLine("Length of the base: " + length);
            Console.WriteLine("Height: " + height);
        }
        public new float GetSquare()
        {
            return (width + length) * 2 * height + 2 * width * length;
        }
        public new float GetPerimeter()
        {
            return (width + length + height) * 4;
        }
        public float GetVolume()
        {
            return height * GetSquare();
        }
        public void CompareParallelepipeds(TParallelepiped parall)
        {
            if (this.GetSquare() == parall.GetSquare())
            {
                Console.WriteLine("Parallelepipeds are the same");
            }
            else if (this.GetSquare() > parall.GetSquare())
            {
                Console.WriteLine("Parallelepiped 1 bigger than parallelepiped 2");
            }
            else
            {
                Console.WriteLine("Parallelepiped 2 bigger than parallelepiped 1");
            }
        }
        public static TParallelepiped operator +(TParallelepiped parall1, TParallelepiped parall2)
        {
            return new TParallelepiped(parall1.width + parall2.width, parall1.length + parall2.length, parall1.height + parall2.height);
        }
        public static TParallelepiped operator -(TParallelepiped parall1, TParallelepiped parall2)
        {
            return new TParallelepiped(Math.Abs(parall1.width - parall2.width), Math.Abs(parall1.length - parall2.length), Math.Abs(parall1.height - parall2.height));
        }
        public static TParallelepiped operator *(TParallelepiped parall, float num)
        {
            return new TParallelepiped(parall.width * num, parall.length * num, parall.height * num);
        }
    }
}
