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
    public partial class Bank : Form
    {
        List<User> userList = new List<User>();

        public int id;

        DataTable table;
        public Bank(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void BankUI_Load(object sender, EventArgs e)
        {

            //get all of members on a list
            StreamReader tr = new StreamReader(Form1.filePath);
            string line;
            while ((line = tr.ReadLine()) != null)
            {
                String[] strlist = line.Split(' ');
                User newUser = new User(strlist[0], strlist[1],
                    strlist[2], strlist[3], strlist[4],
                    strlist[5], strlist[6], strlist[7],
                    strlist[8]);
                userList.Add(newUser);
            }
            tr.Close();

            table = new DataTable();
            table.Columns.Add("Name", typeof(String));
            table.Columns.Add("Surname", typeof(String));
            table.Columns.Add("Cash", typeof(String));
            table.Columns.Add("Mail", typeof(String));
            table.Columns.Add("Contact", typeof(String));
            table.Columns.Add("Location", typeof(String));
            table.Columns.Add("Gender", typeof(String));
            usergrid.DataSource = table;
            usergrid.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;
            usergrid.Columns["Surname"].SortMode = DataGridViewColumnSortMode.NotSortable;
            usergrid.Columns["Cash"].SortMode = DataGridViewColumnSortMode.NotSortable;
            usergrid.Columns["Mail"].SortMode = DataGridViewColumnSortMode.NotSortable;
            usergrid.Columns["Contact"].SortMode = DataGridViewColumnSortMode.NotSortable;
            usergrid.Columns["Location"].SortMode = DataGridViewColumnSortMode.NotSortable;
            usergrid.Columns["Gender"].SortMode = DataGridViewColumnSortMode.NotSortable;
            
            usergrid.Columns["Cash"].Width = 75;
            usergrid.Columns["Mail"].Width = 150;
            usergrid.Columns["Contact"].Width = 85;
            usergrid.Columns["Location"].Width = 70;
            usergrid.Columns["Gender"].Width = 50;
            
            
            
            UpdateAllTable();
            //personal info
            lblNAME.Text = userList.ElementAt(id).name;
            lblSURNAME.Text = userList.ElementAt(id).surname;
            lblMAIL.Text = userList.ElementAt(id).mail;
            lblCONTACT.Text = userList.ElementAt(id).contact;
            lblLOCATION.Text = userList.ElementAt(id).location;
            lblGENDER.Text = userList.ElementAt(id).gender;
            txtMONEY.Text = userList.ElementAt(id).cash;
        }
        private void BankUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(Form1.filePath, String.Empty);
            foreach (var user in userList)
            {
                File.AppendAllText(Form1.filePath, user.user + ' ' + user.pass + ' ' +
                user.name + ' ' + user.surname + ' ' +
                user.mail + ' ' + user.contact + ' ' +
                user.location + ' ' + user.gender + " " + user.cash + " " +
                    Environment.NewLine);
            }
            Application.Exit();
        }
        private void bttSEND_Click(object sender, EventArgs e)
        {
            int index = -2;
            if (usergrid.RowCount >= 1)
                index = usergrid.CurrentCell.RowIndex;
            if(index != id)
            {
                int mCash = int.Parse(userList.ElementAt(id).cash);
                int oCash = int.Parse(userList.ElementAt(index).cash);
                int target = 0;
                if (txtCASH.Text != "")
                    target = int.Parse(txtCASH.Text);
                if (mCash > target)
                {
                    mCash -= target;
                    oCash += target;
                }
                String mCashT = mCash.ToString();
                String oCashT = oCash.ToString();
                userList.ElementAt(id).cash = mCashT;
                userList.ElementAt(index).cash = oCashT;
                txtMONEY.Text = userList.ElementAt(id).cash;
                UpdateAllTable();
            }
        }
        private void bttnGET_Click(object sender, EventArgs e)
        {
            int index = -2;
            if (usergrid.RowCount >= 1)
                index = usergrid.CurrentCell.RowIndex;
            if (index != id)
                if (txtPASS.Text != "")
                    if (txtPASS.Text == userList.ElementAt(index).pass)
                    {
                        int mCash = int.Parse(userList.ElementAt(id).cash);
                        int oCash = int.Parse(userList.ElementAt(index).cash);
                        int target = 0;
                        if (txtCASH.Text != "")
                            target = int.Parse(txtCASH.Text);
                        if (mCash > target)
                        {
                            mCash += target;
                            oCash -= target;
                        }
                        String mCashT = mCash.ToString();
                        String oCashT = oCash.ToString();
                        userList.ElementAt(id).cash = mCashT;
                        userList.ElementAt(index).cash = oCashT;
                        txtMONEY.Text = userList.ElementAt(id).cash;
                        UpdateAllTable();
                    }
        }
        private void bttnDEPOSIT_Click(object sender, EventArgs e)
        {
            int cash = int.Parse(userList.ElementAt(id).cash);
            int target = 0;
            if (textTARGETAMOUNT.Text != "")
                target = int.Parse(textTARGETAMOUNT.Text);
            cash += target;
            userList.ElementAt(id).cash = cash.ToString();
            txtMONEY.Text = userList.ElementAt(id).cash;
            UpdateAllTable();
        }
        private void bttnWITH_Click(object sender, EventArgs e)
        {
            int cash = int.Parse(userList.ElementAt(id).cash);
            int target = 0;
            if (textTARGETAMOUNT.Text != "")
                target = int.Parse(textTARGETAMOUNT.Text);
            if(cash-target >= 0)
                cash -= target;
            userList.ElementAt(id).cash = cash.ToString();
            txtMONEY.Text = userList.ElementAt(id).cash;
            UpdateAllTable();
        }
        private void usergrid_MouseClick(object sender, MouseEventArgs e)
        {
            int index = -2;
            if (usergrid.RowCount >= 1)
                index = usergrid.CurrentCell.RowIndex;
            if (index != id)
                txtTARGET.Text = userList.ElementAt(index).name + " " + 
                    userList.ElementAt(index).surname;
            else
                txtTARGET.Text = "Can't select yourself as a targer";
        }
        public void UpdateAllTable()
        {
            table.Rows.Clear();
            foreach (var user in userList)
            {
                table.Rows.Add(user.name, user.surname, 
                    user.cash, user.mail, user.contact, 
                    user.location, user.gender);
            }
        }
        private void txtCASH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') &&
                ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
        private void txtTARGET_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') &&
                ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
