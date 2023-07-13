namespace tasks;
class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }


        void Task19()
        {
            // Напишите программу, которая принимает на вход
            // пятизначное число и проверяет, является ли оно палиндромом.

            double num = Input("Введите пятизначное число: ");
            
            // Находим первую цифру числа 
            double digit1 = Math.Round(num / 10000);

            // Находим вторую цифру числа
            double digit2 = Math.Round(num / 1000);

            // Находим четвертую цифру числа
            double digit3 = Math.Round(num / 1000);

            if (num % 10 == digit1 && digit3 == digit2)
            {
                Console.WriteLine("Число является палиндромом");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }
            
        }


        void Task21()
        {
            //Напишите программу, которая принимает на вход координаты двух
            // точек и находит расстояние между ними в 3D пространстве.

            int x1 = Input("Введите X первой точки: ");
            int y1 = Input("Введите Y первой точки: ");
            int z1 = Input("Введите Z первой точки: ");
            int x2 = Input("Введите X второй точки: ");
            int y2 = Input("Введите Y второй точки: ");
            int z2 = Input("Введите Z второй точки: ");

            double result = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) 
                          + Math.Pow((z2 - z1), 2);
            result = Math.Round(Math.Sqrt(result), 2);

            Console.WriteLine($"Расстояние между точками: {result}");
        }


        void Task23()
        {
            // Напишите программу, которая принимает на вход
            // число (N) и выдаёт таблицу кубов чисел от 1 до N.

            int num = Input("Введите число: ");

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
            }
        }


        // Проверка кода
        Console.Clear();
        int task = Input("Введите номер задачи: ");
        switch (task)
        {
            case 19:
                Task19();
                break;
            case 21:
                Task21();
                break;
            case 23:
                Task23();
                break;
            default:
                Console.WriteLine("Ошибка ввода");
                break;
        }
    }
}
