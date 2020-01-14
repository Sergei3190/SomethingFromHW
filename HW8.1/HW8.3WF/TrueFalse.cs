using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace HW8._3WF
{
    //класс для вопроса 
    [Serializable]// указали, что класс может быть сериализован
    public class Question
    {
        public string text; // указали текст вопроса
        public bool trueFalse; // правда или нет 
        // Здесь мы нарушаем правила инкапсуляции и эти поля нужно было бы реализовать через открытые свойства, 
        //но для упрощения примера оставим так
        // Вам же предлагается сделать поля закрытыми и реализовать открытые свойства Text и TrueFalse
        // Для сериализации должен быть пустой конструктор.

        /// <summary>
        /// конструктор для сериализации
        /// </summary>
        public Question()
        {
        }

        /// <summary>
        /// конструктор для создания экземпляра класса Question
        /// </summary>
        /// <param name="text">текст вопроса</param>
        /// <param name="trueFalse">правда или нет</param>
        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }



    class TrueFalse
    {
        // Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
        string fileName;
        List<Question> list;

        /// <summary>
        /// свойство с доступом к значению
        /// </summary>
        public string FileName
        {
            //get { return fileName; }
            set { fileName = value; }
        }

        /// <summary>
        /// конструктор для создания экземпляра класса TrueFalse
        /// </summary>
        /// <param name="fileName">имя файла</param>
        public TrueFalse(string FileName)
        {
            this.fileName = FileName;
            list = new List<Question>();
        }

        /// <summary>
        /// метод добавления вопроса в коллекцию
        /// </summary>
        /// <param name="text">текст вопроса</param>
        /// <param name="trueFalse">правда или нет</param>
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }


        /// <summary>
        /// метод для удаления из коллекции по индексу
        /// </summary>
        /// <param name="index">индекс элемента</param>
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        /// <summary>
        /// Индексатор - свойство для доступа к закрытому объекту
        /// </summary>
        /// <param name="index">индекс элемента</param>
        /// <returns></returns>
        public Question this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }

        }

        /// <summary>
        /// метод сериализации 
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }



        /// <summary>
        /// метод десериализации
        /// </summary>
        public void Load()
        {          
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = xmlFormat.Deserialize(fStream) as List<Question>;
            fStream.Close();                 
        }

        /// <summary>
        /// свойство доступа к длине коллекции 
        /// </summary>
        public int Count
        {
            get { return list.Count; }
            set { Count = value; }
        }

    }
}
