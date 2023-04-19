namespace Lab_3
{ 
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the type of triangle:");
            Console.WriteLine("1. Equilateral Triangle");
            Console.WriteLine("2. Isosceles Triangle");
            Console.WriteLine("3. Scalene Triangle");
            Console.WriteLine("4. Right Triangle");

            int choice = int.Parse(Console.ReadLine());
            Triangle triangle;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the side length of the equilateral triangle:");
                    float side = float.Parse(Console.ReadLine());
                    triangle = new EquilateralTriangle(side);
                    EquilateralTriangle((EquilateralTriangle)triangle);
                    break;

                case 2:
                    Console.WriteLine("Enter the base length and side of the isosceles triangle:");
                    float base1 = float.Parse(Console.ReadLine());
                    float side1 = float.Parse(Console.ReadLine());
                    triangle = new IsoscelesTriangle(base1, side1);
                     IsoscelesTriangle((IsoscelesTriangle)triangle);
                    break;

                case 3:
                    Console.WriteLine("Enter the side lengths of the scalene triangle:");
                    float sideA = float.Parse(Console.ReadLine());
                    float sideB = float.Parse(Console.ReadLine());
                    float sideC = float.Parse(Console.ReadLine());
                    triangle = new ScaleneTriangle(sideA, sideB, sideC);
                    ScaleneTriangle((ScaleneTriangle)triangle);

                    break;

                case 4:
                    Console.WriteLine("Enter the legs and hypotenuse of the right triangle:");
                    float leg1 = float.Parse(Console.ReadLine());
                    float leg2 = float.Parse(Console.ReadLine());
                    float hypotenuse = float.Parse(Console.ReadLine());
                    triangle = new RightTriangle(leg1,leg2, hypotenuse);
                    RightTriangle((RightTriangle)triangle);
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

        }
        static void EquilateralTriangle(EquilateralTriangle tr)
        {
            Console.WriteLine("Equilateral Triangle");
            Console.WriteLine("Perimeter: "+ tr.GetPerimeter());
            Console.WriteLine("Area: " + tr.GetArea());
            Console.WriteLine("Radius of inscribed circle: " + tr.GetInscribedCircleRadius());
            Console.WriteLine("Radius of circumscribed circle: " + tr.GetCircumscribedCircleRadius());
        }
        static void IsoscelesTriangle(IsoscelesTriangle tr)
        {
            Console.WriteLine("Isosceles Triangle");
            Console.WriteLine("Perimeter: " + tr.GetPerimeter());
            Console.WriteLine("Area: " + tr.GetArea());
            Console.WriteLine("Radius of inscribed circle: " + tr.GetInscribedCircleRadius());
            Console.WriteLine("Radius of circumscribed circle: " + tr.GetCircumscribedCircleRadius());
        }
        static void ScaleneTriangle(ScaleneTriangle tr)
        {
            Console.WriteLine("Scalene Triangle");
            Console.WriteLine("Perimeter: " + tr.GetPerimeter());
            Console.WriteLine("Area: " + tr.GetArea());
            Console.WriteLine("Radius of inscribed circle: " + tr.GetInscribedCircleRadius());
            Console.WriteLine("Radius of circumscribed circle: " + tr.GetCircumscribedCircleRadius());
        }
        static void RightTriangle(RightTriangle tr)
        {
            Console.WriteLine("Right Triangle");
            Console.WriteLine("Perimeter: " + tr.GetPerimeter());
            Console.WriteLine("Area: " + tr.GetArea());
            Console.WriteLine("Radius of inscribed circle: " + tr.GetInscribedCircleRadius());
            Console.WriteLine("Radius of circumscribed circle: " + tr.GetCircumscribedCircleRadius());
        }
    }
}