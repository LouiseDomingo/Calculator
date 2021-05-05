﻿using System;
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
        public Calculator()
        {
            InitializeComponent();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (programScreen.Text == "0")
            {
                programScreen.Text = string.Empty;
                programScreen.Text = programScreen.Text + "0";
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
            };
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
            programScreen.Text = programScreen.Text + ".";
        }

        private void posNegBtn_Click(object sender, EventArgs e)
        {

        }

        private void percentBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            programScreen.Text = string.Empty;
        }
    }
}
