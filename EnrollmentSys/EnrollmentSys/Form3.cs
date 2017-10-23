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
    public partial class Form3 : Form
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
          
        public Form3()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public int selected_user;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;  //displays the query
            dataGridView1.Columns["userid"].Visible = false;
            dataGridView1.Columns["firstname"].HeaderText = "Given name";
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["username"].Visible = false;
        }
        public void loadAll()
        {
            string query = "SELECT * FROM users";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;  //displays the query
            dataGridView1.Columns["userid"].Visible = false;
            dataGridView1.Columns["firstname"].HeaderText = "Given name";
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["username"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtfname.Text != "" || txtpwd.Text != "" || txtmname.Text != "" || txtlname.Text != "" ||  txtgender.Text != ""|| txtaddress.Text != "" || txtuname.Text != "" || txtconfpwd.Text != "")
            {
                if (txtpwd.Text != txtconfpwd.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                }
                else
                {
                    string query = "SELECT * FROM users WHERE username='" + txtuname.Text + "';";

                    conn.Open();
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    conn.Close();
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("User already exists.");
                    }
                    else
                    {
                        query = "INSERT INTO users (firstname, middlename, lastname, address, gender,username,password,usertype) values('" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txtaddress.Text + "','" + txtgender.Text + "','" + txtuname.Text + "','" + txtpwd.Text + "','" + comboutype.Text + "');";
                        conn.Open();
                        comm = new MySqlCommand(query, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        clearAll();
                        MessageBox.Show("User successfully added.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Incomplete details");
            }

            loadAll();
        }
        public void clearAll()
        {
            txtfname.Clear();
            txtmname.Clear();
            txtaddress.Clear();
            txtlname.Clear();
            txtgender.Clear();
            txtuname.Clear();
            txtpwd.Clear();
            txtconfpwd.Clear();
            txtfname.Clear();
            txtmname.Clear();
            txtaddress.Clear();
            comboutype.ResetText();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE users SET firstname = "+
                "'" + txtfname.Text + "', middlename ='" + txtmname.Text + "'"+
                ", lastname ='" + txtlname.Text + "', address ='" + txtaddress.Text + "'"
                +", gender ='" + txtgender.Text + "', username='" + txtuname.Text + "', password='" + txtpwd.Text + "'"+
                ", usertype='" + comboutype.Text + "' WHERE userid=" + selected_user;
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();

            loadAll();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboutype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_user = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["userid"].Value.ToString());
                txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                txtmname.Text = dataGridView1.Rows[e.RowIndex].Cells["middlename"].Value.ToString();
                txtlname.Text = dataGridView1.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
                txtgender.Text = dataGridView1.Rows[e.RowIndex].Cells["gender"].Value.ToString();
                txtuname.Text = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
                txtpwd.Text = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
                comboutype.Text = dataGridView1.Rows[e.RowIndex].Cells["usertype"].Value.ToString();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns["firstname"] + " like '%" + txtsearch.Text + "%'";
            dataGridView1.DataSource = bs;*/

            conn.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("SearchUsers",conn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("_UsrSearchVal", txtsearchusr.Text);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;  //displays the query
            dataGridView1.Columns["userid"].Visible = false;
            dataGridView1.Columns["firstname"].HeaderText = "Given name";
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["username"].Visible = false;
            conn.Close();

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
