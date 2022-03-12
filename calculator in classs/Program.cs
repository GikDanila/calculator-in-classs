using System;

namespace Calculatorrrrr
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool quit = false;
                float first = 0;
                float second = 0;
                float res = 0;
                string oper;
                do
                {
                    do
                    {
                        Console.WriteLine("Введите первое число:");
                        if (float.TryParse(Console.ReadLine(), out first))
                        {
                            break;
                        }
                    }
                    while (true);

                    Console.WriteLine("Введите оператор:");
                    oper = Console.ReadLine();


                    do
                    {
                        Console.WriteLine("Введите второе число:");
                        if (float.TryParse(Console.ReadLine(), out second))
                        {
                            break;
                        }
                    }
                    while (true);



                    switch (oper)
                    {
                        case "+":
                            Console.WriteLine("Сумма чисел составляет: " + (res = Sum(first, second)));
                            break;
                        case "-":
                            Console.WriteLine("Разность чисел состовляет: " + (res = Sub(first, second)));
                            break;
                        case "*":
                            Console.WriteLine("Произведение чисел составляет: " + (res = Mult(first, second)));
                            break;
                        case "/":
                            Console.WriteLine("Отношение чисел составляет: " + (res = Div(first, second)));
                            break;
                        case "L":
                            {
                                quit = true; break;
                            }
                        default:
                            {
                                Console.WriteLine("Неизвестный оператор.");
                                break;
                            }


                            ///if (oper == '+')
                            ///{
                            ///  res = Sum(a, b);
                            ///}
                            ///else if (oper == '-')
                            ///{
                            /// res = Sub(a, b);
                            /// }
                            ///else if (oper == '*')
                            ///{
                            ///   res = Mult(a, b);
                            ///}
                            ///else if (oper == '/')
                            ///{
                            ///    res = Div(a, b);
                            ///}
                            ///else
                            ///{
                            ///   Console.WriteLine("Неизвестный оператор.");
                            ///}
                            ///Console.WriteLine("Результат {0}", res);
                            /// Console.ReadLine();




                    }

                } while (!quit);
            }
        }
        static float Sum(float first, float second)
        {
            return first + second;
        }
        static float Sub(float first, float second)
        {
            return first - second;
        }
        static float Mult(float first, float second)
        {
            return first * second;
        }
        static float Div(float first, float second)
        {
            float result;

            if (second == 0)
            {
                Console.WriteLine("На ноль не делится");
                result = 0;
            }
            else
            {
                return first / second;
            }
            return result;
        }
    }
}
