using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ГЛАВНАЯ : Form
    {
        public ГЛАВНАЯ()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        private void телосложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            О_программе программа = new О_программе();
            программа.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Одно из полей не заполнено");
            }

            string p;
            string t;
            double v;
            double m;
            double f = 0;
            double kal = 0;

            v = Convert.ToDouble(textBox1.Text);
            m = Convert.ToDouble(textBox2.Text);



            if (comboBox2.SelectedIndex == 0)
            {
                switch (comboBox4.SelectedIndex)
                {
                    case 0: f = 0.6; break;
                    case 1: f = 0.8; break;
                    case 2: f = 1; break;

                }

            }
            if (comboBox2.SelectedIndex == 1)
            {
                switch (comboBox4.SelectedIndex)
                {
                    case 0: f = 1; break;
                    case 1: f = 1.3; break;
                    case 2: f = 1.5; break;

                }

            }
            if (comboBox2.SelectedIndex == 2)
            {
                switch (comboBox4.SelectedIndex)
                {
                    case 0: f = 1.4; break;
                    case 1: f = 1.7; break;
                    case 2: f = 2; break;

                }

            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (v > 17 && v < 31)
                {
                    kal = ((0.0621 * m + 2.0357) * 240) * f;
                }
                else
                {
                    if (v > 29 && v < 61)
                    {
                        kal = ((0.0342 * m + 3.5377) * 240) * f;
                    }
                    else
                    {
                        if (v > 59)
                        {
                            kal = ((0.0377 * m + 2.7545) * 240) * f;
                        }
                    }
                }
            }
            if (comboBox1.SelectedIndex == 0)
            {
                if (v > 17 && v < 31)
                {
                    kal = ((0.0630 * m + 2.8957) * 240) * f;
                }
                else
                {
                    if (v > 29 && v < 61)
                    {
                        kal = ((0.0484 * m + 3.6534) * 240) * f;
                    }
                    else
                    {
                        if (v > 59)
                        {
                            kal = ((0.04910 * m + 2.4587) * 240) * f;
                        }
                    }
                }
            }
            if (v > 17)
            {
                label6.Text = "Каллорий в день: " + kal;
            }
            else
            {
                label6.Text = "Ваш возраст должен быть 18+ ";
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Еда подробности = new Еда();
            подробности.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();

            textBox2.Text = "";
            textBox2.Clear();

            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;

            label6.Text = "";
            label6.Text = "Каллорий в день: ";
        }

        private void описаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Описание телосложение = new Описание();
            телосложение.ShowDialog();
        }

        private void примерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Примеры ПримерТела = new Примеры();
            ПримерТела.ShowDialog();
        }

       
    }
}
