using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class signup : Form
    {
        string name; int f = 1;    
        public signup()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
                name = textBox1.Text;                           
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\user.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line.Equals(name))
                {
                    MessageBox.Show("This username is taken, try again.");
                    i = lines.Length;
                    f = 0;
                    var signup = new signup();
                    signup.Show();
                    this.Hide();
                }
            }

            if(f==1)
            {
                try
                {
                    String end_character = "\n";
                    File.AppendAllText("C:\\Users\\MAHE\\documents\\visual studio 2015\\Projects\\WindowsFormsApplication1\\WindowsFormsApplication1\\user.txt", name);
                    File.AppendAllText("C:\\Users\\MAHE\\documents\\visual studio 2015\\Projects\\WindowsFormsApplication1\\WindowsFormsApplication1\\user.txt", end_character);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                var login = new login();
                login.Show();
                this.Hide();
            }            
        }
    }
}
