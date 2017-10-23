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
    public partial class Form11 : Form
    {
        MySqlConnection conn;
        public Form previousForm { get; set; }
        public int userid;

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

        public Form11(int uid)
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            userid = uid;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            string query = "SELECT us.subjects_sid, s.subjCode, s.subjDesc, us.grade" +
                " FROM users u, subjects s, users_has_subjects us" +
                " where u.userid = us.users_userid AND s.sid = us.subjects_sid AND userid = " + userid + "; ";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;  //displays the query
            dataGridView1.Columns["subjects_sid"].HeaderText = "Subject ID";
            dataGridView1.Columns["subjCode"].HeaderText = "Subject Code";
            dataGridView1.Columns["subjDesc"].HeaderText = "Descriptive Title";
            dataGridView1.Columns["grade"].HeaderText = "Grade";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 anotherform = new Form10(userid);
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Form10 anotherform = new Form10(userid);
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }
    }
}
