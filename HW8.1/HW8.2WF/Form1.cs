using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8._2WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Создайте простую форму на которой свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
            textBox1.DataBindings.Add(new Binding("Text", numericUpDown1, "Value"));

        }

    }
}
