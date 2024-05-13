using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Onedimensional<T>
    {
        public T[] array;

        public const int Default_Capacity = 7;

        public Onedimensional() : this(Default_Capacity)
        {
        }

        public Onedimensional(int size)
        {
            array = new T[size];
        }

        public static void Rerollarray(T[] array)
        {
            Console.WriteLine();

            Console.WriteLine("Перевёрнутый массив");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[array.Length-1-i]} ");
            }
            Console.WriteLine();
        }

        public static void NumberOfElements(T[] array)
        {
            int Counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Counter++;
            }
            Console.WriteLine("Количество элементов в массиве:");
            Console.WriteLine(Counter);

            Console.WriteLine();
        }

        public static void NumberOfSpecificElements(T[] array, Func<T,bool> Func)
        {
            int CounterSpecificElements = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (Func(array[i]))
                {
                    CounterSpecificElements++;
                }
            }
            Console.WriteLine("Количество особых элементов:");

            Console.WriteLine(CounterSpecificElements);

            Console.WriteLine();
        }

        public static void ElementInArray(T[] array, Func<T,bool> Func)
        {
            bool IF = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (Func(array[i]))
                {
                    IF = true;
                }
            }
            Console.WriteLine("Есть ли особый элемент в массиве:");

            Console.WriteLine(IF);

            Console.WriteLine();
        }

        public static void DoToEveryElement(T[] array, Action<T> Action)
        {
            Console.WriteLine("Элементы с выполненным условием:");
            for (int i = 0; i < array.Length; i++)
            {
                Action(array[i]);
            }

            Console.WriteLine();

            Console.WriteLine();
        }

        public static void IfAllFollow(T[] array, Func<T,bool> Func)
        {
            bool IF = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (!Func(array[i]))
                {
                    IF = false;
                }
            }

            Console.WriteLine("Соответствуют ли все элементы условию:");

            Console.WriteLine(IF);

            Console.WriteLine();
        }

        public static void FirstElementInArray(T[] array,  Func<T,bool> Func)
        {
            Console.WriteLine("Первый элемент удовлетворяющий условию:");

            for (int i = 0; i < array.Length; i++)
            {
                if (Func(array[i]))
                {
                    Console.WriteLine(array[i]);

                    break;
                }
            }
            Console.WriteLine();
        }

        public static void All(T[] array,  Func<T,bool> Func)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Func(array[i]))
                {
                    Console.WriteLine(array[i]);
                }
            }

            Console.WriteLine("Элементы соответствующие условию:");

            Console.WriteLine();
        }
    }
}
