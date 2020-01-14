using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace HW8._5WF
{ 
    public partial class Form1 : Form
    {      
        List<Student> studentsInfo;
   
        public Form1()
        {
            //Написать программу - преобразователь из CSV в XML-файл с информацией о студентах(6 урок).
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            studentsInfo = new List<Student>();
            StreamReader sr = new StreamReader("Student1.csv");
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                Student student = (new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                studentsInfo.Add(student);
                textBox1.Text += student.ToString();
            }
            sr.Close();
          
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                List<Student> stIn = new List<Student>();
                for (int i = 0; i < studentsInfo.Count; i++)
                {
                    stIn.Add(studentsInfo[i]);
                }
                List xml = new List(sfd.FileName,stIn);
                xml.Save();
            }
        }
    }
}
