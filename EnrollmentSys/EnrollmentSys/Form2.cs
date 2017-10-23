using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace EnrollmentSys
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        public Form previousForm { get; set; }
        public string Username { get; set; }
        public string Usertype { get; set; }
        public string types { get; set; }
        public string typesfn { get; set; }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );
        public Form2()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 anotherform = new Form3();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 anotherform = new Form4();
            anotherform.previousForm = this;
            anotherform.Show();
            /*this.Hide();*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Login as: " + types + " " + typesfn;
            //MessageBox.Show(types);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 anotherform = new Form1();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 anotherform = new Form5();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            this.Show();

        }

        private void btnHome_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // if usertype == "Student" then go to Form 7
            //else
            Form9 anotherform = new Form9();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // if usertype == "Student" then go to Form 7
            //else
            Form6 anotherform = new Form6();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            Form12 anotherform = new Form12();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }
    }
}
