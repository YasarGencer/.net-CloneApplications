using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ATM
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }
        private void SignInPage_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //checks
            if (usertext.Text.Contains(' ') ||
                passtext.Text.Contains(' ') ||
                nametext.Text.Contains(' ') ||
                surnametext.Text.Contains(' ')||
                mailtext.Text.Contains(' ')||
                locationtext.Text.Contains(' '))
            {
                errortext.Text = "Values can't contain space";
                return;
            }
            else if (usertext.Text.Length <= 0 ||
                usertext.Text.Length <= 0 ||
                passtext.Text.Length <= 0 ||
                nametext.Text.Length <= 0 ||
                surnametext.Text.Length <= 0 ||
                mailtext.Text.Length <= 0||
                locationtext.Text.Length <= 0)
            {
                errortext.Text = "Values can't be empty";
                return;
            }
            else if (passtext.Text != conpasstext.Text)
            {
                errortext.Text = "Passwords doesn't match";
                return;
            }
            else if (!mailtext.Text.Contains('@') ||
                    !mailtext.Text.Contains('.'))
            {
                errortext.Text = "Invalid mail adress";
                return;
            }

            //add user
            new Form1().NewUser(usertext.Text, passtext.Text,
                nametext.Text, surnametext.Text,
                mailtext.Text, locationtext.Text,
                contacttext.Text, comboBox1.Text);

            this.Hide();
            new Form1().Show();
        }
        private void contacttext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && 
                ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void SignInPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                passtext.PasswordChar = '*';
                conpasstext.PasswordChar = '*';
            }
            else
            {
                passtext.PasswordChar = '\0';
                conpasstext.PasswordChar = '\0';
            }
        }
    }
}
