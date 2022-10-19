namespace Задание_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Составить список из 10 шестизначных чисел:");
                List<int> values = new List<int>(n);
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(100000, 999999);
                    values.Add(x);
                }
                OutputOnDisplay(values);
                Console.WriteLine("\nВжух! Убираем числа с цифрой 3 из списка:");
                values.RemoveAll(i => DelValue3(i));                                    //через лямбду удалять все значения Тру
                OutputOnDisplay(values);
                Console.WriteLine("Нажмите Enter для продолжения.");
                Console.ReadLine();
                Console.WriteLine("------------");
            }
            static bool DelValue3(int value2)
            {
                int num = value2;
                while (num > 1)
                {
                    if (num % 10 == 3)
                    {
                        return true;
                    }
                    num /= 10;
                }
                return false;
            }
        }
        static void OutputOnDisplay(List<int> values)  //выводим на экран элементы листа
        {
            foreach (int i in values)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}