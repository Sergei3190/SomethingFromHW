using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HW6._3
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
  
        /// <summary>
        /// Создаем конструктор
        /// </summary>
        /// <param name="firstName">имя</param>
        /// <param name="lastName">фамилия</param>
        /// <param name="university">университет</param>
        /// <param name="faculty">факультет</param>
        /// <param name="department">кафедра</param>
        /// <param name="course">курс</param>
        /// <param name="age">возраст</param>
        /// <param name="group">группа</param>
        /// <param name="city">город</param>
        public Student(string lastName, string firstName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }

    }
    class Program
    {
        /// <summary>
        /// метод сортировки по фамилии
        /// </summary>
        /// <param name="st1">первый экземпляр коллекции</param>
        /// <param name="st2">второй экземпляр коллекции</param>
        /// <returns></returns>
        static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {

            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }

        /// <summary>
        /// метод сортировки по возрасту
        /// </summary>
        /// <param name="st1">первый экземпляр</param>
        /// <param name="st2">второй экземпляр</param>
        /// <returns></returns>
        public static int AgeSort(Student st1, Student st2)
        {
            return  String.Compare(st1.age.ToString(), st2.age.ToString()); 
        }

        /// <summary>
        /// метод сортировки по курсу и возрасту
        /// </summary>
        /// <param name="st1">первый экземпляр</param>
        /// <param name="st2">второй экземпляр</param>
        /// <returns></returns>
        public static int AgeCourseCompare(Student st1, Student st2)
        {
            if (st1.course > st2.course) return 1;
            if (st1.course < st2.course) return -1;
            if (st1.age > st2.age) return 1;
            if (st1.age < st2.age) return -1;
            return 0;

            //return st1.course == st2.course ? 0 : st1.course > st2.course ? 1 : -1; // можно так записывать , если нужна сортировка по одному полю
            // для сортировки в обратном порядке меняем местами 1 и -1
        }

        static void Main(string[] args)
        {
            //Переделать программу Пример использования коллекций для решения следующих задач:
            //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
            //в) отсортировать список по возрасту студента;
            //г) *отсортировать список по курсу и возрасту студента;

            int bakalavr = 0;
            int magistr = 0;
            int course5 = 0;
            int course6 = 0;
            int totalCount = 0;

            //Dictionary<int,int> studentCourse = new Dictionary<int, int>();
            List<Student> list = new List<Student>();
            // Создаем список студентов
            DateTime dt = DateTime.Now;
            Dictionary<int, int> dic = new Dictionary<int, int>(); // курс, сколько раз встречается нужный возвраст
            StreamReader sr = new StreamReader("Student2.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                    if (int.Parse(s[6]) == 5) course5++; else if (int.Parse(s[6]) == 6) course6++;
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20) totalCount++;
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                    {
                        if (!dic.ContainsKey(int.Parse(s[6])))
                        {
                            dic.Add(int.Parse(s[6]), 1);
                        }
                        else dic[int.Parse(s[6])]++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                        // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}, из них учится на 5 курсе - {1}, на 6 - {2} ", magistr, course5, course6);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            Console.WriteLine($"Всего студентов в возрасте от 18 до 20 лет: {totalCount}");
            Console.WriteLine($"студентов в возрасте от 18 до 20 лет на каждом курсе: ");
            foreach(var e in dic)
            {
                Console.WriteLine($"курс: {e.Key} - количество: {e.Value}");
            }
            list.Sort(new Comparison<Student>(AgeSort));
            Console.WriteLine("Сортировка студентов по возрасту: ");
            foreach(var a in list)
            {
                Console.WriteLine($"фамилия: {a.firstName} - возраст: {a.age}");
            }

            //list.Sort(new Comparison<Student>(AgeCourseCompare));
            list.Sort(AgeCourseCompare); // альтернатива синтаксису list.Sort(new Comparison<Student>(AgeCourseCompare));
            Console.WriteLine("Сортировка по курсу и возрасту студента: ");
            foreach (var a in list)
            {
                Console.WriteLine($"курс: {a.course} - возраст: {a.age}");
            }



            list.Sort(new Comparison<Student>(MyDelegat));
            foreach (var v in list) Console.WriteLine(v.firstName);
            Console.WriteLine(DateTime.Now - dt);



            Console.ReadKey();
        }

    }
}
