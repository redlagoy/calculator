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

        classOperation calculation = new classOperation();

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (calculation.checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "0";
                calculation.checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "0";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (calculation.checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "1";
                calculation.checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (calculation.checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "2";
                calculation.checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (calculation.checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "3";
                calculation.checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (calculation.checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "4";
                calculation.checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (calculation.checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "5";
                calculation.checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (calculation.checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "6";
                calculation.checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (calculation.checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "7";
                calculation.checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (calculation.checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "8";
                calculation.checker = true;
            }
            else
            {
                textOutput.Text = textOutput.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (calculation.checker == false)
            {
                textOutput.Clear();
                textOutput.Text = textOutput.Text + "9";
                calculation.checker = true;
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
            calculation.outputOne = 0;
            calculation.finalOutput = 0;
            calculation.op = 0;
            calculation.checker = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculation.outputText = textOutput.Text;
            calculation.historyText = textHistory.Text;
            calculation.Addition();
            textHistory.Text = calculation.historyText;
            textOutput.Text = calculation.outputText;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            calculation.outputText = textOutput.Text;
            calculation.historyText = textHistory.Text;
            calculation.Subraction();
            textHistory.Text = calculation.historyText;
            textOutput.Text = calculation.outputText;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calculation.outputText = textOutput.Text;
            calculation.historyText = textHistory.Text;
            calculation.Multiplication();
            textHistory.Text = calculation.historyText;
            textOutput.Text = calculation.outputText;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculation.outputText = textOutput.Text;
            calculation.historyText = textHistory.Text;
            calculation.Division();
            textHistory.Text = calculation.historyText;
            textOutput.Text = calculation.outputText;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            calculation.outputText = textOutput.Text;
            calculation.operation(calculation.op);
            textHistory.Text = calculation.historyText;
            textOutput.Text = calculation.outputText;

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
                calculation.memoryOutput = double.Parse(textOutput.Text);
                btnMemoryClear.Enabled = true;
                btnMemoryRecall.Enabled = true;
            }
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            textOutput.Text = calculation.memoryOutput.ToString();
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            calculation.memoryOutput = 0;
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
