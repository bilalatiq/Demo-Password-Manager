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
    public partial class insert_area : Form
    {
        public insert_area()
        {
            InitializeComponent();
        }
        class11 cc = new class11();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dashboard_area obj = new Dashboard_area();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            cc.method2(textBox1, textBox2, textBox3);



            //StreamWriter sw = new StreamWriter(static_info.username + ".txt",true);
            //sw.WriteLine(textBox1.Text);
            //sw.WriteLine(textBox2.Text);
            //sw.WriteLine(textBox3.Text);
            //sw.WriteLine(textBox4.Text);
            //sw.Close();
        }
    }
}
