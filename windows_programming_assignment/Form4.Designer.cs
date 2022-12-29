
namespace windows_tutorials
{
    partial class Form4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.dates_combo = new System.Windows.Forms.ComboBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.signout_btn = new System.Windows.Forms.Button();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernames_combo = new System.Windows.Forms.ComboBox();
            this.detailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burned_cal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exercise_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(40, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "steps";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "weight";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "height";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "age";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "burned_calories";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1328, 391);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(836, 597);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(167, 58);
            this.refresh_btn.TabIndex = 1;
            this.refresh_btn.Text = "Find";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dates_combo
            // 
            this.dates_combo.AllowDrop = true;
            this.dates_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dates_combo.FormattingEnabled = true;
            this.dates_combo.ItemHeight = 16;
            this.dates_combo.Location = new System.Drawing.Point(492, 597);
            this.dates_combo.Name = "dates_combo";
            this.dates_combo.Size = new System.Drawing.Size(317, 24);
            this.dates_combo.TabIndex = 2;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(1214, 631);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(154, 48);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // signout_btn
            // 
            this.signout_btn.Location = new System.Drawing.Point(40, 631);
            this.signout_btn.Name = "signout_btn";
            this.signout_btn.Size = new System.Drawing.Size(154, 48);
            this.signout_btn.TabIndex = 4;
            this.signout_btn.Text = "SignOut";
            this.signout_btn.UseVisualStyleBackColor = true;
            this.signout_btn.Click += new System.EventHandler(this.signout_btn_Click);
            // 
            // userTable
            // 
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailsId,
            this.username,
            this.steps,
            this.weight,
            this.height,
            this.age,
            this.burned_cal,
            this.exercise_date});
            this.userTable.Location = new System.Drawing.Point(40, 409);
            this.userTable.Name = "userTable";
            this.userTable.RowHeadersWidth = 51;
            this.userTable.RowTemplate.Height = 24;
            this.userTable.Size = new System.Drawing.Size(1328, 154);
            this.userTable.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 631);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // usernames_combo
            // 
            this.usernames_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usernames_combo.FormattingEnabled = true;
            this.usernames_combo.Location = new System.Drawing.Point(492, 631);
            this.usernames_combo.Name = "usernames_combo";
            this.usernames_combo.Size = new System.Drawing.Size(317, 24);
            this.usernames_combo.TabIndex = 8;
            // 
            // detailsId
            // 
            this.detailsId.HeaderText = "detailsId";
            this.detailsId.MinimumWidth = 6;
            this.detailsId.Name = "detailsId";
            this.detailsId.Width = 125;
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 125;
            // 
            // steps
            // 
            this.steps.HeaderText = "steps";
            this.steps.MinimumWidth = 6;
            this.steps.Name = "steps";
            this.steps.Width = 125;
            // 
            // weight
            // 
            this.weight.HeaderText = "weight";
            this.weight.MinimumWidth = 6;
            this.weight.Name = "weight";
            this.weight.Width = 125;
            // 
            // height
            // 
            this.height.HeaderText = "height";
            this.height.MinimumWidth = 6;
            this.height.Name = "height";
            this.height.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.Width = 125;
            // 
            // burned_cal
            // 
            this.burned_cal.HeaderText = "burned_cal";
            this.burned_cal.MinimumWidth = 6;
            this.burned_cal.Name = "burned_cal";
            this.burned_cal.Width = 125;
            // 
            // exercise_date
            // 
            this.exercise_date.HeaderText = "exercise_date";
            this.exercise_date.MinimumWidth = 6;
            this.exercise_date.Name = "exercise_date";
            this.exercise_date.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 706);
            this.Controls.Add(this.usernames_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.signout_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.dates_combo);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "DoctorHome";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.ComboBox dates_combo;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button signout_btn;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox usernames_combo;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn steps;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn burned_cal;
        private System.Windows.Forms.DataGridViewTextBoxColumn exercise_date;
    }
}