namespace EnrollmentSys
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.txtSubjID = new System.Windows.Forms.TextBox();
            this.txtSubjCode = new System.Windows.Forms.TextBox();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboGrade = new System.Windows.Forms.ComboBox();
            this.btnhome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubjID
            // 
            this.txtSubjID.Location = new System.Drawing.Point(59, 145);
            this.txtSubjID.Name = "txtSubjID";
            this.txtSubjID.Size = new System.Drawing.Size(269, 20);
            this.txtSubjID.TabIndex = 1;
            // 
            // txtSubjCode
            // 
            this.txtSubjCode.Location = new System.Drawing.Point(59, 208);
            this.txtSubjCode.Name = "txtSubjCode";
            this.txtSubjCode.Size = new System.Drawing.Size(269, 20);
            this.txtSubjCode.TabIndex = 2;
            // 
            // txtStudID
            // 
            this.txtStudID.Location = new System.Drawing.Point(59, 276);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(269, 20);
            this.txtStudID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update Grade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 421);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(155)))));
            this.label10.Location = new System.Drawing.Point(54, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "UPDATE STUDENT GRADES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Grade";
            // 
            // comboGrade
            // 
            this.comboGrade.FormattingEnabled = true;
            this.comboGrade.Items.AddRange(new object[] {
            "",
            "A",
            "B+",
            "B",
            "C+",
            "C",
            "D",
            "F"});
            this.comboGrade.Location = new System.Drawing.Point(59, 343);
            this.comboGrade.Name = "comboGrade";
            this.comboGrade.Size = new System.Drawing.Size(269, 21);
            this.comboGrade.TabIndex = 4;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Ivory;
            this.btnhome.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(788, 50);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnhome.Size = new System.Drawing.Size(135, 45);
            this.btnhome.TabIndex = 23;
            this.btnhome.Text = "        RETURN";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 602);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.comboGrade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.txtSubjCode);
            this.Controls.Add(this.txtSubjID);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubjID;
        private System.Windows.Forms.TextBox txtSubjCode;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboGrade;
        private System.Windows.Forms.Button btnhome;
    }
}