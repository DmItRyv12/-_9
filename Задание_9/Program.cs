using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int a;
                int b;
                string c;
                Console.WriteLine("Вас приветствует калькулятор!");
                try
                {
                    Console.Write("Введите целое число х =");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите целое число y =");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    Console.ReadLine();
                    continue;
                }
                Console.Write("Выберете код операции: \n 1 сложение \n 2 вычитание\n 3 умножение\n 4 частное\n Введите код: ");
                c = Console.ReadLine();
                switch (c)
                {
                    case "1":
                        Console.WriteLine("Сумма чисел равна {0}", a + b);
                        break;
                    case "2":
                        Console.WriteLine("Разность чисел {0}", a - b);
                        break;
                    case "3":
                        Console.WriteLine("Произведение чисел {0}", a * b);
                        break;
                    case "4":
                        try
                        {
                            Console.WriteLine("Частное чисел {0} ", a / b);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Неверный код операции!");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
