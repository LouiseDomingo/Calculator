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
    public partial class Calculator : Form
    {
        Double firstInput;
        Double secondInput;
        String operation;
        Double Result;
        Double negativeValue;
        Double percentValue;

        public Calculator()
        {
            InitializeComponent();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                
            }
            else
            {
                programScreen.Text = programScreen.Text + "0";
            }
        }

        private void unoBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                programScreen.Text = string.Empty;
                programScreen.Text = programScreen.Text + "1";
            }
            else
            {
                programScreen.Text = programScreen.Text + "1";
            }
        }

        private void dosBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                programScreen.Text = string.Empty;
                programScreen.Text = programScreen.Text + "2";
            }
            else
            {
                programScreen.Text = programScreen.Text + "2";
            }
        }

        private void tresBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                programScreen.Text = string.Empty;
                programScreen.Text = programScreen.Text + "3";
            }
            else
            {
                programScreen.Text = programScreen.Text + "3";
            }
        }

        private void kwatroBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                programScreen.Text = string.Empty;
                programScreen.Text = programScreen.Text + "4";
            }
            else
            {
                programScreen.Text = programScreen.Text + "4";
            }
        }

        private void singkoBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                programScreen.Text = string.Empty;
                programScreen.Text = programScreen.Text + "5";
            }
            else
            {
                programScreen.Text = programScreen.Text + "5";
            }
        }

        private void saisBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                programScreen.Text = string.Empty;
                programScreen.Text = programScreen.Text + "6";
            }
            else
            {
                programScreen.Text = programScreen.Text + "6";
            }
        }

        private void siyeteBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                programScreen.Text = string.Empty;
                programScreen.Text = programScreen.Text + "7";
            }
            else
            {
                programScreen.Text = programScreen.Text + "7";
            }
        }

        private void otchoBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                programScreen.Text = string.Empty;
                programScreen.Text = programScreen.Text + "8";
            }
            else
            {
                programScreen.Text = programScreen.Text + "8";
            }
        }

        private void nuwebeBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                programScreen.Text = string.Empty;
                programScreen.Text = programScreen.Text + "9";
            }
            else
            {
                programScreen.Text = programScreen.Text + "9";
            }
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text.Contains("."))
            {

            }
            else
            {
                programScreen.Text = programScreen.Text + ".";
            }
        }

        private void posNegBtn_Click(object sender, EventArgs e)
        {
            negativeValue = Convert.ToDouble(programScreen.Text) * -1;
            programScreen.Text = negativeValue.ToString();
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            percentValue = Convert.ToDouble(programScreen.Text) / 100;
            programScreen.Text = percentValue.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text.Length > 1)
            {
                programScreen.Text = programScreen.Text.Remove(programScreen.Text.Length - 1);
            }
            else
            {
                programScreen.Text = "0";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            programScreen.Text = "0";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            equalBtn.Enabled = true;
            firstInput = Convert.ToDouble(programScreen.Text);
            programScreen.Text = "0";
            operation = "+";
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            equalBtn.Enabled = true;
            firstInput = Convert.ToDouble(programScreen.Text);
            programScreen.Text = "0";
            operation = "-";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            equalBtn.Enabled = true;
            firstInput = Convert.ToDouble(programScreen.Text);
            programScreen.Text = "0";
            operation = "*";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            equalBtn.Enabled = true;
            firstInput = Convert.ToDouble(programScreen.Text);
            programScreen.Text = "0";
            operation = "/";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            secondInput = Convert.ToDouble(programScreen.Text);
            
            if (operation == "+")
            {
                Result = firstInput + secondInput;
                programScreen.Text = Result.ToString();
                equalBtn.Enabled = false;
            }

            if (operation == "-")
            {
                Result = firstInput - secondInput;
                programScreen.Text = Result.ToString();
                equalBtn.Enabled = false;
            }

            if (operation == "*")
            {
                Result = firstInput * secondInput;
                programScreen.Text = Result.ToString();
                equalBtn.Enabled = false;
            }

            if (operation == "/")
            {
                if (secondInput != 0)
                {
                    Result = firstInput / secondInput;
                    programScreen.Text = Result.ToString();
                    equalBtn.Enabled = false;
                }
                else
                {
                    programScreen.Text = "Undefined";
                    equalBtn.Enabled = false;
                }
            }

            private void disablingButtons()
            {
                zeroBtn.Enabled = false;
                unoBtn.Enabled = false;
                dosBtn.Enabled = false;
                tresBtn.Enabled = false;
                kwatroBtn.Enabled = false;
                singkoBtn.Enabled = false;
                saisBtn.Enabled = false;
                siyeteBtn.Enabled = false;
                otchoBtn.Enabled = false;
                nuwebeBtn.Enabled = false;
                posNegBtn.Enabled = false;
                decimalBtn.Enabled = false;
                percentBtn.Enabled = false;
                deleteBtn.Enabled = false;
                add.Enabled = false;
                subtractBtn.Enabled = false;
                multiplyBtn.Enabled = false;
                divideBtn.Enabled = false;
                equalBtn.Enabled = false;
            }



        }
    }
}
