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
            switch (op)
            {
                case 1:
                    finalOutput = outputOne + int.Parse(textOutput.Text);
                    textOutput.Text = finalOutput.ToString();
                    break;

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

        private void btnSign_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textOutput.Text = String.Empty;
        }

        private void textOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            outputOne = int.Parse(textOutput.Text);
            textOutput.Clear();
            textOutput.Focus();
            op = 1;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operation(op);
        }

    }
}
