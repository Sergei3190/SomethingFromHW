using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и 
            //заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива,
            //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),
            //метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
            //б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            //е) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)

            ArrayOne arr = new ArrayOne(7, 1, 17, 2);

            Console.Write(arr.GetArrayOne());
            Console.WriteLine();
            Console.Write(arr.Sum);
            Console.WriteLine();
            Console.Write(arr[0]);
            Console.WriteLine();

            ArrayOne arr1 = arr.Inverse(arr);

            Console.WriteLine(arr.GetArrayOne());
            Console.WriteLine(arr1.GetArrayOne());

            ArrayOne arr2 = arr.Multi(arr, 2);
            Console.WriteLine(arr.GetArrayOne());
            Console.WriteLine(arr2.GetArrayOne());
            arr2[0] = 34;
            arr2[3] = 34;
            Console.WriteLine(arr2.GetArrayOne());
            Console.WriteLine(arr2.MaxCount());
            Console.WriteLine();

            // демонстрация работы библиотеки
            ArrayOneLibrary.ArrayOne Arr = new ArrayOneLibrary.ArrayOne(7, 1, 17, 2);
            Console.Write(Arr.GetArrayOne());
            Console.WriteLine();
            Console.Write(Arr.Sum);
            Console.WriteLine();
            Console.Write(Arr[0]);
            Console.WriteLine();

            ArrayOneLibrary.ArrayOne Arr1 = Arr.Inverse(Arr);

            Console.WriteLine(Arr.GetArrayOne());
            Console.WriteLine(Arr1.GetArrayOne());

            ArrayOneLibrary.ArrayOne Arr2 = Arr.Multi(Arr, 2);
            Console.WriteLine(Arr.GetArrayOne());
            Console.WriteLine(Arr2.GetArrayOne());
            Arr2[0] = 45;
            Arr2[3] = 45;
            Console.WriteLine(Arr2.GetArrayOne());
            Console.WriteLine(Arr2.MaxCount());
            Console.WriteLine();

            Dictionary<int, int> NumberEntriesArray = new Dictionary<int, int>();
            int value = 1;

            for (int i = 0; i < arr.Count; i++)
            {
                if (!NumberEntriesArray.ContainsKey(arr[i]))
                {
                    NumberEntriesArray.Add(arr[i], value);
                }
                else
                {
                    NumberEntriesArray[arr[i]]++;

                }
            }

            Console.WriteLine($"Частота вхождения каждого элемента в массив: ");
            foreach ( var e in NumberEntriesArray)
            {
                Console.WriteLine($"{e.Key} - {e.Value}");
            }


            Console.ReadKey();


        }
    }
}
