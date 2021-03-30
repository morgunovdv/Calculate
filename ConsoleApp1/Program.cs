using System;

namespace Calculate
{
    class Program
    {
        


        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static int Division(int a, int b)
        {
            return a / b;
        }

        static int CheckInput()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка ввода, введите число");
            }
            return x;
        }


        static void Main(string[] args)
        {
            int result;
            string text = null;
            int n = 0;
            int a;
            int b;
            int c;
            int p;

            Console.WriteLine("Выберите действие" + "\n 1) Начать вычисления" + "\n 2) Выйти");
            p = CheckInput();


            while (p == 1)
            {
                n++;
                Console.WriteLine("Выберите действие" + "\n 1)сложение" + "\n 2)вычитание" + "\n 3)умножение" + "\n 4)деление" + "\n 5)выход");
                c = CheckInput();
                Console.WriteLine("Введите первое число");
                a = CheckInput();
                Console.WriteLine("Введите второе число");
                b = CheckInput();

                switch (c)
                    {
                        case 1:
                            result = Sum(a, b);
                            text = ($"Результат сложения равен: {result}");
                            break;

                        case 2:           
                            result = Subtraction(a, b);
                            text = ($"Результат вычетания равен: {result}");
                            break;

                        case 3:            
                            result = Multiplication(a, b);
                            text = ($"Результат умножения равен: {result}");
                            break;

                        case 4:
                            if (b != 0)
                            {
                                result = Division(a, b);
                                text = ($"Результат деления равен: {result}");
                            }

                            else
                            {
                                text = "Делить на 0 нельзя";
                            }                     
                            break;

                        case 5:
                            Console.WriteLine("Выберите действие" + "\n 1) Начать вычисления" + "\n 2) Выйти");
                            p = CheckInput();
                            break;

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


