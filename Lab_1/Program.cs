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
        Console.WriteLine("\nEnter rectangle's parameters: ");

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

        Console.WriteLine("\n/////////////////////////////////////////////////");
        Console.WriteLine("\n\nParallelepiped:");
        TParallelepiped parall = new TParallelepiped(3, 4,2);
        parall.GetData();

        Console.WriteLine("\nSquare: " + parall.GetSquare());
        Console.WriteLine("Perimeter: " + parall.GetPerimeter());
        TParallelepiped parall1 = new TParallelepiped();
        Console.WriteLine("\nEnter parallelepiped's parameters: ");

        Console.WriteLine("Width: ");
        float w_b = float.Parse(Console.ReadLine());
        Console.WriteLine("Length: ");
        float l_b = float.Parse(Console.ReadLine());
        Console.WriteLine("Height: ");
        float h = float.Parse(Console.ReadLine());
        parall1.SetData(w, l,h);


        parall.CompareParallelepipeds(parall1);

        TParallelepiped parall2 = new TParallelepiped();
        Console.WriteLine("\nOperator '+'");
        parall2 = parall + parall1;
        parall2.GetData();
        Console.WriteLine("\nOperator '-'");
        parall2 = parall - parall1;
        parall2.GetData();
        Console.WriteLine("\nOperator '*'");
        parall2 = parall * 2;
        parall2.GetData();
    }
}