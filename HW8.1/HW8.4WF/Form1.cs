using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HW8._4WF
{
    public partial class Form1 : Form
    {
        // База данных ДР
        Birthday database;

        public Form1()
        {
            // *Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения
            //данных(Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).

            InitializeComponent();
            this.Text = "Дни рождения";
            cboxWas.Click += ClickComp;
            cboxNow.Click += ClickComp;
                      
        }

        private void ClickComp(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show($"нет никакой даты рождения :-(");
                cboxNow.Checked = false;
                cboxWas.Checked = false;

            }
        
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                database = new Birthday(sfd.FileName);
                database.Add("Иван", "Иванов", new DateTime(2019, 07, 19 ).ToShortDateString());
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

      

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = DateTime.Today;
                textBox1.Text = (database[(int)nudNumber.Value - 1].name + " " + database[(int)nudNumber.Value - 1].surname + " " + database[(int)nudNumber.Value - 1].data);
                DateTime dateBirthday = Convert.ToDateTime(database[(int)nudNumber.Value - 1].data);                
         
                if (dateBirthday < dt)
                {
                    cboxWas.Checked = true;
                }
                else if (dateBirthday == dt)
                {
                    cboxNow.Checked = true;
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"База не создана");
            }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    database = new Birthday(opf.FileName);
                    database.Load();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Oшибка, неверный формат файла");
            }

        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");           
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if (database != null)
            {

                SaveFileDialog sf = new SaveFileDialog();

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    var database1 = database;
                    database = new Birthday(sf.FileName);
                    for (int i = 0; i < database1.Count; i++)
                    {                
                        database.Add(database1[i].name, database1[i].surname, database1[i].data);
                    }
                    database.Save();

                }
            }
            else
            {
                MessageBox.Show($"База данныхх не создана");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), (database.Count + 1).ToString(), new DateTime().ToShortDateString());
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database[(int)nudNumber.Value - 1].name = database[(int)nudNumber.Value - 1].name;
                database[(int)nudNumber.Value - 1].surname = database[(int)nudNumber.Value - 1].surname;
                database[(int)nudNumber.Value - 1].data = database[(int)nudNumber.Value - 1].data;
            }
            else MessageBox.Show("База данных не создана");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null)
            {
                MessageBox.Show($"Удаление не возможно");
                return;
            }

            database.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
       
    }
}
