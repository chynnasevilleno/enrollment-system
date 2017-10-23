namespace EnrollmentSys
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnEnlistment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 193);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Ivory;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(909, 75);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(112, 47);
            this.button6.TabIndex = 4;
            this.button6.Text = "        LOGOUT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EnrollmentSys.Properties.Resources.AdDU_Insite_Seal_White_footer_20151;
            this.pictureBox2.Location = new System.Drawing.Point(93, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(382, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "My Grades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(758, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enlistment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(761, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Enroll yourself in a subject.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "View subject grades.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(90, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Logged in as: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.Transparent;
            this.btnGrades.Image = ((System.Drawing.Image)(resources.GetObject("btnGrades.Image")));
            this.btnGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrades.Location = new System.Drawing.Point(93, 346);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGrades.Size = new System.Drawing.Size(439, 167);
            this.btnGrades.TabIndex = 5;
            this.btnGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrades.UseVisualStyleBackColor = false;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnEnlistment
            // 
            this.btnEnlistment.BackColor = System.Drawing.Color.Transparent;
            this.btnEnlistment.Image = global::EnrollmentSys.Properties.Resources._004_student1;
            this.btnEnlistment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnlistment.Location = new System.Drawing.Point(582, 346);
            this.btnEnlistment.Name = "btnEnlistment";
            this.btnEnlistment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEnlistment.Size = new System.Drawing.Size(439, 167);
            this.btnEnlistment.TabIndex = 4;
            this.btnEnlistment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnlistment.UseVisualStyleBackColor = false;
            this.btnEnlistment.Click += new System.EventHandler(this.btnEnlistment_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 655);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnEnlistment);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnEnlistment;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}