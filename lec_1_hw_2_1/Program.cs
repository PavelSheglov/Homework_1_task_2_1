using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec_1_hw_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N=0, A=0;
            do
            {
                try
                {
                    Console.Write("Введите размерность массива N:");
                    N = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(N <= 0 ? "Размерность не может быть <= 0" : "");
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("Не корректное число!!!");
                }
            } while (N<=0);
            int[] arr = new int[N];
            Random rnd = new Random();
            const int leftborder = -100, rightborder = 100;
            for (int i = 0; i < N; i++)
                arr[i] = rnd.Next(leftborder, rightborder);
            do
            {
                do
                {
                    try
                    {
                        Console.Write($"Введите искомое целое число A в диапазоне [{leftborder}, {rightborder}]:");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine((A < leftborder || A > rightborder) ? "Число не попадает в диапазон" : "");
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Не корректное число!!!");
                    }
                } while (A < leftborder || A > rightborder);
                Console.WriteLine("Есть ли число A в массиве?");
                Console.WriteLine(Array.IndexOf(arr, A) >= 0 ? "Yes" : "No");
                Console.WriteLine();
                Console.WriteLine("Продолжить: Да (1), Нет (any)?");
            } while (Console.ReadLine()=="1");
            Console.WriteLine("Содержимое массива");
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
