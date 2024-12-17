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

            string[] ArrayPractice = new string[10];
            string[] input = "이름, 나이, 전화번호".Split(',');

            ArrayPractice[0] = "동해 물과 백두산이".IndexOf("백두산이").ToString();
            ArrayPractice[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            ArrayPractice[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            ArrayPractice[3] = "그 사람의 그림자는 그랬다".Replace("그", "이");
            ArrayPractice[4] = "삼성 갤럭시".Insert(3, "애플");
            ArrayPractice[5] = "오늘은 왠지 더 배고프다".Remove(7, 1);
            ArrayPractice[6] = input[0];
            ArrayPractice[7] = input[1];
            ArrayPractice[8] = input[2];
            ArrayPractice[9] = "우리 나라 만세".Substring(3, 2);



            //출력
            for (int i = 0; i < ArrayPractice.Length; i++)
            {
                TextBox_Print.Text += ArrayPractice[i]+"\r\n";
                //Console.WriteLine($"ArrayPractice[{i}] = {ArrayPractice[i]}");
            }
            //byte AcademyAverageAge = 29;
            //short RoomTemperature = 24;
            //int CurrentBalance = 3000000;
            //float MyTemperature = 36.5f;
            //double piValue = 3.14159265359;
            //decimal productPrice = 20000.4m;
            ////double 

            //TextBox_Print.Text += $"{AcademyAverageAge.GetType()}" + " " + "AcademyAverageAge" + " " + $"{AcademyAverageAge.ToString()}" +"\r\n";
            //TextBox_Print.Text += $"{RoomTemperature.GetType()}" + " " + "RoomTemperature" + " " + $"{RoomTemperature.ToString()}" + "\r\n";
            //TextBox_Print.Text += $"{CurrentBalance.GetType()}" + " " + "CurrentBalance" + " " + $"{CurrentBalance.ToString()}" + "\r\n";
            //TextBox_Print.Text += $"{MyTemperature.GetType()}" + " " + "MyTemperature" + " " + $"{MyTemperature.ToString()}" + "\r\n";
            //TextBox_Print.Text += $"{piValue.GetType()}" + " " + "piValue" + " " + $"{piValue.ToString()}" + "\r\n";
            //TextBox_Print.Text += $"{productPrice.GetType()}" + " " + "productPrice" + " " + $"{productPrice.ToString()}" + "\r\n";


        }
    }
}
