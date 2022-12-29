using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using windows_programming_assignment;

namespace windows_tutorials
{
    public partial class Form4 : Form
    {

        int index = 0;

        //creating dataabase connectivity string and variables:
        string conString = "server=localhost;user=root;database=temp;port=3306;password=root";



        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {

                //creating databse connection and sqlcommand with resultSet object:
                string date = dates_combo.Text;
                string name = usernames_combo.Text;

                MySqlConnection con = new MySqlConnection(conString);              
                con.Open();
                string querry = $"select  user_details.details_id, users.username, user_details.steps,user_details.weight,user_details.height,user_details.age,user_details.burned_cal,user_details.usrename from users,user_details where users.username='{name}' and user_details.usrename='{date}' and users.user_role='user';";
                MySqlCommand cmnd = new MySqlCommand(querry,con);
                MySqlDataReader reader = cmnd.ExecuteReader();


                while (reader.Read()) {
                    //getting data from the database:
                    int detailsId = reader.GetInt32(0);  
                   
                    double steps = reader.GetDouble(2);
                    double weight = reader.GetDouble(3);
                    double height = reader.GetDouble(4);
                    double age = reader.GetDouble(5);
                    double burned_cal = reader.GetDouble(6);
                    string exercise_date = reader.GetString(7);

                

                    //getting serieses of chart and setting\adding data to it to draw it: 
                    this.chart1.Series["steps"].Points.AddXY(date, steps);
                    this.chart1.Series["weight"].Points.AddXY(date, weight);
                    this.chart1.Series["height"].Points.AddXY(date, height);
                    this.chart1.Series["age"].Points.AddXY(date, age);
                    this.chart1.Series["burned_calories"].Points.AddXY(date, burned_cal);


                }


                con.Close();


            } catch (Exception err) {

                MessageBox.Show($"Error:{err}");
            
            }



        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
               
                MySqlConnection con1 = new MySqlConnection(conString);             
                con1.Open();            
                string querry1 = $"SELECT user_details.details_id, users.username, user_details.steps,user_details.weight,user_details.height,user_details.age,user_details.burned_cal,user_details.usrename FROM user_details cross JOIN users ON user_details.details_id=users.user_id where users.user_role='user';";
                MySqlCommand cmnd1 = new MySqlCommand(querry1, con1);
                MySqlDataReader reader1 = cmnd1.ExecuteReader();


                //setting combobox data non-redunduncy version;):
                while (reader1.Read()) {
                    usernames_combo.Items.Add($"{reader1.GetString(1)}");
                    dates_combo.Items.Add($"{reader1.GetString(7)}");

                   

                }

                con1.Close();


                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string querry = $"select  user_details.details_id, users.username, user_details.steps,user_details.weight,user_details.height,user_details.age,user_details.burned_cal,user_details.usrename from users,user_details where users.user_role='user';";
                MySqlCommand cmnd = new MySqlCommand(querry, con);
                MySqlDataReader reader = cmnd.ExecuteReader();

                

                while (reader.Read()) {

                    int detail_id = reader.GetInt32(0);
                    string user = reader.GetString(1);
                    double steps = reader.GetDouble(2);
                    double wei = reader.GetDouble(3);
                    double hei = reader.GetDouble(4);
                    double age = reader.GetDouble(5);
                    double burnedCal = reader.GetDouble(6);
                    string date = reader.GetString(7);



                    //initializing row cells values:
                    DataGridViewRow row = (DataGridViewRow)userTable.Rows[index].Clone();
                    row.Cells[0].Value = detail_id;
                    row.Cells[1].Value = user;
                    row.Cells[2].Value = steps;
                    row.Cells[3].Value = wei;
                    row.Cells[4].Value = hei;
                    row.Cells[5].Value = age;
                    row.Cells[6].Value = burnedCal;
                    row.Cells[7].Value = date;

                    //adding this row into the table:
                    userTable.Rows.Add(row);            
                    

                }

             
                con.Close();
          

            }
            catch (Exception er)
            {
                MessageBox.Show($"Error:{er.ToString()}");
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            Form1 signIn = new Form1();
            this.Hide();
            signIn.Show();
        }
    }
}
