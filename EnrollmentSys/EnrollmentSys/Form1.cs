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

namespace EnrollmentSys
{

    public partial class Form1 : Form
    {
        public MySqlConnection conn;
        public string types;
        public string typesfn;
        public string fn;
        public string ln;
        public static int currentid;
        public Form previousForm { get; set; }
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "../Assets/University-Seal-White.png";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usr = txtuser.Text;
            string psw = txtpass.Text;
            string query = "SELECT * FROM users WHERE username='" + usr + "'AND password='" + psw + "';";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                string fn = dt.Rows[0][1].ToString();
                string ln = dt.Rows[0][2].ToString();
                string utype = dt.Rows[0][8].ToString();
                int userid = int.Parse(dt.Rows[0][0].ToString());
                Class1.currentid = int.Parse(dt.Rows[0][0].ToString()); 

                MessageBox.Show("Welcome " + ln + ", " + fn + "!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (utype == "Admin") {
                    Form2 anotherform = new Form2();
                    anotherform.previousForm = this;
                    anotherform.types = dt.Rows[0][1].ToString();
                    anotherform.typesfn = dt.Rows[0][3].ToString();
                    anotherform.Show();
                    this.Hide();
                }
                if(utype=="Student")
                {
                    Form10 form = new Form10(userid);
                    form.previousForm = this;
                    form.Show();
                    form.fn = dt.Rows[0][1].ToString();
                    form.ln = dt.Rows[0][3].ToString();
                    this.Hide();
                }
            }
            else
            {
                if (usr == "")
                {
                    MessageBox.Show("Username is empty.");
                }
               else if (psw == "")
                {
                    MessageBox.Show("Password is empty.");
                }
                else if(psw=="" && usr == "") { MessageBox.Show("Enter your credentials."); }
                else { MessageBox.Show("Records not found."); }
                txtuser.Clear();
                txtpass.Clear();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
