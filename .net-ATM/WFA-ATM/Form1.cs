using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<User> userList = new List<User>();
        public const string filePath = "../../user.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader tr = new StreamReader(filePath);
            string line;
            while ((line = tr.ReadLine()) != null)
                if (line.Split(' ').Length >= 2)
                    RestoreUser(line.Split(' ')[0], line.Split(' ')[1]);
            tr.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SearchUser(textBox1.Text, textBox2.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignInPage().Show();
        }
        public void RestoreUser(String user, String pass)
        {
            User newUser = new User(user, pass);
            userList.Add(newUser);
            textBox3.Text = "Users are restored";
        }
        public bool SearchUser(String user, String pass)
        {
            bool ret = false; int count = 0;
            //search if list exists
            if (userList.Count > 0)
                foreach (var userlist in userList)
                {
                    if (userlist.user == user)
                    {
                        ret = true;
                        if (userlist.pass == pass)
                        {
                            textBox3.Text = "Login complete";
                            Bank bank = new Bank(count);
                            bank.Show();
                            this.Hide();
                            break;
                        }
                    }
                    count++;
                }
            //fail outputs
            if (userList.Count <= 0)
                textBox3.Text = "No users are registered";
            else
                textBox3.Text = "Invalid username or password";
            //complete search
            return ret;
        }
        public void NewUser(String user, String pass, string name, string surname, 
            string mail, string contact, string location, String gender)
        {
            //check existing users
            if (SearchUser(user, pass))
            {
                textBox3.Text = "Username is taken";
                return;
            }
            //check spacing
            if (pass.Contains(' ') || user.Contains(' '))
            {
                textBox3.Text = "Values can't contain spacing";
                return;
            }
            //add new user
            File.AppendAllText(filePath, user + ' ' + pass + ' ' +
                name + ' ' + surname + ' ' +
                mail + ' ' + contact + ' ' +
                location + ' ' + gender + " 0 " +
                    Environment.NewLine);
            textBox3.Text = "User sucseffuly added";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                textBox2.PasswordChar = '*';
            else
                textBox2.PasswordChar = '\0';
        }
    }
}
