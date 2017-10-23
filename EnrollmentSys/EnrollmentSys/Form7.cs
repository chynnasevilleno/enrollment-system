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
    public partial class Form7 : Form
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
        public static int userid;
        public Form7(int selected_user)
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=enrollmentdb;  uid=root; pwd=root");
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            userid = selected_user;
            
        }

        private void Form7_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (e.ColumnIndex != 0) e.Cancel = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int selected_subjects;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_subjects = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["sid"].Value.ToString());
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 anotherform = new Form2();
            anotherform.previousForm = this;
            anotherform.Show();
            this.Close();
        }
        public int subjid;
        private void btncourses_Click(object sender, EventArgs e)
        {
                string message = string.Empty;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Column1"].Value);
                    if (isSelected)
                    {
                        message += Environment.NewLine;
                        message += row.Cells["subjDesc"].Value.ToString();
                    }
                }

                DialogResult dialogResult = MessageBox.Show("The following subjects will be added: \r\n" +
            message, "Confirm enlistment", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["Column1"].Value);
                        if (isSelected)
                        {
                            int subjid = int.Parse(row.Cells["sid"].Value.ToString());

                            string query = "SELECT 1 FROM users_has_subjects WHERE subjects_sid = " + subjid + " AND users_userid = " + userid + ";";

                            conn.Open();
                            MySqlCommand comm = new MySqlCommand(query, conn);
                            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                            conn.Close();
                            DataTable dt = new DataTable();
                            adp.Fill(dt);

                            if (dt.Rows.Count == 1)
                            {
                                MessageBox.Show("Subject exists in your records. Reserving two classes are not allowed.");
                            }
                            else
                            {
                                query = "INSERT INTO `enrollmentdb`.`users_has_subjects` (`users_userid`, `subjects_sid`) values(" + userid + "," + subjid + ");";
                                conn.Open();
                                comm = new MySqlCommand(query, conn);
                                comm.ExecuteNonQuery();
                                conn.Close();
                                Form8 anotherform = new Form8(userid, subjid);
                                anotherform.previousForm = this;
                                anotherform.Show();
                                this.Close();
                            }
                        }
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            
        }
    }
}
