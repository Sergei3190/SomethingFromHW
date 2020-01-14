using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "*2";
            btnReset.Text = "Cброс";
            btnGame.Text = "Играть";
            btnCancelMove.Text = "Отменить ход";
            lblNumber.Text = "0";
            lblCount.Text = "0";
            this.Text = "Удвоитель ";
            lblRandow.Text = "0";

        }

        List<string> numbers = new List<string>();

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            numbers.Add(lblNumber.Text);
            //this.Text += numbers.Last() + ' ';

            int n = Convert.ToInt32(lblNumber.Text);
            int s = Convert.ToInt32(lblRandow.Text);

            if (n >= s ) MessageBox.Show($"Вы получили заданное число за {lblCount.Text} количество попыток");

        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            numbers.Add(lblNumber.Text);
            //this.Text += numbers.Last() + ' ';

            int n = Convert.ToInt32(lblNumber.Text);
            int s = Convert.ToInt32(lblRandow.Text);

            if (n >= s) MessageBox.Show($"Вы получили заданное число за {lblCount.Text} количество попыток");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCount.Text = "0";
            numbers.Clear();            
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int s = r.Next(15, 87 + 1);
            MessageBox.Show($"Получите число {s} за минимальное кол-во попыток ");
            lblRandow.Text = (s.ToString());
        }

        private void btnCancelMove_Click(object sender, EventArgs e)
        {           
            int last = numbers.LastIndexOf(lblNumber.Text);
            numbers.RemoveAt(last);
            lblCount.Text = (int.Parse(lblCount.Text) - 1).ToString();
            lblNumber.Text = numbers.Last();
            //MessageBox.Show($"новое значение последнего элемента коллекции: {numbers.Last()}");
             
        }
    }
}
