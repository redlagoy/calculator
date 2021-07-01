using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorproj
{
    class classOperation
    {
        public string outputText, historyText;
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
                        if (outputText == "∞" || outputText == "-∞")
                        {
                            outputText = "MATH ERROR";
                            outputOne = 0;
                            finalOutput = 0;
                            op = 0;
                        }
                        break;
                }
            }
            catch
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
            if (outputText.Length > 0)
            {
                if (!string.IsNullOrEmpty(historyText))
                {
                    if (historyText.Contains("+") || historyText.Contains('-') || historyText.Contains('*') || historyText.Contains('/'))
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
                        if (outputText != "")
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
