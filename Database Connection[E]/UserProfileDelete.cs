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
    public partial class UserProfileDelete : Form
    {
        public UserProfileDelete()
        {
            InitializeComponent();
        }

        private void UserProfileDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Users WHERE Id=" + Convert.ToInt32(idTextBox.Text);
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
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
                nameTextBox.Text = usernameTextBox.Text = passwordTextBox.Text = emailTextBox.Text = "";
                dateOfBirthDateTimePicker.Text = "";
                maleRadioButton.Checked = femaleRadioButton.Checked = false;
                bloodGroupComboBox.Text = "";
                MessageBox.Show("User does not exist.");
            }
            connection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "DELETE FROM Users WHERE Id="+Convert.ToInt32(idTextBox.Text);
            SqlCommand command = new SqlCommand(sql, connection);
            int  result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("User deleted");
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
