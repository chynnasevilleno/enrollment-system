namespace EnrollmentSys
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtconfpwd = new System.Windows.Forms.TextBox();
            this.comboutype = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.txtsearchusr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(484, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(466, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(686, 652);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 581);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Confirm Password:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 508);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 657);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "User Type:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "First name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Middle name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 359);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Gender:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 291);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Address:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(155)))));
            this.label10.Location = new System.Drawing.Point(50, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 28);
            this.label10.TabIndex = 13;
            this.label10.Text = "CREATE USER PROFILE";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(55, 118);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(325, 22);
            this.txtfname.TabIndex = 1;
            this.txtfname.TextChanged += new System.EventHandler(this.txtfname_TextChanged);
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(55, 183);
            this.txtmname.Margin = new System.Windows.Forms.Padding(4);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(327, 22);
            this.txtmname.TabIndex = 2;
            this.txtmname.TextChanged += new System.EventHandler(this.txtmname_TextChanged);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(52, 247);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(327, 22);
            this.txtlname.TabIndex = 3;
            this.txtlname.TextChanged += new System.EventHandler(this.txtlname_TextChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(52, 312);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(327, 22);
            this.txtaddress.TabIndex = 4;
            this.txtaddress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(50, 381);
            this.txtgender.Margin = new System.Windows.Forms.Padding(4);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(328, 22);
            this.txtgender.TabIndex = 5;
            this.txtgender.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(51, 454);
            this.txtuname.Margin = new System.Windows.Forms.Padding(4);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(328, 22);
            this.txtuname.TabIndex = 6;
            this.txtuname.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(50, 530);
            this.txtpwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(328, 22);
            this.txtpwd.TabIndex = 7;
            this.txtpwd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtconfpwd
            // 
            this.txtconfpwd.Location = new System.Drawing.Point(49, 604);
            this.txtconfpwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfpwd.Name = "txtconfpwd";
            this.txtconfpwd.PasswordChar = '*';
            this.txtconfpwd.Size = new System.Drawing.Size(328, 22);
            this.txtconfpwd.TabIndex = 8;
            this.txtconfpwd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // comboutype
            // 
            this.comboutype.Items.AddRange(new object[] {
            "",
            "Admin",
            "Student"});
            this.comboutype.Location = new System.Drawing.Point(133, 657);
            this.comboutype.Margin = new System.Windows.Forms.Padding(4);
            this.comboutype.MaxDropDownItems = 9;
            this.comboutype.Name = "comboutype";
            this.comboutype.Size = new System.Drawing.Size(244, 22);
            this.comboutype.TabIndex = 9;
            this.comboutype.SelectedIndexChanged += new System.EventHandler(this.comboutype_SelectedIndexChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(241, 718);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnupdate.Size = new System.Drawing.Size(139, 32);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "        Update Details";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(46, 718);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnsave.Size = new System.Drawing.Size(131, 32);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "      Create User";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Ivory;
            this.btnhome.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(1035, 35);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnhome.Size = new System.Drawing.Size(135, 45);
            this.btnhome.TabIndex = 22;
            this.btnhome.Text = "        RETURN";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // txtsearchusr
            // 
            this.txtsearchusr.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchusr.Location = new System.Drawing.Point(484, 53);
            this.txtsearchusr.Name = "txtsearchusr";
            this.txtsearchusr.Size = new System.Drawing.Size(268, 27);
            this.txtsearchusr.TabIndex = 23;
            this.txtsearchusr.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(758, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1213, 816);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsearchusr);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.comboutype);
            this.Controls.Add(this.txtconfpwd);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtconfpwd;
        private System.Windows.Forms.ComboBox comboutype;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.TextBox txtsearchusr;
        private System.Windows.Forms.Button button1;
    }
}