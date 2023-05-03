namespace Lab_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                string text = File.ReadAllText("D:/Документы/универ/Лаби/4 семестр/ООП_2/OOP_2/Lab_4/text.txt");
                if (text.Trim() == "")
                {
                    Console.WriteLine("Файл порожній! Не можливо визначити кількість прописних букв");
                }
                else
                {
                    List<char> symbols = new List<char>(text);
                    int count = CountUppercaseSymbols(symbols);
                    Console.WriteLine("Кількість прописних букв: " + count);
                }
            }catch(Exception e)
            {
                Console.WriteLine("Не можливо зчитати текст з файлу! Помилка: " + e.Message);
            }
            


        }
        public static int CountUppercaseSymbols(List<char> symbols)
        {
            int count = 0;
            foreach (char symbol in symbols)
            {
                if (Char.IsUpper(symbol))
                {
                    count++;
                }
            }
            return count;
        }
    }
}