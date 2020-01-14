using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._2d
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            //д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст,
            //в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
            //Здесь требуется использовать класс Dictionary.

            string[] word = {"солнце","и","привет","вот","пока"};

            string Text = "Солнце рано уходило, солнце вовсе не взошло, солнце всех нас проводило, и за ширмачку ушло. Вот и привет, пока, привет - пока.";

            Message ms = new Message();

            var res = ms.CountWord(word, Text);

            foreach (var e in res)
            {

                Console.WriteLine($"{e}");
            }

            Console.ReadKey();

        }
    }
}
