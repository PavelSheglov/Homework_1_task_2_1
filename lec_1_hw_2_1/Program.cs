using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec_1_hw_2_1
{
    class Program
    {
        const int leftBorder = -100, rightBorder = 100;

        static void Main(string[] args)
        {
            int N=InputArraySize(), A=0;
            int[] arr = GenarateArray(N, leftBorder, rightBorder);
            do
            {
                A = InputNumber();
                ShowResultOfSearchingNumberInArray(arr, A);
                Console.WriteLine("Продолжить: Да (1), Нет (any)?");
            } while (Console.ReadLine()=="1");
            ShowArray(arr);
        }

        static int InputArraySize()
        {
            int N = 0;
            do
            {
                try
                {
                    Console.Write("Введите размерность массива N:");
                    N = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(N <= 0 ? "Размерность не может быть <= 0" : "");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Не корректное число!!!");
                }
            } while (N <= 0);
            return N;
        }

        static int[] GenarateArray(int size, int leftBorder, int rightBorder)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(leftBorder, rightBorder);
            return arr;
        }

        static int InputNumber()
        {
            int number = 0;
            do
            {
                try
                {
                    Console.Write($"Введите искомое целое число A в диапазоне [{leftBorder}, {rightBorder}]:");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine((number < leftBorder || number > rightBorder) ? "Число не попадает в диапазон" : "");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Не корректное число!!!");
                }
            } while (number < leftBorder || number > rightBorder);
            return number;
        }

        static void ShowResultOfSearchingNumberInArray(int[] array, int number)
        {
            Console.WriteLine("Есть ли число A в массиве?");
            Console.WriteLine(Array.IndexOf(array, number) >= 0 ? "Yes" : "No");
            Console.WriteLine();
        }

        static void ShowArray(int[] array)
        {
            Console.WriteLine("Содержимое массива");
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
