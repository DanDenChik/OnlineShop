using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AblayandDanial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Single chosed = listBox1.SelectedIndex;
            switch(chosed){
                case 0:
                    pictureBox1.Image = Image.FromFile("C:/Users/dania/OneDrive/Рабочий стол/AblayandDanial/img/apple.jpg");
                    textBox1.Text = "1";
                    label3.Text = "Яблоко";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single a = float.Parse(textBox1.Text);
            if (textBox1.Text != "" && a > 1)
            {
                a -= 1;
                textBox1.Text = a.ToString();
                label5.Text = "";
            }
            else
            {
                label5.Text = "Число товаров не может быть меньше одного!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Single a = float.Parse(textBox1.Text);
            a += 1;
            textBox1.Text = a.ToString();
            label5.Text = "";
        }
    }
}
