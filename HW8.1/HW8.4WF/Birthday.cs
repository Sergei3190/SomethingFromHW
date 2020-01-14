using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace HW8._4WF
{
    [Serializable]
    public class Friends
    {
        public string name;
        public string surname;
        //public DateTime birthday;
        public string data;

        //создаем пустой конструктор для сериализации
        public Friends()
        {

        }

        /// <summary>
        /// конструктор для создания экземпляра класса Friends
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="birthday">дата рождения</param>
        public Friends(string Name, string Surname, string Data )
        {
            this.name = Name;
            this.surname = Surname;
            //this.birthday = Birthday;
            this.data = Data;
        }

    }


    class Birthday
    {
        string fileName;
        List<Friends> list;

        /// <summary>
        /// свойство доступа к значению
        /// </summary>
        public string FileName
        {
            set { fileName = value; }
        }

        /// <summary>
        /// конструктор для создания экземпляра класса Birthday
        /// </summary>
        /// <param name="FileName">имя файла</param>
        public Birthday(string FileName)
        {
            this.fileName = FileName;
            list = new List<Friends>();
        }

        /// <summary>
        /// метод добавления экземпляра класса Friends в коллекцию 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Surname"></param>
        /// <param name="Birthday"></param>
        public void Add(string Name, string Surname, string Data)
        {
            list.Add(new Friends(Name, Surname, Data));
        }

        /// <summary>
        /// метод удаления из коллекции по индексу 
        /// </summary>
        /// <param name="index">индекс</param>
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        /// <summary>
        /// Индексатор - свойство для доступа к закрытому объекту
        /// </summary>
        /// <param name="index">индекс</param>
        /// <returns></returns>
        public Friends this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        /// <summary>
        /// свойство доступа к длинне колекции
        /// </summary>
        public int Count
        {
            get { return list.Count; }
            set { Count = value; }
        }

        /// <summary>
        /// метод сериализации 
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Friends>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        /// <summary>
        /// метод десериализации
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Friends>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = xmlFormat.Deserialize(fStream) as List<Friends>;
            fStream.Close();
        }
    }
}
