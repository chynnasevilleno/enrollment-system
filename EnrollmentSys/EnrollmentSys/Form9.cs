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
    public partial class Form9 : Form
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

        public Form9()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string query = "SELECT us.subjects_sid, s.subjCode, s.subjDesc, us.users_userid, u.firstname, u.lastname, us.grade FROM users u, subjects s, users_has_subjects us where u.userid = us.users_userid AND s.sid = us.subjects_sid;";
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
            dataGridView1.Columns["users_userid"].HeaderText = "Student ID";
            dataGridView1.Columns["firstname"].HeaderText = "Firstname";
            dataGridView1.Columns["lastname"].HeaderText = "Lastname";
            dataGridView1.Columns["grade"].HeaderText = "Grade";

        }
        public int subjectID;
        public int studentID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                subjectID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["subjects_sid"].Value.ToString());
                studentID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["users_userid"].Value.ToString());
                txtSubjID.Text = dataGridView1.Rows[e.RowIndex].Cells["subjects_sid"].Value.ToString();
                txtSubjCode.Text = dataGridView1.Rows[e.RowIndex].Cells["subjCode"].Value.ToString();
                txtStudID.Text = dataGridView1.Rows[e.RowIndex].Cells["users_userid"].Value.ToString();
                comboGrade.Text = dataGridView1.Rows[e.RowIndex].Cells["grade"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string query = "UPDATE users_has_subjects SET grade = '" + comboGrade.Text + "' WHERE subjects_sid = " + subjectID + " AND users_userid = " + studentID; 
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Grade successfully added.");
            clearAll();
            loadAll();
        }
        public void clearAll()
        {
            txtSubjID.Clear();
            txtSubjCode.Clear();
            txtStudID.Clear();
            comboGrade.ResetText();
        }
        public void loadAll()
        {
            string query = "SELECT us.subjects_sid, s.subjCode, s.subjDesc, us.users_userid, u.firstname, u.lastname, us.grade FROM users u, subjects s, users_has_subjects us where u.userid = us.users_userid AND s.sid = us.subjects_sid;";
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
            dataGridView1.Columns["users_userid"].HeaderText = "Student ID";
            dataGridView1.Columns["firstname"].HeaderText = "Firstname";
            dataGridView1.Columns["lastname"].HeaderText = "Lastname";
            dataGridView1.Columns["grade"].HeaderText = "Grade";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE users_has_subjects SET grade = '" + comboGrade.Text + "' WHERE subjects_sid = " + subjectID + " AND users_userid = " + studentID;
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Grade successfully updated.");
            clearAll();
            loadAll();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Form2 anotherform = new Form2();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
