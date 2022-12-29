using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace windows_tutorials
{
    public partial class Form2 : Form
    {


        //creating dataabase connectivity string and variables:
        string conString = "server=localhost;user=root;database=temp;port=3306;password=root";
        string username="";
    

        public Form2(string user)
        {
            this.username = user;
            InitializeComponent();        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            welcome_label_txt.Text = $"Welcome {username};)";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

            try {
                string username = username_txt.Text; //modified to date
                double T = Double.Parse(steps_txt.Text);
                double W = Double.Parse(wei_txt.Text);
                double H = Double.Parse(hei_txt.Text);
                double A = Double.Parse(age_txt.Text);


                if (A <= 18 && A > 6 && H>80 && H<180 && W>25 && W<100 && T>0)
                {
                    //creating databse connection and sqlcommand with resultSet object:
                    //calculating the burned calories thruogh this equation:
                    double CB = (T * (0.4472 * H - 0.1263 * W + 0.074 * A - 20.4022) / 4.184) / 500;

                    MySqlConnection con = new MySqlConnection(conString);
                    con.Open();
                    string sql = $"insert into user_details(steps,weight,height,age,burned_cal,usrename) values({T},{W},{H},{A},{CB},'{username}');";
                    MySqlCommand cmnd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmnd.ExecuteReader();

                    MessageBox.Show($"you walked:{T}step,{W}KG,{H}meter,{A}year! and you burned :{CB.ToString("0.00")} calories ;)");





                    steps_txt.Text = "";
                    wei_txt.Text = "";
                    hei_txt.Text = "";
                    age_txt.Text = "";
                    username_txt.Text = "";


                    con.Close();
                }
                else {
                    MessageBox.Show("Enter Correct Information Please;)");
                }

             

            } catch (Exception er) {
                MessageBox.Show($"Error:{er}!");
            }
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
