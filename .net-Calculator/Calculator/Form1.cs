using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string currentNumber = "", oldnNumber = "", mark = "";
        float answer = 0;

        #region numeric buttons
        private void bttn0_Click(object sender, EventArgs e)
        {
            AddToNumber(0);
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            AddToNumber(1);
        }
        private void bttn2_Click(object sender, EventArgs e)
        {
            AddToNumber(2);
        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            AddToNumber(3);
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            AddToNumber(4);
        }

        private void bttn5_Click(object sender, EventArgs e)
        {
            AddToNumber(5);
        }

        private void bttn6_Click(object sender, EventArgs e)
        {
            AddToNumber(6);
        }

        private void bttn7_Click(object sender, EventArgs e)
        {
            AddToNumber(7);
        }

        private void bttn8_Click(object sender, EventArgs e)
        {
            AddToNumber(8);
        }

        private void bttn9_Click(object sender, EventArgs e)
        {
            AddToNumber(9);
        }

        void AddToNumber(int number)
        {
            currentNumber += number.ToString();
            WriteToText();
        }
        #endregion
        #region marks
        void SelectMark(string mark)
        {
            this.mark = mark;
            ConvertCurrentNumber();
            WriteToText();
        }
        private void bttnSums_Click(object sender, EventArgs e)
        {
            SelectMark("+");
        }

        private void bttnSubs_Click(object sender, EventArgs e)
        {
            SelectMark("-");
        }

        private void bttnMultiply_Click(object sender, EventArgs e)
        {
            SelectMark("*");
        }

        private void bttnDivide_Click(object sender, EventArgs e)
        {
            SelectMark("/");
        }
        #endregion
        private void bttnRemove_Click(object sender, EventArgs e)
        {
            if (currentNumber != "")
                currentNumber = currentNumber.Remove(currentNumber.Length - 1);
            else if (mark != "")
                mark = "";
            else if (oldnNumber != "")
                oldnNumber = oldnNumber.Remove(oldnNumber.Length - 1);
            WriteToText();
        }
        private void bttnEquals_Click(object sender, EventArgs e)
        {
            if(oldnNumber != "" && currentNumber != "")
            {
                switch (mark)
                {
                    case "+":
                        answer = int.Parse(oldnNumber) + int.Parse(currentNumber);
                        break;
                    case "-":
                        answer = (float)int.Parse(oldnNumber) - (float)int.Parse(currentNumber);
                        break;
                    case "*":
                        answer = int.Parse(oldnNumber) * int.Parse(currentNumber);
                        break;
                    case "/":
                        answer = int.Parse(oldnNumber) / int.Parse(currentNumber);
                        break;
                }
                oldnNumber = answer.ToString();
                currentNumber = "";
                mark = "";
                WriteToText();
                if (answer == 31)
                    MessageBox.Show("Haha");
            }
        }
        void ConvertCurrentNumber()
        {
            if (oldnNumber == "")
            {
                oldnNumber = currentNumber;
                currentNumber = "";
            }
        }   
        void WriteToText()
        {
            txtSolution.Text = oldnNumber + mark + currentNumber;
        }
    }
}
