using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodHas_2024._12._16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            byte AcademyAverageAge = 29;
            short RoomTemperature = 24;
            int CurrentBalance = 3000000;
            float MyTemperature = 36.5f;
            double piValue = 3.14159265359;
            decimal productPrice = 20000.4m;
            //double 

            TextBox_Print.Text += $"{AcademyAverageAge.GetType()}" + " " + "AcademyAverageAge" + " " + $"{AcademyAverageAge.ToString()}" +"\r\n";
            TextBox_Print.Text += $"{RoomTemperature.GetType()}" + " " + "RoomTemperature" + " " + $"{RoomTemperature.ToString()}" + "\r\n";
            TextBox_Print.Text += $"{CurrentBalance.GetType()}" + " " + "CurrentBalance" + " " + $"{CurrentBalance.ToString()}" + "\r\n";
            TextBox_Print.Text += $"{MyTemperature.GetType()}" + " " + "MyTemperature" + " " + $"{MyTemperature.ToString()}" + "\r\n";
            TextBox_Print.Text += $"{piValue.GetType()}" + " " + "piValue" + " " + $"{piValue.ToString()}" + "\r\n";
            TextBox_Print.Text += $"{productPrice.GetType()}" + " " + "productPrice" + " " + $"{productPrice.ToString()}" + "\r\n";
            //TextBox_Print.Text = $"{AcademyAverageAge.GetType()}" + " " + "AcademyAverageAge" + " " + $"{AcademyAverageAge}";
            //TextBox_Print.Text = $"{AcademyAverageAge.GetType()}" + " " + "AcademyAverageAge" + " " + $"{AcademyAverageAge}";

        }
    }
}
