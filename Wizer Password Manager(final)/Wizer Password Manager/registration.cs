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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Please Insert full information for register");
            }
            else
            {
                login s = new login()
                {
                    Username = textBox1.Text,
                    Pass = textBox2.Text,
                    age = textBox3.Text,
                    Contact = textBox4.Text
                    


            };
                s.Insert();

                MessageBox.Show("Registration Succesfully");
                StreamWriter sw = new StreamWriter("admin.txt",true);
                sw.WriteLine(textBox1.Text);
                sw.Close();

                StreamWriter ab = new StreamWriter(textBox1.Text+".txt", true);
                ab.WriteLine(textBox1.Text);
                ab.WriteLine(textBox2.Text);
                ab.WriteLine(textBox3.Text);
                ab.WriteLine(textBox4.Text);
                ab.Close();
                selected_area obj = new selected_area();
                obj.Show();
                this.Hide();


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selected_area obj = new selected_area();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            selected_area obj = new selected_area();
            obj.Show();
            this.Hide();
        }
    }
}
