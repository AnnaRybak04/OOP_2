using Lab_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rectangle:");
        TRectangle rect = new TRectangle(3, 4);
        rect.GetData();

        Console.WriteLine("\nSquare: " + rect.GetSquare());
        Console.WriteLine("Perimeter: " + rect.GetPerimeter());
        TRectangle rect2 = new TRectangle();
        Console.WriteLine("\nEnter rectangle parameters: ");

        Console.WriteLine("Width: ");
        float w = float.Parse(Console.ReadLine());
        Console.WriteLine("Length: ");
        float l = float.Parse(Console.ReadLine());
        rect2.SetData(w, l);


        rect.CompareRectangles(rect2);

        TRectangle rect3 = new TRectangle();
        Console.WriteLine("\nOperator '+'");
        rect3 = rect + rect2;
        rect3.GetData();
        Console.WriteLine("\nOperator '-'");
        rect3 = rect - rect2;
        rect3.GetData();
        Console.WriteLine("\nOperator '*'");
        rect3 = rect * 4;
        rect3.GetData();
    }
}