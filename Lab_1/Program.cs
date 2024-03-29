﻿using Lab_1;

class Program
{
    static void Main(string[] args)
    {
        TRectangle rect = new TRectangle(-4,5);
        TParallelepiped parall = new TParallelepiped();

        int option;

       
        do
        { 
            Console.WriteLine("\n1 - rectangle, 2 - parallelepiped, 0 - exit ");
            Console.Write("Your choice? ");
            try
            {
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    do { 
                    Console.WriteLine("\n<-----Rectangle----->");
                    Console.WriteLine("1 - set parameters");
                    Console.WriteLine("2 - get parameters");
                    Console.WriteLine("3 - get square");
                    Console.WriteLine("4 - get perimeter");
                    Console.WriteLine("5 - compare two rectangles");
                    Console.WriteLine("6 - apply operators (+, -, *)");
                    Console.WriteLine("0 - exit");
                    Console.Write("Your choice? ");

                    option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 0: break;
                            case 1:
                                {
                                    Console.Write("\nEnter the width: ");
                                    float w = float.Parse(Console.ReadLine());
                                    rect.Width = w;
                                    Console.Write("Enter the length: ");
                                    float l = float.Parse(Console.ReadLine());
                                    rect.Length = l;
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Width: " + rect.Width);
                                    Console.WriteLine("Length: " + rect.Length);
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Square: " + rect.GetSquare());
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Perimeter: " + rect.GetPerimeter());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Enter the parameters for the rectangle 1: ");
                                    TRectangle rect1 = new TRectangle();
                                    Console.Write("\nEnter the width: ");
                                    float w_1 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the length: ");
                                    float l_1 = float.Parse(Console.ReadLine());
                                    rect1.Width = w_1;
                                    rect1.Length = l_1;
                                    
                                    Console.WriteLine("Enter the parameters for the rectangle 2: ");
                                    TRectangle rect2 = new TRectangle();
                                    Console.Write("\nEnter the width: ");
                                    float w_2 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the length: ");
                                    float l_2 = float.Parse(Console.ReadLine());
                                    rect2.Width = w_2;
                                    rect2.Length = l_2;
                                    rect1.CompareRectangles(rect2);
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("Enter the parameters for the rectangle 1: ");
                                    TRectangle rect1 = new TRectangle();
                                    Console.Write("\nEnter the width: ");
                                    float w_1 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the length: ");
                                    float l_1 = float.Parse(Console.ReadLine());
                                    rect1.Width = w_1;
                                    rect1.Length = l_1;
                                    Console.WriteLine("Enter the parameters for the rectangle 2: ");
                                    TRectangle rect2 = new TRectangle();
                                    Console.Write("\nEnter the width: ");
                                    float w_2 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the length: ");
                                    float l_2= float.Parse(Console.ReadLine());
                                    rect2.Width = w_2;
                                    rect2.Length = l_2;

                                    TRectangle rect3 = new TRectangle();
                                    rect3 = rect1 + rect2;
                                    Console.WriteLine("Operator '+' : width - " + rect3.Width + ", length - " + rect3.Length);
                                    rect3 = rect1 - rect2;
                                    Console.WriteLine("Operator '-' : width - " + rect3.Width + ", length - " + rect3.Length);
                                    rect3 = rect1 * 3;
                                    Console.WriteLine("Operator '*' : width - " + rect3.Width + ", length - " + rect3.Length);

                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("No possible options!");
                                    break;
                                }
                        }
                    }while(option!=0);
                }
                else if (option == 2)
                {
                    do
                    {
                        Console.WriteLine("\n<-----Parallelepiped----->");
                    Console.WriteLine("1 - set parameters");
                    Console.WriteLine("2 - get parameters");
                    Console.WriteLine("3 - get square");
                    Console.WriteLine("4 - get perimeter");
                    Console.WriteLine("5 - get volume");
                    Console.WriteLine("6 - compare two parallelepipeds");
                    Console.WriteLine("7 - apply operators (+, -, *)");
                    Console.WriteLine("0 - exit");
                    Console.Write("Your choice? ");

                    option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 0: break;
                            case 1:
                                {
                                    Console.Write("\nEnter the width of the base: ");
                                    float w = float.Parse(Console.ReadLine());
                                    parall.Width = w;
                                    Console.Write("Enter the length of the base: ");
                                    float l = float.Parse(Console.ReadLine());
                                    parall.Length = l;
                                    Console.Write("Enter the height: ");
                                    float h = float.Parse(Console.ReadLine());
                                    parall.Height = h;
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Width: " + parall.Width);
                                    Console.WriteLine("Length: " + parall.Length);
                                    Console.WriteLine("Height: " + parall.Height);

                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Square: " + parall.GetSquare());
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Perimeter: " + parall.GetPerimeter());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Volume: " + parall.GetVolume());
                                    break;
                                }

                            case 6:
                                {
                                    Console.WriteLine("Enter the parameters for the parallelepiped 1: ");
                                    TParallelepiped parall1 = new TParallelepiped();
                                    Console.Write("\nEnter the width of the base: ");
                                    float w_1 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the length of the base: ");
                                    float l_1 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the height: ");
                                    float h_1 = float.Parse(Console.ReadLine());
                                    parall1.Height = h_1;
                                    parall1.Width = w_1;
                                    parall1.Length = l_1;
                                    
                                    Console.WriteLine("Enter the parameters for the parallelepiped 2: ");
                                    TParallelepiped parall2 = new TParallelepiped();
                                    Console.Write("\nEnter the width of the base: ");
                                    float w_2 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the length of the base: ");
                                    float l_2 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the height: ");
                                    float h_2 = float.Parse(Console.ReadLine());
                                    parall2.Height = h_2;
                                    parall2.Width = w_2;
                                    parall2.Length = l_2;
                                    parall1.CompareParallelepipeds(parall2);
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine("Enter the parameters for the parallelepiped 1: ");
                                    TParallelepiped parall1 = new TParallelepiped();
                                    Console.Write("\nEnter the width of the base: ");
                                    float w_1 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the length of the base: ");
                                    float l_1 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the height: ");
                                    float h_1 = float.Parse(Console.ReadLine());
                                    parall1.Height = h_1;
                                    parall1.Width = w_1;
                                    parall1.Length = l_1;

                                    Console.WriteLine("Enter the parameters for the parallelepiped 2: ");
                                    TParallelepiped parall2 = new TParallelepiped();
                                    Console.Write("\nEnter the width of the base: ");
                                    float w_2 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the length of the base: ");
                                    float l_2 = float.Parse(Console.ReadLine());
                                    Console.Write("Enter the height: ");
                                    float h_2 = float.Parse(Console.ReadLine());
                                    parall2.Height = h_2;
                                    parall2.Width = w_2;
                                    parall2.Length = l_2;


                                    TParallelepiped parall3 = new TParallelepiped();
                                    parall3 = parall1 + parall2;
                                    Console.WriteLine("Operator '+' : width - " + parall3.Width + ", length - " + parall3.Length + ", height - " + parall3.Height);
                                    parall3 = parall1 - parall2;
                                    Console.WriteLine("Operator '-' : width - " + parall3.Width + ", length - " + parall3.Length + ", height - " + parall3.Height);
                                    parall3 = parall1 * 3;
                                    Console.WriteLine("Operator '*' : width - " + parall3.Width + ", length - " + parall3.Length + ", height - " + parall3.Height);

                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("No possible options!");
                                    break;
                                }
                        }
                    }while (option != 0) ;
                }
                else if (option == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong value!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }while (true);
      

    }
}