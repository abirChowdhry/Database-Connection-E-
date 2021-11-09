using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Connection_E_
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked)
            {
                submitButton.Enabled = true;
            }
            else
                submitButton.Enabled = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text=="")
            {
                MessageBox.Show("Name can not be empty");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm password can not be empty");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email can not be empty");
            }
            else if (dateOfBirthDateTimePicker.Text == "")
            {
                MessageBox.Show("Select a date");
            }
            else if (maleRadioButton.Checked==false && femaleRadioButton.Checked==false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Select a blood group");
            }
            else
            {
                if(passwordTextBox.Text!=confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else
                {
                    //Print print = new Print(this);
                    //print.Show();
                    //this.Hide();
                    //Database logic
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                    connection.Open();
                    string gender = "";
                    if(maleRadioButton.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    string sql = "INSERT INTO Users(Name,Username,Password,Email,DateOfBirth,Gender,BloodGroup) VALUES('"+nameTextBox.Text+"','"+usernameTextBox.Text+"','"+passwordTextBox.Text+"','"+emailTextBox.Text+"','"+dateOfBirthDateTimePicker.Text+"','"+gender+"','"+bloodGroupComboBox.Text+"')";
                    SqlCommand command = new SqlCommand(sql,connection);
                    int result=command.ExecuteNonQuery();
                    if(result>0)
                    {
                        MessageBox.Show("User added");
                        connection.Close();
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        connection.Close();
                    }

                }
            }
        }
    }
}
