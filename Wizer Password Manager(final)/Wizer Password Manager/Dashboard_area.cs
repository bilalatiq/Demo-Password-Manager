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
    public partial class Dashboard_area : Form
    {
        public Dashboard_area()
        {
            InitializeComponent();
      
        }

        int startx = 331;
        int starty = 21;
        PictureBox p;
        class11 cc = new class11();
        
        private void Dashboard_area_Load(object sender, EventArgs e)
        {
            

            string[] retrivedata = File.ReadAllLines(ForUser.currentuser + "webdata.txt");
            ForUser.retrivetextfiles = retrivedata;
            StreamReader sr = new StreamReader(ForUser.currentuser + "datacounter.txt");
            ForUser.counterfortextfile = int.Parse(sr.ReadLine());
            sr.Close();
            int y;
            cc.method3(comboBox1,dataGridView1,button1);
            for (int i = 0; i < ForUser.counterfortextfile; i++)
            {
                p = new PictureBox();
                Label l = new Label();
                string[] arr = File.ReadAllLines(ForUser.currentuser + "webdata.txt");
                
                p.Image = pictureBox10.Image;
                p.SizeMode = pictureBox10.SizeMode;
                p.Name = ForUser.retrivetextfiles[i];
                l.Text = ForUser.retrivetextfiles[i];
                
                p.Location = new Point(startx, starty);
                l.Size = new Size(50, 60);
                y = starty + 2;
                l.Location = new Point(startx,y);
                l.Show();
                flowLayoutPanel1.Controls.Add(l);
                l.Visible = true;
                l.ForeColor = Color.Black;
                
                p.Size = new Size(94, 90);
                p.BackColor = Color.Black;
                p.Visible = true;
                p.Show();
                flowLayoutPanel1.Controls.Add(p);
                p.DoubleClick += P_DoubleClick;
                startx += 162;
                
            }


       
        }

        private void P_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pp = sender as PictureBox;
            cc.method1(dataGridView1, pp); 
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            selected_area obj = new selected_area();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            selected_area obj = new selected_area();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

           

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            insert_area obj = new insert_area();
            this.Hide();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            cc.showbutton(button1, comboBox1);
            
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            //panel2.BackColor = Color.SteelBlue;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {

            //panel2.BackColor = Color.MidnightBlue;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
           // panel3.BackColor = Color.Firebrick;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            //panel3.BackColor = Color.MidnightBlue;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.DodgerBlue;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.MidnightBlue;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cc.method4(comboBox1);
            string a = File.ReadAllText(ForUser.currentuser + "datacounter.txt");
            int n = int.Parse(a);
            n--;
            StreamWriter sw = new StreamWriter(ForUser.currentuser + "datacounter.txt");
            sw.WriteLine(n.ToString());
            this.Dashboard_area_Load(this, null);
            sw.Close();
            DestroyHandle();
            Application.Restart();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Follow the paterns and do it accordingly");
        }

       
    }
}
