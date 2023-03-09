namespace Lab_2 {

    class Program
    {
        
        static void Main(string[] args)
        {

            Random random = new Random();
            Console.WriteLine("1) Одновимірний масив");
            Console.Write("Введіть розмірність масиву: ");
            int n= int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            Console.WriteLine("1 - рандомне заповнення, 2 - мануальне заповнення");
            int choice=int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                for(int i = 0; i < n; i++)
                {
                    arr[i]=random.NextDouble()*100-50;
                }
            }
            if(choice == 2)
            {
                for (int i = 0; i < n; i++)
                {
                    arr[i] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМасив: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            TArray array= new TArray();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Завдання 1: ");
            array.Task1(arr);
            Console.WriteLine();
            Console.WriteLine("Завдання 2: ");
            Console.WriteLine("Введіть число, на яке будуть перемножуватись елементи вектору: ");
            double num = double.Parse(Console.ReadLine());
            array.Task2(arr, num);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Завдання 3: ");
            array.Task3(arr);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("2) Двовимірний масив");
            Console.Write("Введіть кількість рядків масиву: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стовпців масиву: ");
            int c = int.Parse(Console.ReadLine());
            int [,] intArr = new int[r,c];
            Console.WriteLine("1 - рандомне заповнення, 2 - мануальне заповнення");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        intArr[i, j] = random.Next(-50,50);
                    }
                }
            }
            if (choice == 2)
            {
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write("[" + i +";"+j+"] ");
                         intArr[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine("\nМасив: ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(intArr[i,j] + " ");
                }
                Console.WriteLine();
            }
           
            TArray2D array2D = new TArray2D();
            Console.WriteLine();
            Console.WriteLine("Завдання 1: ");
            array2D.Task1(intArr);
            Console.WriteLine();
            Console.WriteLine("Завдання 2: ");
            array2D.Task2(intArr);
            Console.WriteLine();
            Console.WriteLine("Завдання 3: ");
            array2D.Task3(intArr);
        }
    } 

}