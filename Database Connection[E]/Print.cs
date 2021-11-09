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
    public partial class Print : Form
    {
        Registration registration;
        public Print(Registration registration)
        {
            InitializeComponent();
            this.registration = registration;
            label1.Text += " : " + this.registration.NameTextBox;
            label2.Text += " : " + this.registration.usernameTextBox.Text;
            label3.Text += " : " + this.registration.passwordTextBox.Text;
            label5.Text += " : " + this.registration.emailTextBox.Text;
            label6.Text += " : " + this.registration.dateOfBirthDateTimePicker.Text;
            if(this.registration.maleRadioButton.Checked)
            {
                label7.Text += " : " + this.registration.MaleRadioButton.Text;
            }
            else
            {
                label7.Text += " : " + this.registration.femaleRadioButton.Text;
            }
            label8.Text += " : " + this.registration.bloodGroupComboBox.Text;
        }

        private void Print_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
