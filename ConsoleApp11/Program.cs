using System;

namespace ConsoleApp11
{
    class Program
    {


        static MyStack<int> Zapolnenie(int a)
        {
            if (a <= 0)
            {
                throw new Exception("Введены неверные данные");
            }
            MyStack<int> newStack = new MyStack<int>();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Введите число");
                newStack.Push(int.Parse(Console.ReadLine()));
            }
            return newStack;
        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("1.Создать Стек");
            Console.WriteLine("2.Вывести Стек");
            Console.WriteLine("3.Поместить однозначные числа в один стек, двухзначные – в другой. Все остальные числа удалить из стека.");
            Console.WriteLine("4.Удалить из стека первый элемент и поместить его в вершину стека.");
            Console.WriteLine("Esc. Выход из программы");

        }

        static void Main()
        {
            PrintMenu();
            MyStack<int> myStack = new MyStack<int>();
            ConsoleKeyInfo K = new ConsoleKeyInfo();
            do
            {
                try
                {
                    K = Console.ReadKey();
                    switch (K.Key)
                    {
                        case ConsoleKey.Enter:
                            PrintMenu();
                            break;
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            {
                                Console.WriteLine();
                                Console.WriteLine("Введите величину стека N");
                                myStack = Zapolnenie(
                                    int.Parse(
                                        Console.ReadLine()));
                                break;
                            }
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            {
                                Console.WriteLine();
                                Console.WriteLine(myStack);
                                break;

                            }
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            {
                                Console.WriteLine();
                                myStack.Duplet(out MyStack<int> o, out MyStack<int> d);

                                Console.WriteLine("Стек с однозначными числами");
                                Console.WriteLine(o);

                                Console.WriteLine("Стек с двузначными числами");
                                Console.WriteLine(d);

                                Console.WriteLine("Исходный стек");
                                Console.WriteLine(myStack);

                                break;
                            }
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            {
                                Console.WriteLine();
                                myStack.FirstToLast();
                                Console.WriteLine(myStack);
                                break;
                            }
                        default: break;
                    }
                }
                catch (Exception obj)
                {
                    Console.WriteLine(obj.Message);
                }
            }
            while (K.Key != ConsoleKey.Escape);
        }

    }
}
