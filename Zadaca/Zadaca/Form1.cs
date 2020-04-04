using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
                 }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] platform = new string[10];
            string godineizbor = null;

            for (int i = 1; i < 7; i++)
                platform[i] = null;

            if (radioButton1.Checked)
            {
                godineizbor = ">5 godina";
            }
            else if (radioButton2.Checked)
            {
                godineizbor = "3 do 5 godina";
            }
            else if (radioButton3.Checked)
            {
                godineizbor = "1 do 3 godina";
            }
            else if (radioButton4.Checked)
            {
                godineizbor = "<1 godina";
            }

            if (checkBox1.Checked)
            {
                platform[1] = "Java -- ";
            }
            if (checkBox2.Checked)
            {
                platform[2] = "IOS -- ";
            }
            if (checkBox3.Checked)
            {
                platform[3] = "SQL -- ";
            }

            if (checkBox4.Checked)
            {
                platform[4] = "Android -- ";
            }
            if (checkBox5.Checked)
            {
                platform[5] = ".Net -- ";
            }
            if (checkBox6.Checked)
            {
                platform[6] = "Python -- ";
            }

             _ = MessageBox.Show("Godine iskustva: " + godineizbor + "\n" + "Platforme -- "+ platform[1]+ platform[2]+ platform[3]+ platform[4]+ platform[5]+ platform[6]);
        }
    }
}
