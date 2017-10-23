namespace EnrollmentSys
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjNo = new System.Windows.Forms.TextBox();
            this.DescTitle = new System.Windows.Forms.TextBox();
            this.Units = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsearchsubj = new System.Windows.Forms.TextBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.UpdateSubj = new System.Windows.Forms.Button();
            this.AddSubj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descriptive Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Units:";
            // 
            // SubjNo
            // 
            this.SubjNo.Location = new System.Drawing.Point(39, 132);
            this.SubjNo.Margin = new System.Windows.Forms.Padding(2);
            this.SubjNo.Name = "SubjNo";
            this.SubjNo.Size = new System.Drawing.Size(274, 20);
            this.SubjNo.TabIndex = 1;
            this.SubjNo.TextChanged += new System.EventHandler(this.SubjNo_TextChanged);
            // 
            // DescTitle
            // 
            this.DescTitle.Location = new System.Drawing.Point(39, 189);
            this.DescTitle.Margin = new System.Windows.Forms.Padding(2);
            this.DescTitle.Name = "DescTitle";
            this.DescTitle.Size = new System.Drawing.Size(274, 20);
            this.DescTitle.TabIndex = 2;
            // 
            // Units
            // 
            this.Units.Location = new System.Drawing.Point(39, 246);
            this.Units.Margin = new System.Windows.Forms.Padding(2);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(71, 20);
            this.Units.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(455, 333);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(155)))));
            this.label10.Location = new System.Drawing.Point(34, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "CREATE SUBJECT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(545, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsearchsubj
            // 
            this.txtsearchsubj.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchsubj.Location = new System.Drawing.Point(397, 61);
            this.txtsearchsubj.Name = "txtsearchsubj";
            this.txtsearchsubj.Size = new System.Drawing.Size(142, 27);
            this.txtsearchsubj.TabIndex = 6;
            this.txtsearchsubj.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Ivory;
            this.btnhome.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(717, 44);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnhome.Size = new System.Drawing.Size(135, 45);
            this.btnhome.TabIndex = 23;
            this.btnhome.Text = "        RETURN";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // UpdateSubj
            // 
            this.UpdateSubj.Image = ((System.Drawing.Image)(resources.GetObject("UpdateSubj.Image")));
            this.UpdateSubj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateSubj.Location = new System.Drawing.Point(189, 308);
            this.UpdateSubj.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateSubj.Name = "UpdateSubj";
            this.UpdateSubj.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UpdateSubj.Size = new System.Drawing.Size(124, 30);
            this.UpdateSubj.TabIndex = 5;
            this.UpdateSubj.Text = "      Update Subject";
            this.UpdateSubj.UseVisualStyleBackColor = true;
            this.UpdateSubj.Click += new System.EventHandler(this.UpdateSubj_Click);
            // 
            // AddSubj
            // 
            this.AddSubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubj.Image = ((System.Drawing.Image)(resources.GetObject("AddSubj.Image")));
            this.AddSubj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddSubj.Location = new System.Drawing.Point(39, 308);
            this.AddSubj.Margin = new System.Windows.Forms.Padding(2);
            this.AddSubj.Name = "AddSubj";
            this.AddSubj.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddSubj.Size = new System.Drawing.Size(127, 30);
            this.AddSubj.TabIndex = 4;
            this.AddSubj.Text = "      Create Subject";
            this.AddSubj.UseVisualStyleBackColor = true;
            this.AddSubj.Click += new System.EventHandler(this.AddSubj_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsearchsubj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.DescTitle);
            this.Controls.Add(this.SubjNo);
            this.Controls.Add(this.UpdateSubj);
            this.Controls.Add(this.AddSubj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddSubj;
        private System.Windows.Forms.Button UpdateSubj;
        private System.Windows.Forms.TextBox SubjNo;
        private System.Windows.Forms.TextBox DescTitle;
        private System.Windows.Forms.TextBox Units;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsearchsubj;
    }
}