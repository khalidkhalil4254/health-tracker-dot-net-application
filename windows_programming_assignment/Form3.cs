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
    public partial class Form3 : Form
    {

        //creating dataabase connectivity string and variables:
        string conString = "server=localhost;user=root;database=temp;port=3306;password=root";


        public Form3()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 signInForm = new Form1();
            signInForm.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {


            try {

                string fname = fname_txt.Text;
                string lname = lname_txt.Text;
                string username = username_txt.Text;
                string password = password_txt.Text;
                string user_role = user_role_combobox.Text;


                if (fname != "" && lname != "" && username != "" && password != "" && user_role != null)
                {
                    if (user_role == "User" || user_role == "Doctor")
                    {

                        MessageBox.Show($"firstname:{fname}, lastname:{lname}, usernmae:{username},user_role:{user_role}");
                        //creating databse connection and sqlcommand with resultSet object:
                        //database connections and commands and conditions:
                        MySqlConnection con = new MySqlConnection(conString);
                        con.Open();
                        string sql = $"insert into users(username,password,fname,lname,user_role) values('{username}','{password}','{fname}','{lname}','{user_role}');";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //executing sql command:
                        while (reader.Read()) { }

                        con.Close();


                        //clearing data form:
                        fname_txt.Text = "";
                        lname_txt.Text = "";
                        username_txt.Text = "";
                        password_txt.Text = "";
                        user_role_combobox.Text = "";


                        Form1 signIn = new Form1();
                        this.Hide();
                        signIn.Show();


                    }

                    else
                    {

                        MessageBox.Show("You should select User Role:(User or Doctor)!!!");

                    }

                }
                else {
                    MessageBox.Show("Invlid entries!!!");
                }


            } catch (Exception er) {
               
                MessageBox.Show($"Already Registered User! Try again another information!", "Already Existed User!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
