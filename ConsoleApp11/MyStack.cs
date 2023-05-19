using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    internal class MyStack<T> : Stack<T>
    {
        /// <summary>
        /// Задание 7. Создать стек заполненный элементами целого типа. 
        /// Удалить из стека первый элемент и поместить его в вершину стека.
        /// </summary>
        public void FirstToLast()
        {
            if (Count == 0) return;
            Stack<T> newStack = new Stack<T>();

            //Убираем все элементы, кроме последнего в новый стек.
            while (Count > 1)
                newStack.Push(Pop());

            //Записываем первый элемент в новую переменную.
            T a = Pop();

            //Возвращаем элементы в старый стек.
            while (newStack.Count > 0)
                Push(newStack.Pop());

            Push(a);
        }

        /// <summary>
        /// Задание 23. Создать стек из целых чисел. 
        /// Поместить однозначные числа в один стек, двухзначные – в другой. 
        /// Все остальные числа удалить из стека.
        /// </summary>
        /// <param name="OneSteck">Стек с однозначными числами</param>
        /// <param name="DuStack">Стек с двузначными числами</param>
        /// <exception cref="Exception"></exception>
        public void Duplet(out MyStack<T> OneSteck, out MyStack<T> DuStack)
        {
            OneSteck = new MyStack<T>();
            DuStack = new MyStack<T>();

            Stack<T> tmp = new Stack<T>();

            while (Count > 0)
            {
                T item = Pop();
                string itemStr = item.ToString().Replace("-", "");
                if (itemStr.Length > 2)
                    continue;
                else if (itemStr.Length == 1)
                    OneSteck.Push(item);
                else if (itemStr.Length == 2)
                    DuStack.Push(item);
                else
                    throw new Exception("Разрыв континума");
                tmp.Push(item);
            }

            while (tmp.Count > 0)
                Push(tmp.Pop());
        }

        public override string ToString()
        {
            return string.Join("\n", this);
        }
    }
}
