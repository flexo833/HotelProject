using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Boolean vac1 = false;
        public Boolean vac2 = false;
        public Boolean vac3 = false;
        public Boolean vac4 = false;
        public Boolean vac5 = false;
        public Boolean vac6 = false;
        public Boolean vac7 = false;
        public Boolean vac8 = false;
        public Boolean vac9 = false;
        public Boolean vac10 = false;

        public int days1 = 0;
        public int days2 = 0;
        public int days3 = 0;
        public int days4 = 0;
        public int days5 = 0;
        public int days6 = 0;
        public int days7 = 0;
        public int days8 = 0;
        public int days9 = 0;
        public int days10 = 0;
        public String free = ("Number is free");
        public String vacant = ("Number is vacant");
        public String timeValue = (" days");
        Number1 number = new Number1();




        public Form1()


        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(textBox1.Text);
                //int j = Convert.ToInt32(textBox2.Text);
                

                switch (i)
                {
                    case 1:
                        TimeSpan j = ((dateTimePicker2.Value.Date).Subtract(dateTimePicker1.Value.Date));
                        number.setDays(j);
                        number.setStart(dateTimePicker1.Value.Date);
                        number.setFinish(dateTimePicker2.Value.Date);
                        number.setVac(true);
                        richTextBox1.Text = ("Vacancy from " + number.getStart() + " " + " to " + number.getFinish());
                        break;
                    case 2:
                        vac2 = true;
                        //days2 = j;
                        richTextBox1.Text = ("Success");
                        break;
                    case 3:
                        vac3 = true;
                        //days3 = j;
                        richTextBox1.Text = ("Success");
                        break;
                    case 4:
                        vac4 = true;
                        //days4 = j;
                        richTextBox1.Text = ("Success");
                        break;
                    case 5:
                        vac5 = true;
                        //days5 = j;
                        richTextBox1.Text = ("Success");
                        break;
                    case 6:
                        vac6 = true;
                        //days6 = j;
                        richTextBox1.Text = ("Success");
                        break;
                    case 7:
                        vac7 = true;
                        //days7 = j;
                        richTextBox1.Text = ("Success");
                        break;
                    case 8:
                        vac8 = true;
                        //days8 = j;
                        richTextBox1.Text = ("Success");
                        break;
                    case 9:
                        vac9 = true;
                        //days9 = j;
                        richTextBox1.Text = ("Success");
                        break;
                    case 10:
                        vac10 = true;
                        //days10 = j;
                        richTextBox1.Text = ("Success");
                        break;

                    default:
                        richTextBox1.Text = ("Unknown number");
                        break;



                }

            }
            catch (FormatException)
            {
                richTextBox1.Text = ("Unknown number!!!");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void button12_Click(object sender, EventArgs e)//Free numbers
        {
            try
            {
                int i = Convert.ToInt32(textBox1.Text);


                switch (i)
                {
                    case 1:
                        number.setVac(false);


                        richTextBox1.Text = ("Number 1 is free");
                        break;
                    case 2:
                        vac2 = false;

                        richTextBox1.Text = ("Number 2 is free");
                        break;
                    case 3:
                        vac3 = false;

                        richTextBox1.Text = ("Number 3 is free");
                        break;
                    case 4:
                        vac4 = false;

                        richTextBox1.Text = ("Number 4 is free");
                        break;
                    case 5:
                        vac5 = false;

                        richTextBox1.Text = ("Number 5 is free");
                        break;
                    case 6:
                        vac6 = false;

                        richTextBox1.Text = ("Number 6 is free");
                        break;
                    case 7:
                        vac7 = false;

                        richTextBox1.Text = ("Number 7 is free");
                        break;
                    case 8:
                        vac8 = false;

                        richTextBox1.Text = ("Number 8 is free");
                        break;
                    case 9:
                        vac9 = false;

                        richTextBox1.Text = ("Number 9 is free");
                        break;
                    case 10:
                        vac10 = false;

                        richTextBox1.Text = ("Number 10 is free");
                        break;

                    default:
                        richTextBox1.Text = ("Unknown number");
                        break;



                }

            }
            catch (FormatException)
            {
                richTextBox1.Text = ("Unknown number!!!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (number.getVac() == false)
            {
                richTextBox1.Text = free;
            }
            else richTextBox1.Text = vacant + ' ' + number.getDays() + timeValue + " from " + number.getStart() + " to " + number.getFinish();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vac2 == false)
            {
                richTextBox1.Text = free;
            }
            else richTextBox1.Text = vacant + ' ' + days2 + timeValue;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    
}


    

