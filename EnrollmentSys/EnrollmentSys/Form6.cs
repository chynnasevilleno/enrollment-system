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
    public partial class Form6 : Form
    {
        MySqlConnection conn;
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
        public Form6()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE usertype='Student'";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;  //displays the query
            dataGridView1.Columns["userid"].Visible = true;
            dataGridView1.Columns["firstname"].HeaderText = "First name";
            dataGridView1.Columns["middlename"].HeaderText = "Middle name";
            dataGridView1.Columns["lastname"].HeaderText = "Last name";
            dataGridView1.Columns["gender"].HeaderText = "Gender";
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["address"].Visible = false;
            dataGridView1.Columns["username"].Visible = false;
            dataGridView1.Columns["usertype"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int userid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }*/
            if (e.RowIndex > -1)
            {
                userid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["userid"].Value.ToString());
                //MessageBox.Show(userid.ToString());
            }
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            Form7 anotherform = new Form7(userid);
            anotherform.previousForm = this;
            anotherform.Show();
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            Form2 anotherform = new Form2();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 anotherform = new Form7(userid);
            anotherform.previousForm = this;
            anotherform.Show();
        }
    }
}
