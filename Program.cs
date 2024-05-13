using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы хотите заполнить массив сами? Введите Да или Нет");

            Console.WriteLine();

            if (Console.ReadLine() == "Да")
            {
                Console.WriteLine();

                Console.WriteLine("Введите длину массива:");

                Console.WriteLine();

                int Length = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Какой тип переменной вы хотитие? Введите int или double");

                Console.WriteLine();


                if (Console.ReadLine() == "int")
                {
                    Console.WriteLine();

                    int[] array = new int[Length];

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine("Введите элемент массива:");

                        array[i] = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                    }

                    Onedimensional<int>.Rerollarray(array);

                    Console.WriteLine();

                    Onedimensional<int>.NumberOfElements(array);

                    Onedimensional<int>.NumberOfSpecificElements(array, (x) => (x > 0) && (x<30));

                    Onedimensional<int>.ElementInArray(array, (x) => x % 2 == 0);

                    Onedimensional<int>.DoToEveryElement(array, (x) => Console.Write(x + "number"+ " "));

                    Onedimensional<int>.IfAllFollow(array, (x) => (x > 0));

                    Console.WriteLine();

                    Onedimensional<int>.FirstElementInArray(array, (x) => x % 3 == 0);

                    Onedimensional<int>.All(array, (x) => x < 0);
                }
                else
                {
                    Console.WriteLine();

                    double[] array = new double[Length];

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine("Введите элемент массива:");

                        array[i] = double.Parse(Console.ReadLine());

                        Console.WriteLine();
                    }

                    Onedimensional<double>.Rerollarray(array);

                    Console.WriteLine();

                    Onedimensional<double>.NumberOfElements(array);

                    Onedimensional<double>.NumberOfSpecificElements(array, (x) => (x > 0) && (x < 30));

                    Onedimensional<double>.ElementInArray(array, (x) => (x > 5.5));

                    Onedimensional<double>.DoToEveryElement(array, (x) => Console.Write(x + "number" + " "));

                    Onedimensional<double>.IfAllFollow(array, (x) => (x > 0));

                    Onedimensional<double>.FirstElementInArray(array, (x) => (x> 7.7));

                    Onedimensional<double>.All(array, (x) => x < 0);
                }
            }
            else
            {
                Console.WriteLine();

                int[] array = new int[7];

                Console.WriteLine("Какой тип переменной вы хотитие? Введите int или double");

                Console.WriteLine();

                Random random = new Random();

                if (Console.ReadLine() == "int")
                {

                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(-100,100);
                    }

                    Onedimensional<int>.Rerollarray(array);

                    Console.WriteLine();

                    Onedimensional<int>.NumberOfElements(array);

                    Onedimensional<int>.NumberOfSpecificElements(array, (x) => (x > 0) && (x < 30));

                    Onedimensional<int>.ElementInArray(array, (x) => x % 2 == 0);

                    Onedimensional<int>.DoToEveryElement(array, (x) => Console.Write(x + "number" + " "));

                    Onedimensional<int>.IfAllFollow(array, (x) => (x > 0));

                    Console.WriteLine();

                    Onedimensional<int>.FirstElementInArray(array, (x) => x % 3 == 0);

                    Onedimensional<int>.All(array, (x) => x < 0);
                }
                else
                {

                    double[] array1 = new double[7];

                    for (int i = 0; i < array1.Length; i++)
                    {
                        array1[i] = random.NextDouble();
                    }

                    Onedimensional<double>.Rerollarray(array1);

                    Console.WriteLine();

                    Onedimensional<double>.NumberOfElements(array1);

                    Onedimensional<double>.NumberOfSpecificElements(array1, (x) => (x > 0) && (x < 30));

                    Onedimensional<double>.ElementInArray(array1, (x) => (x > 5.5));

                    Onedimensional<double>.DoToEveryElement(array1, (x) => Console.Write(x + "number" + " "));

                    Onedimensional<double>.IfAllFollow(array1, (x) => (x > 0));

                    Onedimensional<double>.FirstElementInArray(array1, (x) => (x > 7.7));

                    Onedimensional<double>.All(array1, (x) => x < 0);
                }
            }
        }
    }
}
