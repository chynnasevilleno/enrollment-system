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
    public partial class Form4 : Form
    {
        MySqlConnection conn;
        public Form previousForm { get; set; }
        public Form4()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                string query = "UPDATE users SET  password= '" + txtpass.Text + "' WHERE username='" + txtolduser.Text + "';";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            else if(txtoldpass.Text == "" && txtpass.Text == "")
            {
                string usr = txtuser.Text;
                string query = "SELECT * FROM users WHERE username='" + usr + "';";

                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt = new DataTable();
                adp.Fill(dt);
                
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Username is already taken.", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearAll();
                }
                else {
                    string udquery = "UPDATE users SET  username = '" + txtuser.Text + "' WHERE username='" + txtolduser.Text + "';";
                    conn.Open();
                    MySqlCommand comm1 = new MySqlCommand(udquery, conn);
                    comm1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update successful!", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);


                    previousForm.Show();
                    this.Close();

                }
            }
            else
            {
                string query = "UPDATE users SET  password= '" + txtpass.Text + "' WHERE username='" + txtolduser.Text + "' AND password='"+ txtoldpass.Text+"';";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update successful!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                previousForm.Show();
                this.Close();

            }

            clearAll();
        }
        public void clearAll() {
            txtoldpass.Clear();
            txtolduser.Clear();
            txtpass.Clear();
            txtuser.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtoldpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtolduser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
