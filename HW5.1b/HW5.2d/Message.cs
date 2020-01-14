using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._2d
{
    class Message
    {
        string[] Arr;
        string Text;

        /// <summary>
        /// Метод частотного анализа текста
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public Dictionary<string, int> CountWord(string[] arr, string text)
        {
            this.Arr = arr;
            this.Text = text;

            Dictionary<string, int> temp = new Dictionary<string, int>();
            string a = text.ToLower();
            StringBuilder b = new StringBuilder(a);

            for(int i = 0; i < b.Length;)
            {
                if (char.IsPunctuation(b[i])) // проверяем на наличие знаков препинания 
                {
                    b.Remove(i, 1);
                }
                else ++i;
            }

            string c = b.ToString();
            char[] separator = { ' ' }; // создали массив-разделитель строки на элементы
            string[] elements = c.Split(separator); // разбили строку на элементы, положив в новый массив
            
            for(int i = 0; i < elements.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (elements[i] == arr[j])
                    {
                        if (!temp.ContainsKey(arr[j]))
                        {
                            temp.Add(arr[j], 1);
                        }
                        else temp[arr[j]]++;
                    }
                }
            }

            return temp;
        }
    }
}
