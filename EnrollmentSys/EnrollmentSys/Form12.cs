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
    public partial class Form12 : Form
    {
        public MySqlConnection conn;
        public Form previousForm { get; set; }

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
        public Form12()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int selected_subjects;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_subjects = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["sid"].Value.ToString());
                string query = "SELECT u.userid, u.firstname, u.lastname "+
                    "FROM users_has_subjects us, users u, subjects s WHERE u.userid = us.users_userid " +
                    "AND us.subjects_sid = "+selected_subjects+ " AND s.sid = us.subjects_sid;";

                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dataGridView2.DataSource = dt;  //displays the query
                dataGridView2.Columns["userid"].Visible = false;
                dataGridView2.Columns["firstname"].HeaderText = "Given name";

            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            loadSubjects();
            loadStudents();
        }
        public void loadSubjects()
        {
            string query = "SELECT * FROM subjects";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;  //displays the query
            dataGridView1.Columns["sid"].Visible = false;
            dataGridView1.Columns["subjCode"].HeaderText = "Subject No.";
            dataGridView1.Columns["subjDesc"].HeaderText = "Descriptive Title";
            dataGridView1.Columns["subjUnits"].HeaderText = "Units";
        }
        public void loadStudents()
        {
            string query = "SELECT * FROM users WHERE usertype='Student'";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView2.DataSource = dt;  //displays the query
            dataGridView2.Columns["userid"].Visible = false;
            dataGridView2.Columns["firstname"].HeaderText = "Given name";
            dataGridView2.Columns["password"].Visible = false;
            dataGridView2.Columns["username"].Visible = false;
        }
        public int selected_user;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_user = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["userid"].Value.ToString());
                string query = "SELECT s.subjCode, s. subjDesc, s.subjUnits " +
                    "FROM users_has_subjects us, users u, subjects s WHERE u.userid = us.users_userid " +
                    "AND us.users_userid = " + selected_user + " AND s.sid = us.subjects_sid;";


                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadSubjects();
            loadStudents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 anotherform = new Form2();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }
    }
}
