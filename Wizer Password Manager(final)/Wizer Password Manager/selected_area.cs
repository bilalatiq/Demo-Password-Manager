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

namespace Wizer_Password_Manager
{
    public partial class selected_area : Form
    {
        public selected_area()
        {
            InitializeComponent();
            //this.Opacity = 0.90;
        }
        public static string a;
       
        private void selected_area_Load(object sender, EventArgs e)
        {
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==null && textBox2.Text==null)
            {
                MessageBox.Show("Please Enter Details");
            }
            else
            {
                string a = textBox1.Text + ".txt";
                if (File.Exists(a))
                {
                    string[] arr = File.ReadAllLines(a);
                    if (textBox2.Text== arr[1])
                    {
                        ForUser.currentuser = textBox1.Text;//passing data for current user
                        
                        
                        Dashboard_area dsa = new Dashboard_area();
                        dsa.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration obj = new registration();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    }
    }

