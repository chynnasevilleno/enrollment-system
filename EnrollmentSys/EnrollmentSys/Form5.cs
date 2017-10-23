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
    public partial class Form5 : Form
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

        public Form5()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        //public int selected_user;
        public int selected_subjects;
        private void Form5_Load(object sender, EventArgs e)
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

        public void loadAll()
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

        private void SubjNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSubj_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO subjects (subjCode, subjDesc, subjUnits) values('" + SubjNo.Text + "','" + DescTitle.Text + "','" + Units.Text + "');";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Subject successfully created.");
            loadAll();
            clearAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_subjects = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["sid"].Value.ToString());
                SubjNo.Text = dataGridView1.Rows[e.RowIndex].Cells["subjCode"].Value.ToString();
                DescTitle.Text = dataGridView1.Rows[e.RowIndex].Cells["subjDesc"].Value.ToString();
                Units.Text = dataGridView1.Rows[e.RowIndex].Cells["subjUnits"].Value.ToString();
            }
        }
        public void clearAll()
        {
            SubjNo.Clear();
            DescTitle.Clear();
            Units.Clear();
        }
        private void UpdateSubj_Click(object sender, EventArgs e)
        {
            string query = "UPDATE subjects SET subjCode = " +
                "'" + SubjNo.Text + "', subjDesc ='" + DescTitle.Text + "'" +
                ", subjUnits ='" + Units.Text + "' WHERE sid=" + selected_subjects;
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();

            loadAll();
            clearAll();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Form2 anotherform = new Form2();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }

        private void DelSubj_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SearchSubjects", conn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("_SearchSubjectVal", txtsearchsubj.Text);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;  //displays the query
            dataGridView1.Columns["sid"].Visible = false;
            dataGridView1.Columns["subjCode"].HeaderText = "Subject No.";
            dataGridView1.Columns["subjDesc"].HeaderText = "Descriptive Title";
            dataGridView1.Columns["subjUnits"].HeaderText = "Units";
            conn.Close();
        }
    }
}
