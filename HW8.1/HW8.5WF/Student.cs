using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace HW8._5WF
{
    [Serializable]
    public class Student
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
        /// пустой конструктор для сериализации
        /// </summary>
        public Student()
        {

        }

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


        public override string ToString()
        {
            return $"{lastName} {firstName} {university} {faculty} {department} {age} {course} {group} {city} ";
        }

    }
    class List
    {
        string fileName;
        List<Student> list;

        /// <summary>
        /// свойство доступа к значению
        /// </summary>
        public string FileName
        {
            set { fileName = value; }
        }

        /// <summary>
        /// конструктор для создания экземпляра класса List
        /// </summary>
        /// <param name="FileName">имя файл</param>
        /// <param name="List">коллекция</param>
        public List(string FileName, List<Student> List)
        {
            this.fileName = FileName;
            this.list = List;
        }

        /// <summary>
        /// метод сериализации
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
    }
}
