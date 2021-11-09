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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(sql,connection);
            SqlDataReader reader= command.ExecuteReader();
            List<User> users = new List<User>();
            while(reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.Email = reader["Email"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.Gender= reader["Gender"].ToString();
                user.BloodGroup = reader["BloodGroup"].ToString();
                users.Add(user);
            }

            userListDataGridView.DataSource = users;
            connection.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void userListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
