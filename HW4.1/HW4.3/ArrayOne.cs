using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._3
{
    class ArrayOne
    {
        int[] a;
        int n;
        int down;
        int top;
        int step;

        /// <summary>
        /// конструктор для создания одномерного массива
        /// </summary>
        /// <param name="N">длина массива</param>
        /// <param name="Down">нижний диапазон числа</param>
        /// <param name="Top">верхний диапазон числа</param>
        /// <param name="step">шаг</param>
        /// <returns></returns>
        public ArrayOne(int N, int Down, int Top, int Step)

        {
            a = new int[n = N];
            Random r = new Random();
            for (int i = 0; i < a.Length; i += step = Step)
            {
                a[i] = r.Next(down = Down, top = Top + 1);

            }
        }

        /// <summary>
        /// конструктор для инициализации массива
        /// </summary>
        public ArrayOne(int N)
        {
            a = new int[N];
        }

        /// <summary>
        /// метод для вывода массива на консоль 
        /// </summary>
        /// <returns></returns>
        public string GetArrayOne()
        {
            string t = string.Empty;

            foreach (var e in a)
            {
                t += $"{e} ";
            }
            return t;
        }

        /// <summary>
        /// метод суммы элементов массива
        /// </summary>
        /// <returns></returns>
        public int SumArray()
        {
            int sum = 0;
            foreach (var e in a) { sum += e; }
            return sum;
        }

        /// <summary>
        /// свойство возвращающее сумму элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                return SumArray();
            }

        }

        /// <summary>
        /// метод индексирования
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get { return a[index]; }
            set { a[index] = value; }

        }

        /// <summary>
        /// метод возврата элементов массива с измененными знаками
        /// </summary>
        /// <returns></returns>
        public ArrayOne Inverse(ArrayOne array)
        {

            ArrayOne array1 = new ArrayOne(array.n, array.down, array.top, array.step);

            for (int i = 0; i < array.n; i++)
            {
                array1[i] = array[i] *= -1;
                array[i] = array1[i] * -1;
            }


            return array1;





        }

        /// <summary>
        /// метод умножения элементов массива на заданное число
        /// </summary>
        /// <param name="array"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public ArrayOne Multi(ArrayOne array, int number)
        {
            ArrayOne array1 = new ArrayOne(array.n, array.down, array.top, array.step);

            for (int i = 0; i < array.n; i++)
            {
                array1[i] = array[i] *= number;
                array[i] = array1[i] / number;

            }
            return array1;

        }

        /// <summary>
        /// метод возврата кол-ва максимальных элементов
        /// </summary>
        /// <returns></returns>
        public int MaxCount()
        {
            int maxCount = 0;
            int maxValue = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                maxValue = (a[i] > maxValue) ? a[i] : maxValue;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == maxValue) maxCount++;
            }

            return maxCount;

        }

        /// <summary>
        /// метод чтения элементов массива структуры
        /// </summary>
        public int Count { get { return a.Length; } }

    }
}
