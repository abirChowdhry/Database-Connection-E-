using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Connection_E_
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            this.Hide();
            userList.Show();
        }

        private void userProfileUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfileUpdate userProfileUpdate = new UserProfileUpdate();
            this.Hide();
            userProfileUpdate.Show();
        }

        private void userProfileDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfileDelete userProfileDelete = new UserProfileDelete();
            this.Hide();
            userProfileDelete.Show();
        }
    }
}
