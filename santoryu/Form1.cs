using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace santoryu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            if (s1 > s2)
            {
                label3.Text = "1. Sayı 2.Sayıdan Büyüktür";
            }
            else if (s1 < s2)
            {
                label3.Text = "2. Sayı 1.Sayıdan Büyüktür";
            }
            else
            {
                label3.Text = "Sayılar Eşittir";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s1, s2, p, ort = 0;
            s1 = Convert.ToDouble(textBox4.Text);
            s2 = Convert.ToDouble(textBox3.Text);
            p = Convert.ToDouble(textBox5.Text);
            ort = (s1 + s2 + p) / 3;
            if (ort<50)
            {
                label7.Text = "1";
            }
            else if (ort<55)
            {
                label7.Text = "2";
            }
            else if (ort<70)
            {
                label7.Text = "3";
            }
            else if (ort<85)
            {
                label7.Text = "4";
            }
            else
            {
                label7.Text = "5";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ay;
            ay = Convert.ToInt32(textBox6.Text);
            switch (ay)
            {
                case 1:
                    label9.Text = "Ocak";
                    break;
                case 2:
                    label9.Text = "Şubat";
                    break;
                case 3:
                    label9.Text = "Mart";
                    break;
                case 4:
                    label9.Text = "Nisan";
                    break;
                case 5:
                    label9.Text = "Mayıs";
                    break;
                case 6:
                    label9.Text = "Haziran";
                    break;
                case 7:
                    label9.Text = "Temmuz";
                    break;
                case 8:
                    label9.Text = "Ağustos";
                    break;
                case 9:
                    label9.Text = "Eylül";
                    break;
                case 10:
                    label9.Text = "Ekim";
                    break;
                case 11:
                    label9.Text = "Kasım";
                    break;
                case 12:
                    label9.Text = "Aralık";
                    break;
                default:
                    label9.Text = "Hatalı Sayı Girdiniz...";
                    break;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenAy;
            secilenAy = comboBox1.SelectedItem.ToString();
            switch (secilenAy)
            {
                case "Aralık":
                case "Ocak":
                case "Şubat":
                    label10.Text = "KIŞ";
                    break;
                case "Mart":
                case "Nisan":
                case "Mayıs":
                    label10.Text = "İLK BAHAR";
                    break;
                case "Haziran":
                case "Temmuz":
                case "Ağustos":
                    label10.Text = "YAZ";
                    break;
                case "Eylül":
                case "Ekim":
                case "Kasım":
                    label10.Text = "SON BAHAR";
                    break;
            }
        }
    }
}
