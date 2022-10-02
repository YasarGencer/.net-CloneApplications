using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_NoteApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Massage", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Massage"].Visible = false;
            dataGridView1.Columns["Title"].Width = 237;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
            textMassage.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textTitle.Text != "" && textMassage.Text!= "")
            table.Rows.Add(textTitle.Text, textMassage.Text);

            textTitle.Clear();
            textMassage.Clear();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            int index = -2;
            if(dataGridView1.RowCount >= 1)
                index = dataGridView1.CurrentCell.RowIndex;

            if(index > -1)
            {
                textTitle.Text = table.Rows[index].ItemArray[0].ToString();
                textMassage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = -2;
            if (dataGridView1.RowCount >= 1)
                index = dataGridView1.CurrentCell.RowIndex;
            if(index != -2)
            table.Rows[index].Delete();
        }
    }
}
