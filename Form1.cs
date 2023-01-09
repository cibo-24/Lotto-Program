using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();

            int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6;
            int loto1, loto2, loto3, loto4, loto5, loto6;

            sayi1= Convert.ToInt32(textBox1.Text);
            sayi2= Convert.ToInt32(textBox2.Text);
            sayi3= Convert.ToInt32(textBox3.Text);
            sayi4= Convert.ToInt32(textBox4.Text);
            sayi5= Convert.ToInt32(textBox5.Text);
            sayi6= Convert.ToInt32(textBox6.Text);

            loto1=rnd.Next(1,10);
            loto2=rnd.Next(1,10);
            loto3=rnd.Next(1,10);
            loto4=rnd.Next(1,10);
            loto5=rnd.Next(1,10);
            loto6=rnd.Next(1,10);

            label2.Text = loto1.ToString();
            label3.Text = loto2.ToString();
            label4.Text = loto3.ToString();
            label5.Text = loto4.ToString();
            label6.Text = loto5.ToString();
            label7.Text = loto6.ToString();


            if (sayi1==loto1)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor= Color.Red;
            }

            if (sayi2==loto2)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor=Color.Red;
            }
            if (sayi3==loto3)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (sayi4==loto4)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor= Color.Red; 
            }
            if (sayi5==loto5)
            {
                textBox5.BackColor = Color.Green;   
            }
            else
            {
                textBox5.BackColor= Color.Red;
            }
            if (sayi6==loto6)
            {
                textBox6.BackColor = Color.Green;
            }
            else
            {
                textBox6.BackColor= Color.Red;
            }
        }
    }
}
