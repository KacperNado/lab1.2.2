using System;
using System.Windows.Forms;
using Lab12Library;

namespace lab1._2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        calculate cal = new calculate();

        private void Form1_ParentChanged(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                calculate cal = new calculate();
                int i = cal.Add(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
                txtResult.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = cal.Subtract(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
                txtResult.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
