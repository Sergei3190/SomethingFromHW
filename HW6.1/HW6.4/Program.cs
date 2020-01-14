using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6._4
{
    class Program
    {

        /// <summary>
        /// метод чтения файла через BinaryReader
        /// </summary>
        /// <param name="filename">имя файла</param>
        /// <returns></returns>
        public static int[] BinaryStreamSample(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            long n = fs.Length / 4; // определяем количество чисел в двоичном потоке
            int[] arr = new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = bw.ReadInt32();
            }
            bw.Close();
            return arr;
        }

        /// <summary>
        ///  метод чтения файла через StreamReader
        /// </summary>
        /// <param name="filename">имя файла</param>
        /// <returns></returns>
        public static string StreamReader(string filename)
        {
            //string t = File.ReadAllText(filename);
            StreamReader sw = new StreamReader(new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read));
            string text = sw.ReadToEnd();
            sw.Close();
            return text;
        }

        /// <summary>
        /// метод чтения файла через BufferedStream
        /// </summary>
        /// <param name="fileName">имя файла</param>
        /// <returns></returns>
        public static byte[] BufferedStreamReader(string fileName)
        {
            //byte[] buffer = File.ReadAllBytes(fileName);
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            int countPart = 4;//количество частей
            int bufsize = (int)(fs.Length / countPart);
            byte[] buffer = new byte[fs.Length];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Read(buffer,0,bufsize);
            fs.Close();

            return buffer;
        }

        /// <summary>
        /// метод чтения файла через FileStream
        /// </summary>
        /// <param name="fileName">имя файла</param>
        /// <returns></returns>
        public static List<byte> FileStreamReader(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            List<byte> arrByte = new List<byte>();
            while(fs.ReadByte() != -1)
            {
                try
                {
                    //int i = fs.ReadByte();
                    //byte b = Convert.ToByte(i);
                    //arrByte.Add(b);
                    arrByte.Add((byte)fs.ReadByte());
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }
            fs.Close();
            return arrByte;
        }


        static void Main(string[] args)
        {
            //**Считайте файл различными способами.Смотрите “Пример записи файла различными способами”. 
            //Создайте методы, которые возвращают массив byte(FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.
            
            long kbyte = 1024;
            long mbyte = 1024 * kbyte;
            long gbyte = 1024 * mbyte;
            long size = mbyte;
            //Write FileStream
            //Write BinaryStream
            //Write StreamReader/StreamWriter
            //Write BufferedStream

            Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSample("bigdata0.bin", size));
            Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSample("bigdata1.bin", size));
            Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSample("bigdata2.bin", size));
            Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSample("bigdata3.bin", size));

            List<byte> arrByte = new List<byte>(FileStreamReader("bigdata0.bin"));
            byte[] buffer = BufferedStreamReader("bigdata3.bin");
            string s = StreamReader("bigdata2.bin");
            int[] arr = BinaryStreamSample("bigdata1.bin");

                Console.ReadKey();

        }

        /// <summary>Метод записи в файл через FileStream</summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="size">Размер файла</param>
        /// <returns></returns>
        static long FileStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                fs.WriteByte(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>Метод записи в файл через BinaryStream</summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="size">Размер файла</param>
        /// <returns></returns>
        static long BinaryStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write((byte)0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>Метод записи в файл через StreamReader</summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="size">Размер файла</param>
        /// <returns></returns>
        static long StreamWriterSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>Метод записи в файл через BufferedStream</summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="size">Размер файла</param>
        /// <returns></returns>
        static long BufferedStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

    }
}
