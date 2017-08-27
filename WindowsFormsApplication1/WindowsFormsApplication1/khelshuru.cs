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
    public partial class khelshuru : Form
    {
        static int count = 0, f = 1;
        static int[] answer = new int[5];
        public khelshuru()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Images\1.jpg");
            Console.WriteLine("instance: " + count);
            load();
            if (count == 4)
                button1.Text = "Submit";

        }

        public void load()
        {
                        
            Random a = new Random();
            List<int> randomList = new List<int>();
            int MyNumber = 0;

            while (randomList.Count < 6)
            {
                MyNumber = a.Next(1, 10);
                if (!randomList.Contains(MyNumber))
                    randomList.Add(MyNumber);
            }


            pictureBox2.Image = Image.FromFile(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Images\\" + randomList[0] + ".jpg");
            pictureBox3.Image = Image.FromFile(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Images\\" + randomList[1] + ".jpg");
            pictureBox4.Image = Image.FromFile(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Images\\" + randomList[2] + ".jpg");
            pictureBox5.Image = Image.FromFile(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Images\\" + randomList[3] + ".jpg");
            pictureBox6.Image = Image.FromFile(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Images\\" + randomList[4] + ".jpg");
            pictureBox7.Image = Image.FromFile(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Images\\" + randomList[5] + ".jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int option = -1;
            if (radioButton1.Checked == true)
                option = 1;
            else if (radioButton2.Checked == true)
                option = 2;
            else if (radioButton3.Checked == true)
                option = 3;
            else if (radioButton4.Checked == true)
                option = 4;
            else if (radioButton5.Checked == true)
                option = 5;
            else if (radioButton6.Checked == true)
                option = 6;

            if (option == -1)
                MessageBox.Show("Select an input");
            else
            {
                if(f==1)
                {
                    answer[count] = option;

                    if (count == 4)
                    {
                        Console.Write("\nanswers:\n");
                        File.WriteAllText(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\answer.txt", String.Empty);
                        foreach (int ans in answer)
                        {
                            string mystring = ans.ToString();
                            string endcharacter = "\n";
                            File.AppendAllText(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\answer.txt", mystring);
                            File.AppendAllText(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\answer.txt", endcharacter);
                        }

                        MessageBox.Show("Player2 Turn.");
                        f = 0; count = 0;
                        khelshuru Check = new khelshuru();
                        Check.Show();
                        this.Hide();
                    }
                    else
                    {
                        count += 1;
                        khelshuru Check = new khelshuru();
                        Check.Show();
                        this.Hide();
                    }
                }

                else
                {
                    answer[count] = option;

                    if (count == 4)
                    {
                        Console.Write("\nanswers:\n");
                        File.WriteAllText(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\answer1.txt", String.Empty);
                        foreach (int ans in answer)
                        {
                            string mystring = ans.ToString();
                            string endcharacter = "\n";
                            File.AppendAllText(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\answer1.txt", mystring);
                            File.AppendAllText(@"C:\Users\MAHE\documents\visual studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\answer1.txt", endcharacter);
                        }
                        f = 1; count = 0;
                        response Check = new response();
                        Check.Show();
                        this.Hide();

                    }
                    else
                    {
                        count += 1;
                        khelshuru Check = new khelshuru();
                        Check.Show();
                        this.Hide();
                    }
                }


               
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
