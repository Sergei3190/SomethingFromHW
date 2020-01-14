using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW8._3WF
{
    public partial class Form1 : Form
    {
        // База данных с вопросами
        TrueFalse database;
        

        public Form1()
        {
            //а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок(не создана база данных,
            //обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
            //б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» 
            //улучшения на свое усмотрение.
            //в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
            //г)*Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).

            //Работа будет состоять из двух частей. В первой части нам нужно создать классы для работы с данными.
            //Во второй — Windows - приложение, которое позволит пользователю создавать базу данных вопросов.
            InitializeComponent();
            this.Text = "Верю-Не верю";
            toolStripAuthor.Click += ClickComp;
            toolStripVersion.Click += ClickComp;
            toolStripСopyright.Click += ClickComp;
        }

        private void ClickComp(object sender, EventArgs e)
        {
            if (sender == toolStripAuthor) textBox1.Text = "Лысков С.А.";
            else if (sender == toolStripVersion) textBox1.Text = "HW8.3WF";
            else if (sender == toolStripСopyright) textBox1.Text = "Copyright ©  2019";
        }

        // Обработчик пункта меню Exit
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Обработчик пункта меню New
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); // предложили пользователю выбрать место для сохранения нового списка
            if(sfd.ShowDialog() == DialogResult.OK) // проверили, выбранно ли место сохранения (нажата ли кнопка с надписью ОК)
            {
                database = new TrueFalse(sfd.FileName); //создаем новый список вопросов, сохраняя в выбранном пользователем файле
                database.Add("123", true);              
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                
            }
            

        }

        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            #region
            try
            {
                textBox1.Text = database[(int)nudNumber.Value - 1].text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"База не создана");

                //nudNumber.Minimum = 0;
                //nudNumber.Maximum = 0;               
                //nudNumber.Value = 0;
            }
            #endregion

            #region
            //if (new NullReferenceException() != null)
            //{
            //    MessageBox.Show($"База не создана");
            //    nudNumber.Minimum = 0;
            //    nudNumber.Maximum = 0;
            //    nudNumber.Value = 0;
            //}
            //else
            //{
            //    textBox1.Text = database[(int)nudNumber.Value - 1].text;
            //    cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            //}
            #endregion

            #region
            //try
            //{
            //    if (database == null)
            //    {
            //        nudNumber.Maximum--;
            //        if (nudNumber.Value >= 1) nudNumber.Value = 0;
            //        //throw new NullReferenceException();   
            //    }
            //    else
            //    {
            //        textBox1.Text = database[(int)nudNumber.Value - 1].text;
            //        cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            //    }
            //}
            //catch (NullReferenceException)
            //{
            //    MessageBox.Show($"Отсутствует база данных");
            //    return;
            //}
        }

        #endregion


        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных","Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;

           
        }

        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null)
            {
                MessageBox.Show($"Удаление не возможно");
                return;
            }
            
            database.Remove((int)nudNumber.Value-1);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
           
        }

        // Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e)
        {
          
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        // Обработчик пункта меню Open
        private void miOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    database = new TrueFalse(ofd.FileName);
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

        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database[(int)nudNumber.Value - 1].text = textBox1.Text;
                database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
            }
            else MessageBox.Show("База данных не создана");

        }

        // Обработчик кнопки cboxTrue
        private void cboxTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show($"Обращение к несуществующему вопросу");
               
            }
            
        }

        // Обработчик пункта меню Save As
        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                
                SaveFileDialog sf = new SaveFileDialog();
               
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    var database1 = database;
                    database = new TrueFalse(sf.FileName);
                    miSaveAs.Enabled = true;
                    for (int i = 0; i < database1.Count; i++)
                    {
                        textBox1.Text = database1[i].text;
                        cboxTrue.Checked = database1[i].trueFalse;
                        database.Add(textBox1.Text, cboxTrue.Checked);
                    }
                    database.Save();
                    
                }
            }
            else
            {
                MessageBox.Show($"База данныхх не создана");
            }
        }

        private void ToolStrip_ButtonClick(object sender, EventArgs e)
        {
            textBox1.Text = database[(int)nudNumber.Value - 1].text;
        }

        private void toolStripInfo_ButtonClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.SelectedText;
        }

        // Обработчик кнопки Author
        //private void toolStripAuthor_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = "Лысков С.А.";
        //}

        // Обработчик кнопки Version
        //private void toolStripVersion_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = "HW8.3WF";
        //}

        //// Обработчик кнопки Сopyright
        //private void toolStripСopyright_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = "Copyright ©  2019";
        //}
    }
}
