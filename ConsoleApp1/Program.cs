using System;

namespace Calculate
{
    class Program
    {
        


        static int sum(int a, int b)
        {
            return a + b;
        }

        static int subtraction(int a, int b)
        {
            return a - b;
        }

        static int multiplication(int a, int b)
        {
            return a * b;
        }

        static int division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Делить на 0 нельзя");
            }
            return a / b;
        }



        static void Main(string[] args)
        {
            begin:
                Console.WriteLine("Выберите действие" + "\n 1) Начать вычисления" + "\n 2) Выйти");
                int p = int.Parse(Console.ReadLine());

            string text = null;
            int n = 0;

            while (p == 1)
            {
                int result = 0;
                n++;

                Console.WriteLine("Выберите действие" + "\n 1)сложение" + "\n 2)вычитание" + "\n 3)умножение" + "\n 4)деление" + "\n 5)выход");
                int c = int.Parse(Console.ReadLine());

                if (c != 5)
                {
                    Console.WriteLine("Введите первое число");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("=============================");

                    

                    if (c == 1)
                    {
                        text = "сложения";
                        result = sum(a, b);
                    }

                    else if (c == 2)
                    {
                        text = "вычетания";
                        result = subtraction(a, b);
                    }

                    else if (c == 3)
                    {
                        text = "умножения";
                        result = multiplication(a, b);
                    }

                    else if (c == 4)
                    {
                        text = "деления";
                        result = division(a, b);
                    }
                    Console.WriteLine("=============================");
                }

                else
                {
                    goto begin;
                }
                Console.WriteLine($"Результат {text} равен: " + result);
                Console.WriteLine("=============================");
                Console.WriteLine("Количество операций вычисления: " + n);
                Console.WriteLine("=============================");
               
            }
            
        }
    }
}


