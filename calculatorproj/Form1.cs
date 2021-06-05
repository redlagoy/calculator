using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorproj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int outputOne, finalOutput, op;

        public void operation(int op)
        {
            try
            {
                switch (op)
                {
                    case 1:
                        textHistory.Text = textHistory.Text + textOutput.Text;
                        finalOutput = outputOne + int.Parse(textOutput.Text);
                        textOutput.Text = finalOutput.ToString();
                        break;
                    case 2:
                        finalOutput = outputOne - int.Parse(textOutput.Text);
                        textOutput.Text = finalOutput.ToString();
                        break;
                }
            }
            catch
            {
                this.textOutput.Text = "MATH ERROR";
                outputOne = 0;
                finalOutput = 0;
                op = 0;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOutput.Text + "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOutput.Text + "1";

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOutput.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOutput.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOutput.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOutput.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOutput.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOutput.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOutput.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textOutput.Text = textOutput.Text + "9";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                textOutput.Text = textOutput.Text.Remove(textOutput.Text.Length - 1);
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            textOutput.Text = String.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textOutput.Text = String.Empty;
            textHistory.Text = String.Empty;
            outputOne = 0;
            op = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textHistory.Text = textOutput.Text;
            outputOne = int.Parse(textOutput.Text);
            textHistory.Text = textHistory.Text + "+";
            textOutput.Clear();
            textOutput.Focus();
            op = 1;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (textOutput.Text != "")
            {
                textHistory.Text = textOutput.Text;
                outputOne = int.Parse(textOutput.Text);
                textHistory.Text = textHistory.Text + "-";
                textOutput.Clear();
                textOutput.Focus();
                op = 2;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operation(op);
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnSquare_Click(object sender, EventArgs e)
        {

        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {

        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {

        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {

        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {

        }
    }
}
