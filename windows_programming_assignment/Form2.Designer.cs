
namespace windows_tutorials
{
    partial class Form2
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
            this.steps_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wei_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hei_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.DateTimePicker();
            this.welcome_label_txt = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.signout_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // steps_txt
            // 
            this.steps_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steps_txt.Location = new System.Drawing.Point(172, 162);
            this.steps_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.steps_txt.Name = "steps_txt";
            this.steps_txt.Size = new System.Drawing.Size(316, 27);
            this.steps_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(47, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. steps:";
            // 
            // wei_txt
            // 
            this.wei_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wei_txt.Location = new System.Drawing.Point(172, 198);
            this.wei_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wei_txt.Name = "wei_txt";
            this.wei_txt.Size = new System.Drawing.Size(316, 27);
            this.wei_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(47, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(47, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Height:";
            // 
            // hei_txt
            // 
            this.hei_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hei_txt.Location = new System.Drawing.Point(172, 234);
            this.hei_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hei_txt.Name = "hei_txt";
            this.hei_txt.Size = new System.Drawing.Size(316, 27);
            this.hei_txt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(500, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "KG";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(500, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "CM";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // age_txt
            // 
            this.age_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_txt.Location = new System.Drawing.Point(172, 270);
            this.age_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(316, 27);
            this.age_txt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(47, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(500, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Year";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(47, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date:";
            // 
            // username_txt
            // 
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(172, 126);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(316, 27);
            this.username_txt.TabIndex = 0;
            // 
            // welcome_label_txt
            // 
            this.welcome_label_txt.AutoSize = true;
            this.welcome_label_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label_txt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.welcome_label_txt.Location = new System.Drawing.Point(43, 35);
            this.welcome_label_txt.Name = "welcome_label_txt";
            this.welcome_label_txt.Size = new System.Drawing.Size(391, 46);
            this.welcome_label_txt.TabIndex = 22;
            this.welcome_label_txt.Text = "Welcome username";
            // 
            // exit_btn
            // 
            this.exit_btn.BackgroundImage = global::windows_programming_assignment.Properties.Resources.logout;
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_btn.Location = new System.Drawing.Point(424, 354);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(113, 97);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::windows_programming_assignment.Properties.Resources.motivate;
            this.pictureBox2.Location = new System.Drawing.Point(632, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(453, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // signout_btn
            // 
            this.signout_btn.BackgroundImage = global::windows_programming_assignment.Properties.Resources.previous;
            this.signout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signout_btn.Location = new System.Drawing.Point(51, 354);
            this.signout_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signout_btn.Name = "signout_btn";
            this.signout_btn.Size = new System.Drawing.Size(113, 97);
            this.signout_btn.TabIndex = 6;
            this.signout_btn.UseVisualStyleBackColor = true;
            this.signout_btn.Click += new System.EventHandler(this.signout_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.BackgroundImage = global::windows_programming_assignment.Properties.Resources.submit;
            this.submit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submit_btn.Location = new System.Drawing.Point(237, 354);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(114, 97);
            this.submit_btn.TabIndex = 5;
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::windows_programming_assignment.Properties.Resources.userHomePage;
            this.pictureBox1.Location = new System.Drawing.Point(632, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 555);
            this.Controls.Add(this.welcome_label_txt);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hei_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wei_txt);
            this.Controls.Add(this.signout_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.steps_txt);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox steps_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button signout_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox wei_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hei_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker username_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label welcome_label_txt;
    }
}