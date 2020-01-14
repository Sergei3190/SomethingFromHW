using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._1
{
    class Program
    {
        /// <summary>
        /// метод заполнения элементов массива случайными числами из заданного диапазона
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="Down"></param>
        /// <param name="Top"></param>
        /// <returns></returns>
        static public int[] Fill(int[] arr,int Down, int Top)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(Down, Top + 1);
            }
            return arr;
        }

        static void Main(string[] args)
        {
            //Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
            //Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, 
            //в которых только одно число делится на 3.В данной задаче под парой подразумевается два подряд идущих элемента массива. 
            //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

            //int[] array = new int[5] { 6, 2, 9, -3, 6 }; // проверочный массив

            int[] array = new int[20];

            int count = 0;

            array = Fill(array, -10000, 10000);

            foreach (var e in array) { Console.Write($"{e} "); }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                int j = i + 1;
                while(j < array.Length)
                {
                    if (array[i] % 3 == 0 && array[j] % 3 != 0 || array[i] % 3 != 0 && array[j] % 3 == 0)
                    {
                        count++;
                    }
                    break;
                }
                #region Option2
                //for (int j = i + 1; j < array.Length; j++)
                //{
                //    if (array[i] % 3 == 0 && array[j] % 3 != 0 || array[i] % 3 != 0 && array[j] % 3 == 0)
                //    {
                //        count++;
                //    }
                //    break;
                //}
                #endregion
            }

            Console.Write($"Количество пар , в которых только одно число делится на 3 в текущем массиве: {count}");

            Console.ReadKey();
        }
    }
}
