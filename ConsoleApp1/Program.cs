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
            return a / b;
        }



        static void Main(string[] args)
        {
            begin:
                Console.WriteLine("Выберите действие" + "\n 1) Начать вычисления" + "\n 2) Выйти");
                int p;
                while (!int.TryParse(Console.ReadLine(), out p))
                    {
                         Console.WriteLine("Ошибка ввода, введите число");
                    }


            string text = null;
            int n = 0;
            int a;
            int b;


            while (p == 1)
            {
                int result = 0;
                n++;

                Console.WriteLine("Выберите действие" + "\n 1)сложение" + "\n 2)вычитание" + "\n 3)умножение" + "\n 4)деление" + "\n 5)выход");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите первое число");
                while(!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                }
                Console.WriteLine("Введите второе число");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                }

                switch (c)
                    {
                        case 1:
                            result = sum(a, b);
                            text = ($"Результат сложения равен: {result}");
                            break;

                        case 2:           
                            result = subtraction(a, b);
                            text = ($"Результат вычетания равен: {result}");
                            break;

                        case 3:            
                            result = multiplication(a, b);
                            text = ($"Результат умножения равен: {result}");
                            break;

                        case 4:
                            if (b != 0)
                            {
                                result = division(a, b);
                                text = ($"Результат деления равен: {result}");
                            }

                            else
                            {
                                text = "Делить на 0 нельзя";
                            }                     
                            break;

                        case 5:
                            goto begin;

                        default:
                            Console.WriteLine("Действие не выбрано");
                            break;

                    }
                

                Console.WriteLine("=============================");

                Console.WriteLine(text);
                Console.WriteLine("=============================");
                Console.WriteLine("Количество операций вычисления: " + n);
                Console.WriteLine("=============================");
               
            }
            
        }
    }
}


