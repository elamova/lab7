﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string cont;
            Console.WriteLine("Здравствуйте! Вас приветствует программа Калькулятор!");
            do
            {

                double fn;
                double sn;
                string o;
                double answ;

                Console.Clear();
                Console.WriteLine("Первое число: ");
                fn = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выбор действия *, /, +, -, %, ^ ");
                o = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Второе число: ");
                sn = Convert.ToDouble(Console.ReadLine());

                if (o == "+")
                {

                    answ = fn + sn;
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "-")
                {

                    answ = fn - sn;
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "*")
                {

                    answ = fn * sn;
                    Console.WriteLine("Результат: " + answ);

                }
                if (o == "/")
                {
                    if (sn != 0)
                    {
                        answ = fn / sn;
                        Console.WriteLine("Результат: " + answ);
                    }
                    else Console.WriteLine("Делить на ноль нельзя");

                }
                if (o == "%")
                {

                    answ = fn % sn;
                    Console.WriteLine("Результат: " + answ);

                }
                if (o == "^")
                {
                    answ = Math.Pow(fn, sn);
                    Console.WriteLine("Результат: " + answ);
                }
                Console.WriteLine("Совершить еще одну операцию или выйти?");
                cont = Convert.ToString(Console.ReadLine());
            } while (cont == "yes");
        }
    }
}
