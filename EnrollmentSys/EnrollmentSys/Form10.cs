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
    public partial class Form10 : Form
    {
        MySqlConnection conn;
        public Form previousForm { get; set; }
        public int userid;
        public string fn { get; set; }
        public string ln { get; set; }
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
        public Form10(int uid)
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            userid = uid;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            label9.Text = "Login as: " + fn + " " + ln;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            Form11 anotherform = new Form11(userid);
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 anotherform = new Form1();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }

        private void btnEnlistment_Click(object sender, EventArgs e)
        {
            Form7 anotherform = new Form7(userid);
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
