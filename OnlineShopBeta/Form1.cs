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
            Single summ = 0;
            for (int i = 0; i < float.Parse(textBox1.Text); i++)
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
            for (int i = 0; i < float.Parse(textBox1.Text); i++)
                listBox4.Items.Add(listBox3.SelectedItem.ToString());
            for (int i = 0; i < listBox4.Items.Count; i++) 
            {
                summ = summ + float.Parse(listBox4.Items[i].ToString());
            }
            label7.Text = summ.ToString() + " тенге";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Single chosed = listBox1.SelectedIndex;
            listBox3.SelectedIndex = listBox1.SelectedIndex;
            switch(chosed){
                case 0:
                    pictureBox1.Image = Image.FromFile("../../img/apple.jpg");
                    textBox1.Text = "1";
                    label3.Text = "Яблоко";
                    Single k = float.Parse(textBox1.Text), c = 500;
                    label4.Text = (k * c).ToString() + " тенге";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && float.Parse(textBox1.Text) > 1)
            {
                Single a = float.Parse(textBox1.Text);
                a -= 1;
                textBox1.Text = a.ToString();
                label5.Text = "";
                Single k = float.Parse(textBox1.Text), c = 500; 
                label4.Text = (k * c).ToString() + " тенге"; 
            }
            else if (textBox1.Text != "")
            {
                label5.Text = "Число товаров не может быть меньше одного!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Single a = float.Parse(textBox1.Text);
                a += 1;
                textBox1.Text = a.ToString();
                label5.Text = "";
                Single k = float.Parse(textBox1.Text), c = float.Parse(listBox3.SelectedItem.ToString());
                label4.Text = (k * c).ToString() + " тенге";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label7.Text != "0 тенге")
            {
                MessageBox.Show("Спасибо за покупку! С вашего баланса списано " + label7.Text, "Покупка совершена успешно!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Single summ = 0;
            if (listBox2.Items.Count > 0 && listBox4.Items.Count > 0 && listBox2.SelectedIndex >= 0 && listBox4.SelectedIndex >= 0)
            {
                listBox4.Items.Remove(listBox4.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                summ = summ + float.Parse(listBox4.Items[i].ToString());
            }
            label7.Text = summ.ToString() + " тенге";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../img/no.png"); 
            textBox1.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.SelectedIndex = listBox2.SelectedIndex;
        }
    }
}
