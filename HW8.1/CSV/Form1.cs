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

namespace CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //загрузка и чтение CSV файла
            InitializeComponent();
        }
    }

    string[] cars = File.ReadAllLines(@"C:\Cars.csv");

    private DataTable ReadCSVFile(string pathToCsvFile)
    {
        //создаём таблицу
        DataTable dt = new DataTable("Cars");
        //создаём колонки
        DataColumn colCompany;
        colCompany = new DataColumn("Company", typeof(String));
        DataColumn colName;
        colName = new DataColumn("Name", typeof(String));
        DataColumn colYear;
        colYear = new DataColumn("Year", typeof(Int32));
        DataColumn colMaxSpeed;
        colMaxSpeed = new DataColumn("MaxSpeed", typeof(Int32));
        DataColumn colPrice;
        colPrice = new DataColumn("Price", typeof(Double));
        //добавляем колонки в таблицу
        dt.Columns.AddRange(new DataColumn[] {colCompany, colName,
        colYear, colMaxSpeed,
        colPrice});
        try
        {
            DataRow dr = null;
            string[] carValues = null;
            string[] cars = File.ReadAllLines(pathToCsvFile);
            for (int i = 0; i < cars.Length; i++)
            {
                if (!String.IsNullOrEmpty(cars[i]))
                {
                    carValues = cars[i].Split(',');
                    //создаём новую строку
                    dr = dt.NewRow();
                    dr["Company"] = carValues[0];
                    dr["Name"] = carValues[1];
                    dr["Year"] = int.Parse(carValues[2]);
                    dr["MaxSpeed"] = int.Parse(carValues[3]);
                    dr["Price"] = Double.Parse(carValues[4]);
                    //добавляем строку в таблицу
                    dt.Rows.Add(dr);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return dt;
    }
}
