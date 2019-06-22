using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wizer_Password_Manager
{
    class class11
    {

        public void method1(DataGridView dataGridView1 ,PictureBox p)
        {
            dataGridView1.Visible = true;

            try
            {
                if (File.Exists(p.Name))
                {
                    string[] arr = File.ReadAllLines(p.Name);
                    dataGridView1.Rows.Clear();
                    for (int i = 1; i < arr.Length; i = i + 2)
                    {
                        dataGridView1.Rows.Add(arr[i - 1], arr[i]);
                    } 
                }
              
            }
            catch (Exception)
            {

                MessageBox.Show("File Has Been Deleted");
            }
             
        }

        public void showbutton(Button button1 , ComboBox combobox1)
        {
            button1.Show();
            combobox1.Show();
        }
        public void method3(ComboBox comboBox1, DataGridView dataGridView1, Button button1)
        {
            comboBox1.Hide();
            dataGridView1.Hide();
            button1.Hide();
            
            for (int i = 0; i < ForUser.retrivetextfiles.Length; i++)
            {
                comboBox1.Items.Add(ForUser.retrivetextfiles[i]);
            }
        }

        public void method4(ComboBox comboBox1)
        {
            File.Delete(comboBox1.Text);
            File.ReadAllLines(ForUser.currentuser+"webdata.txt");
            
            
        }


        public void method2(TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            string temp = ForUser.currentuser + textBox3.Text + ".txt";

            if (File.Exists(temp))
            {

                StreamWriter sw = new StreamWriter(temp, true);
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.Close();
            }

            else
            {

                ForUser.counterfortextfile++;
                StreamWriter sw = new StreamWriter(temp);
                StreamWriter sd = new StreamWriter(ForUser.currentuser + "datacounter.txt");
                StreamWriter ss = new StreamWriter(ForUser.currentuser + "webdata.txt", true);
                sd.WriteLine(ForUser.counterfortextfile);
                ss.WriteLine(temp);
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.Close();
                sd.Close();
                ss.Close();
            }
        }
    }
}
