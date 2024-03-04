using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            string temp = richTextBox1.Text;

            int t = richTextBox1.Find(Text);
            Console.WriteLine(t);

            while (t != -1)
            {
                richTextBox1.Select(t, Text.Length);
                richTextBox1.SelectionColor = Color.Red;
                try
                {
                    temp = temp.Substring(t + Text.Length, (temp.Length - 1) - (t + Text.Length - 1));
                } catch (Exception ex) 
                { 
                    break; 
                }
                t = temp.IndexOf(Text) + richTextBox1.Text.Length - temp.Length;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace(textBox1.Text, textBox2.Text);     
        }
    }
}
