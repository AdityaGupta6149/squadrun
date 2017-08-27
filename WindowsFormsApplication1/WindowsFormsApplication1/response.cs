using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class response : Form
    {
        public response()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var khelshuru = new khelshuru();
            khelshuru.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var home = new home();
            MessageBox.Show("Logging you out.");
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing see you again. :)");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var home = new home();
            home.Show();
            this.Hide();
        }

        private void response_Load(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\answer.txt");
            string[] lines1 = File.ReadAllLines(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\answer1.txt");
            int score = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string line1 = lines1[i];
                if (line.Equals(line1))
                {
                    score++;
                }
            }
            
            richTextBox1.Text = File.ReadAllText(@"C: \Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\answer.txt");
            richTextBox2.Text = File.ReadAllText(@"C: \Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\answer1.txt");
            richTextBox3.AppendText(score.ToString());

            if (score == 0)
            {
                MessageBox.Show("Your score is 0, try again.");                
                var khelshuru = new khelshuru();
                khelshuru.Show();
                this.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var home = new home();
            home.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var khelshuru = new khelshuru();
            khelshuru.Show();
            this.Hide();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
