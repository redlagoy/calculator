using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorproj
{
    class classOperation
    {
        //initializing the different variables that will be called from the calculator
        public string outputText, historyText;
        public int op;
        public float outputOne, finalOutput;
        public double memoryOutput;
        public bool checker = false;

        public void operation(int op)
        {
            try //try for identifying whether the calculation can be solved
            {
                switch (op) //using switch to know what operation will be used
                {
                    case 1:
                        historyText = historyText + outputText;
                        finalOutput = outputOne + float.Parse(outputText);
                        outputText = finalOutput.ToString();
                        outputOne = finalOutput;
                        checker = false;
                        break;
                    case 2:
                        historyText = historyText + outputText;
                        finalOutput = outputOne - float.Parse(outputText);
                        outputText = finalOutput.ToString();
                        outputOne = finalOutput;
                        checker = false;
                        break;
                    case 3:
                        historyText = historyText + outputText;
                        finalOutput = outputOne * float.Parse(outputText);
                        outputText = finalOutput.ToString();
                        outputOne = finalOutput;
                        checker = false;
                        break;
                    case 4:
                        historyText = historyText + outputText;
                        finalOutput = outputOne / float.Parse(outputText);
                        outputText = finalOutput.ToString();
                        outputOne = finalOutput;
                        checker = false;
                        if (outputText == "∞" || outputText == "-∞") //checks for infinity so that it will output "Math Error"
                        {
                            outputText = "MATH ERROR";
                            outputOne = 0;
                            finalOutput = 0;
                            op = 0;
                        }
                        break;
                }
            }
            catch //catches if the calculation cannot be solved
            {
                if (outputText.Length > 0)
                {
                    outputText = "MATH ERROR";
                    outputOne = 0;
                    finalOutput = 0;
                    op = 0;
                    checker = false;
                }
            }
        }

        public void Addition()
        {
            if (outputText.Length > 0) //checks whether you have already inputted a number 
            {
                if (!string.IsNullOrEmpty(historyText)) //checks the history textbox if there is already a previous input
                {
                    if (historyText.Contains("+") || historyText.Contains('-') || historyText.Contains('*') || historyText.Contains('/')) //checks if the history textbox contain the different operation 
                    {
                        op = 1;
                        operation(op);
                        historyText = historyText + "=" + outputText + "+";
                    }
                }
                else
                {
                    historyText = outputText + "+";
                    outputOne = float.Parse(outputText);
                    outputText = string.Empty;
                    op = 1;
                }
            }
        }

        public void Subraction()
        {
            if (outputText.Length > 0)
            {
                if (!string.IsNullOrEmpty(historyText))
                {
                    if (historyText.Contains("+") || historyText.Contains('-') || historyText.Contains('*') || historyText.Contains('/'))
                    {
                        if (outputText != "") //checks if the output textbox does not have a empty string
                        {
                            op = 2;
                            operation(op);
                            historyText = historyText + "=" + outputText + "-";
                        }
                    }
                }
                else
                {
                    if (outputText != "")
                    {
                        historyText = outputText + "-";
                        outputOne = float.Parse(outputText);
                        outputText = string.Empty;
                        op = 2;
                    }
                }
            }
        }

        public void Multiplication()
        {
            if (outputText.Length > 0)
            {
                if (!string.IsNullOrEmpty(historyText))
                {
                    if (historyText.Contains("+") || historyText.Contains('-') || historyText.Contains('*') || historyText.Contains('/'))
                    {
                        op = 3;
                        operation(op);
                        historyText = historyText + "=" + outputText + "*";
                    }
                }
                else
                {
                    historyText = outputText + "*";
                    outputOne = float.Parse(outputText);
                    outputText = string.Empty;
                    op = 3;
                }
            }
        }

        public void Division()
        {
            if (outputText.Length > 0)
            {
                if (!string.IsNullOrEmpty(historyText))
                {
                    if (historyText.Contains("+") || historyText.Contains('-') || historyText.Contains('*') || historyText.Contains('/'))
                    {
                        op = 4;
                        operation(op);
                        historyText = historyText + "=" + outputText + "/";
                    }
                }
                else
                {
                    historyText = outputText + "/";
                    outputOne = float.Parse(outputText);
                    outputText = string.Empty;
                    op = 4;
                }
            }
        }
    }
}
