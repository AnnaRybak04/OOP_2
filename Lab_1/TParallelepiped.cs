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
        public TParallelepiped(float w, float l, float height) : base(w, l)
        {
            this.height = height;
        }
        public TParallelepiped(TParallelepiped parall)
        {
            height = parall.Height;
            width = parall.Width;
            length = parall.Length;
        }
        public override float Width
        {
            get { return base.Width; }
            set { if (value > 0) 
                    base.Width = value; }
        }
        public override float Length
        {
            get { return base.Length; }
            set { if (value > 0) 
                    base.Length = value; }
        }
        public float Height
        {
            get { return height; }
            set { if (value > 0)
                    height = value; }
        }

        public override float GetSquare()
        {
            return (Width + Length) * 2 * Height + 2 * Width * Length;
        }
        public override float GetPerimeter()
        {
            return (Width + Length + Height) * 4;
        }
        public float GetVolume()
        {
            return Height * base.GetSquare();
        }
        public void CompareParallelepipeds(TParallelepiped parall)
        {
            if (this.GetSquare() == parall.GetSquare())
            {
                Console.WriteLine("Parallelepipeds are the same");
            }
            else if (this.GetSquare() > parall.GetSquare())
            {
                Console.WriteLine("Parallelepiped 1 is bigger than parallelepiped 2");
            }
            else
            {
                Console.WriteLine("Parallelepiped 2 is bigger than parallelepiped 1");
            }
        }
        public static TParallelepiped operator +(TParallelepiped parall1, TParallelepiped parall2)
        {
            return new TParallelepiped(parall1.Width + parall2.Width, parall1.Length + parall2.Length, parall1.Height + parall2.Height);
        }
        public static TParallelepiped operator -(TParallelepiped parall1, TParallelepiped parall2)
        {
            return new TParallelepiped(Math.Abs(parall1.Width - parall2.Width), Math.Abs(parall1.Length - parall2.Length), Math.Abs(parall1.Height - parall2.Height));
        }
        public static TParallelepiped operator *(TParallelepiped parall, float num)
        {
            return new TParallelepiped(parall.Width * num, parall.Length * num, parall.Height * num);
        }
    }
}
