using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{


    public partial class Form1 : Form
    {
        string godine = null;
        string[] strplatform = new string[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            for (int i = 1; i < 7; i++)
                strplatform[i] = null;

            if (platform1.Checked)
            {
                strplatform[1] = "Java :-: ";
            }
            if (platform2.Checked)
            {
                strplatform[2] = "IOS :-: ";
            }
            if (platform3.Checked)
            {
                strplatform[3] = "SQL :-: ";
            }

            if (platform4.Checked)
            {
                strplatform[4] = "Android :-: ";
            }
            if (platform5.Checked)
            {
                strplatform[5] = ".Net :-: ";
            }
            if (platform6.Checked)
            {
                strplatform[6] = "Python :-: ";
            }


            if (year4.Checked)
                {
                    godine = ">5 godina";
                }
                else if (year3.Checked)
                {
                    godine = "3 do 5 godina";
                }
                else if (year2.Checked)
                {
                    godine = "1 do 3 godina";
                }
                else if (year1.Checked)
                {
                    godine = "<1 godina";
                    
                }
          

                    _ = MessageBox.Show("Godina iskustva u programiranju: " + godine + "\n" + "platforme : "+strplatform[1]+strplatform[2]+strplatform[3]+strplatform[4]+strplatform[5]+strplatform[6]);
            
        }
    }   
}