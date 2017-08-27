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
    public partial class login : Form
    {
        static int flag = 1;
        string login_name,line;
        int f = 1;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            login_name = textBox1.Text;           
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string[] lines = File.ReadAllLines(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\user.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                line = lines[i];                
                if (line.Equals(login_name)) 
                {
                    i = lines.Length;
                    
                    if(flag==1)
                    {
                        flag = 0; f = 1;
                        MessageBox.Show("Authenticated for player 1, now login/signup for player 2.");
                        var home = new home();                     
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Authenticated for both players, now let the games begin");
                        var khelshuru = new khelshuru();
                        f = 0;
                        khelshuru.Show();
                        this.Hide();
                    }                   
                }
            }
            if (f == 1 && flag!=0)
            {
                MessageBox.Show("Not Authenticated,try again");
                var login = new login();
                login.Show();
                this.Hide();
            }

        }

    }
}
