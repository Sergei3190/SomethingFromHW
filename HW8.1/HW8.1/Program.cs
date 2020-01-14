using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection; // для использования 
using System.Text;
using System.Threading.Tasks;

namespace HW8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //С помощью рефлексии выведите все свойства структуры DateTime

            DateTime d = new DateTime(1990,01,01 );
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(d.ToShortDateString());

            Console.WriteLine(d.GetType());
            
            var property = typeof(DateTime);
            Console.WriteLine(property.Attributes);
            Console.WriteLine(property.StructLayoutAttribute);
            Console.WriteLine(property.GetProperties());           
            Console.WriteLine();
            PropertyInfo[] propertyInfo = property.GetProperties();
            foreach (var item in propertyInfo)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
            Console.WriteLine(d.DayOfWeek);
            
            //Type type = typeof(int);
            //Console.WriteLine(type);

            Console.ReadKey();
        }
    }
}
