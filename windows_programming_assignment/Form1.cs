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

namespace windows_tutorials
{
    public partial class Form1 : Form
    {

        //creating dataabase connectivity string and variables:
        string conString = "server=localhost;user=root;database=temp;port=3306;password=root";
        string user_res;
        string pass_res;
        string user_role;

        public Form1()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {

            try {

                //creating databse connection and sqlcommand with resultSet object:
                MySqlConnection con = new MySqlConnection(conString);           

                string username = username_txt.Text;
                string password = password_txt.Text;

                con.Open();

                string cmnd = $"select username,password,user_role from users where username='{username}' and password='{password}';";
                MySqlCommand sql = new MySqlCommand(cmnd, con);
                MySqlDataReader reader = sql.ExecuteReader();


                while (reader.Read()) {

                    user_res = reader.GetString(0);
                    pass_res = reader.GetString(1);
                    user_role = reader.GetString(2);

                    if (username == user_res && password == pass_res)
                    {


                        if (user_role=="User") {
                            Form2 userHomeForm = new Form2(username);
                            this.Hide();
                            userHomeForm.Show();
                            break;
                        }
                        else if(user_role=="Doctor"){
                            Form4 doctorHomeForm = new Form4();
                       
                            this.Hide();
                            doctorHomeForm.Show();
                            break;
                        }

                      
                    }

                }

                if (username!=user_res || password!=pass_res) {
                    MessageBox.Show($"Invalid username:{username}\nOR\nInvalid password:{password}",
                    "Invalid Credentials!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();

            }
            catch (Exception er) {
                MessageBox.Show($"Error:{er.ToString()}");
            }
           
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            Form3 signUpForm = new Form3();
            signUpForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
