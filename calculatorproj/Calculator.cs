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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public int op;
        public float outputOne, finalOutput;
        public double memoryOutput;
        public bool checker = false;
        
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
                        outputOne = finalOutput;
                        checker = false;
                        break;
                    case 2:
                        textHistory.Text = textHistory.Text + textOutput.Text;
                        finalOutput = outputOne - float.Parse(textOutput.Text);
                        textOutput.Text = finalOutput.ToString();
                        outputOne = finalOutput;
                        checker = false;
                        break;
                    case 3:
                        textHistory.Text = textHistory.Text + textOutput.Text;
                        finalOutput = outputOne * float.Parse(textOutput.Text);
                        textOutput.Text = finalOutput.ToString();
                        outputOne = finalOutput;
                        checker = false;
                        break;
                    case 4:
                        textHistory.Text = textHistory.Text + textOutput.Text;
                        finalOutput = outputOne / float.Parse(textOutput.Text);
                        textOutput.Text = finalOutput.ToString();
                        outputOne = finalOutput;
                        checker = false;
                        if (textOutput.Text == "∞")
                        {
                            textOutput.Text = "MATH ERROR";
                            outputOne = 0;
                            finalOutput = 0;
                            op = 0;
                        }
                        break;
                }
            }
            catch
            {
                if (textOutput.Text.Length > 0)
                {
                    textOutput.Text = "MATH ERROR";
                    outputOne = 0;
                    finalOutput = 0;
                    op = 0;
                    checker = false;
                }
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "0";
                checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "0";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "1";
                checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "2";
                checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "3";
                checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "4";
                checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "5";
                checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "6";
                checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "7";
                checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "8";
                checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "9";
                checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "9";
            }
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
            finalOutput = 0; 
            op = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                if (!string.IsNullOrEmpty(textHistory.Text))
                {
                    if (textHistory.Text.Contains("+") || textHistory.Text.Contains('-') || textHistory.Text.Contains('*') || textHistory.Text.Contains('/'))
                    {
                        op = 1;
                        operation(op);
                        textHistory.Text = textHistory.Text + "+";
                    }
                }                
                else
                {
                    textHistory.Text = textOutput.Text + "+";
                    outputOne = float.Parse(textOutput.Text);
                    textOutput.Clear();
                    textOutput.Focus();
                    op = 1;
                }   
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                if (!string.IsNullOrEmpty(textHistory.Text))
                {
                    if (textHistory.Text.Contains("+") || textHistory.Text.Contains('-') || textHistory.Text.Contains('*') || textHistory.Text.Contains('/'))
                    {
                        if (textOutput.Text != "")
                        {
                            op = 2;
                            operation(op);
                            textHistory.Text = textHistory.Text + "-";
                        }
                    }
                }
                else
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
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                if (!string.IsNullOrEmpty(textHistory.Text))
                {
                    if (textHistory.Text.Contains("+") || textHistory.Text.Contains('-') || textHistory.Text.Contains('*') || textHistory.Text.Contains('/'))
                    {
                        op = 3;
                        operation(op);
                        textHistory.Text = textHistory.Text + "*";
                    }
                }
                else
                {
                    textHistory.Text = textOutput.Text + "*";
                    outputOne = float.Parse(textOutput.Text);
                    textOutput.Clear();
                    textOutput.Focus();
                    op = 3;
                }
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                if (!string.IsNullOrEmpty(textHistory.Text))
                {
                    if (textHistory.Text.Contains("+") || textHistory.Text.Contains('-') || textHistory.Text.Contains('*') || textHistory.Text.Contains('/'))
                    {
                        op = 4;
                        operation(op);
                        textHistory.Text = textHistory.Text + "/";
                    }
                }
                else
                {
                    textHistory.Text = textOutput.Text + "/";
                    outputOne = float.Parse(textOutput.Text);
                    textOutput.Clear();
                    textOutput.Focus();
                    op = 4;
                }
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operation(op);
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                textHistory.Text = "1/" + textOutput.Text;
                float reciprocal = float.Parse(textOutput.Text);
                reciprocal = 1 / reciprocal;
                textOutput.Clear();
                textOutput.Text = reciprocal.ToString();
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                textHistory.Text = textOutput.Text + "%";
                float percent = float.Parse(textOutput.Text) / 100;
                textOutput.Clear();
                textOutput.Text = percent.ToString();
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                textHistory.Text = textOutput.Text + "^2";
                float square = float.Parse(textOutput.Text) * float.Parse(textOutput.Text);
                textOutput.Clear();
                textOutput.Text = square.ToString();
            }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                textHistory.Text = "√" + textOutput.Text;
                double squareRoot = double.Parse(textOutput.Text);
                squareRoot = Math.Sqrt(squareRoot);
                textOutput.Clear();
                textOutput.Text = squareRoot.ToString();
            }
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            if (textOutput.Text.Length > 0)
            {
                memoryOutput = double.Parse(textOutput.Text);
                btnMemoryClear.Enabled = true;
                btnMemoryRecall.Enabled = true;
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
            if (!textOutput.Text.Contains("."))
            {
                textOutput.Text += ".";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (!textOutput.Text.Contains("-"))
            {
                textOutput.Text = "-" + textOutput.Text;
            }
            else
            {
                textOutput.Text = textOutput.Text.Replace("-", "");
            }
        }
    }
}
