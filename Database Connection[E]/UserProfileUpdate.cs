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
    public partial class UserProfileUpdate : Form
    {
        public UserProfileUpdate()
        {
            InitializeComponent();
        }

        private void UserProfileUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Users WHERE Id="+Convert.ToInt32(idTextBox.Text);
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                
                
                nameTextBox.Text = reader["Name"].ToString();
                usernameTextBox.Text = reader["Username"].ToString();
                passwordTextBox.Text = reader["Password"].ToString();
                emailTextBox.Text = reader["Email"].ToString();
                dateOfBirthDateTimePicker.Text = reader["DateOfBirth"].ToString();
                string gender = reader["Gender"].ToString();
                if (gender == "Male")
                {
                    maleRadioButton.Checked = true;
                }
                else
                {
                    femaleRadioButton.Checked = true;
                }
                bloodGroupComboBox.Text = reader["BloodGroup"].ToString();
            }
            else
            {
                nameTextBox.Text = usernameTextBox.Text = passwordTextBox.Text = confirmPasswordTextBox.Text = emailTextBox.Text = "";
                dateOfBirthDateTimePicker.Text = "";
                maleRadioButton.Checked = femaleRadioButton.Checked = false;
                bloodGroupComboBox.Text = "";
                MessageBox.Show("User does not exist.");
            }
            connection.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
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
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Select a blood group");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else
                {
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                    connection.Open();
                    string gender = "";
                    if (maleRadioButton.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    string sql = "UPDATE Users SET Name='"+nameTextBox.Text+ "',Username='" + usernameTextBox.Text + "',Password='" + passwordTextBox.Text + "',Email='" + emailTextBox.Text + "',DateOfBirth='" + dateOfBirthDateTimePicker.Text + "',Gender='" + gender + "',BloodGroup='" + bloodGroupComboBox.Text + "' WHERE Id=" + Convert.ToInt32(idTextBox.Text);
                    SqlCommand command = new SqlCommand(sql, connection);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("User updated");
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

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
