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

        public int op;
        public float outputOne, finalOutput;
        public double memoryOutput;

        public void operation(int op)
        {
            try
            {
                switch (op)
                {
                    case 1:
                        textHistory.Text = textHistory.Text + textOutput.Text;
                        finalOutput = outputOne + float.Parse(textOutput.Text);
                        textOutput.Text = finalOutput.ToString();
                        break;
                    case 2:
                        textHistory.Text = textHistory.Text + textOutput.Text;
                        finalOutput = outputOne - float.Parse(textOutput.Text);
                        textOutput.Text = finalOutput.ToString();
                        break;
                    case 3:
                        textHistory.Text = textHistory.Text + textOutput.Text;
                        finalOutput = outputOne * float.Parse(textOutput.Text);
                        textOutput.Text = finalOutput.ToString();
                        break;
                    case 4:
                        textHistory.Text = textHistory.Text + textOutput.Text;
                        finalOutput = outputOne / float.Parse(textOutput.Text);
                        textOutput.Text = finalOutput.ToString();
                        break;
                    default:
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
            textHistory.Text = String.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textOutput.Text = String.Empty;
            textHistory.Text = String.Empty;
            outputOne = 0;
            finalOutput = 0; 
            op = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                textHistory.Text = textOutput.Text + "+";
                outputOne = float.Parse(textOutput.Text);
                textOutput.Clear();
                textOutput.Focus();
                op = 1;
            }
            catch
            {
                textOutput.Clear();
                textHistory.Clear();
                op = 0;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (textOutput.Text != "")
                {
                    textHistory.Text = textOutput.Text + "-";
                    outputOne = float.Parse(textOutput.Text);
                    textOutput.Clear();
                    textOutput.Focus();
                    op = 2;
                }
            }
            catch
            {
                textOutput.Clear();
                textHistory.Clear();
                op = 0;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                textHistory.Text = textOutput.Text + "*";
                outputOne = float.Parse(textOutput.Text);
                textOutput.Clear();
                textOutput.Focus();
                op = 3;
            }
            catch
            {
                textOutput.Clear();
                textHistory.Clear();
                op = 0;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                textHistory.Text = textOutput.Text + "/";
                outputOne = float.Parse(textOutput.Text);
                textOutput.Clear();
                textOutput.Focus();
                op = 4;
            }
            catch
            {
                textOutput.Clear();
                textHistory.Clear();
                op = 0;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operation(op);
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            try
            {
                textHistory.Text = "1/" + textOutput.Text;
                float reciprocal = float.Parse(textOutput.Text);
                reciprocal = 1 / reciprocal;
                textOutput.Clear();
                textOutput.Text = reciprocal.ToString();
            }
            catch
            {
                textOutput.Clear();
                textHistory.Clear();
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            try
            {
                textHistory.Text = textOutput.Text + "%";
                float percent = float.Parse(textOutput.Text) / 100;
                textOutput.Clear();
                textOutput.Text = percent.ToString();
            }
            catch
            {
                textOutput.Clear();
                textHistory.Clear();
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            try
            {
                textHistory.Text = textOutput.Text + "^2";
                float square = float.Parse(textOutput.Text) * float.Parse(textOutput.Text);
                textOutput.Clear();
                textOutput.Text = square.ToString();
            }
            catch
            {
                textOutput.Clear();
                textHistory.Clear();
            }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                textHistory.Text = "√" + textOutput.Text;
                double squareRoot = double.Parse(textOutput.Text);
                squareRoot = Math.Sqrt(squareRoot);
                textOutput.Clear();
                textOutput.Text = squareRoot.ToString();
            }
            catch
            {
                textOutput.Clear();
                textHistory.Clear();
            }
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            try
            {
                memoryOutput = double.Parse(textOutput.Text);
                btnMemoryClear.Enabled = true;
                btnMemoryRecall.Enabled = true;
            }
            catch
            {
                textOutput.Clear();
                textHistory.Clear();
            }
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            textOutput.Text = memoryOutput.ToString();
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            memoryOutput = 0;
            btnMemoryClear.Enabled = false;
            btnMemoryRecall.Enabled = false;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            int textLength = textOutput.TextLength;
            bool dec = false;
            string currentOutput = textOutput.Text;
            for (int i = 0; i < textLength; i++)
            {
                if (currentOutput[i].ToString() == ".")
                {
                    dec = true;
                    break;
                }
                else
                {
                    dec = false;
                }
            }
            if (dec == false)
            {
                textOutput.Text = textOutput.Text + ".";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {

        }
    }
}
