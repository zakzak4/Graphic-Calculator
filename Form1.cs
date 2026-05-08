using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZakCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double FirstNumber;
        double SecondNumber;
        double Result;
        char Operator;

        private void BUTTON_CLEAR_Click(object sender, EventArgs e)
        {
            DISPLAY.Text = "0";
        }

        private void BUTTON_1_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text == "0")
                DISPLAY.Text = "1";
            else
                DISPLAY.Text = DISPLAY.Text + "1";
        }

        private void BUTTON_2_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text == "0")
                DISPLAY.Text = "2";
            else
                DISPLAY.Text = DISPLAY.Text + "2";
        }

        private void BUTTON_3_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text == "0")
                DISPLAY.Text = "3";
            else
                DISPLAY.Text = DISPLAY.Text + "3";
        }

        private void BUTTON_4_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text == "0")
                DISPLAY.Text = "4";
            else
                DISPLAY.Text = DISPLAY.Text + "4";
        }

        private void BUTTON_5_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text == "0")
                DISPLAY.Text = "5";
            else
                DISPLAY.Text = DISPLAY.Text + "5";
        }

        private void BUTTON_6_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text == "0")
                DISPLAY.Text = "6";
            else
                DISPLAY.Text = DISPLAY.Text + "6";
        }

        private void BUTTON_7_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text == "0")
                DISPLAY.Text = "7";
            else
                DISPLAY.Text = DISPLAY.Text + "7";
        }

        private void BUTTON_8_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text == "0")
                DISPLAY.Text = "8";
            else
                DISPLAY.Text = DISPLAY.Text + "8";
        }

        private void BUTTON_9_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text == "0")
                DISPLAY.Text = "9";
            else
                DISPLAY.Text = DISPLAY.Text + "9";
        }

        private void BUTTON_0_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text == "0")
                DISPLAY.Text = "0";
            else
                DISPLAY.Text = DISPLAY.Text + "0";
        }

        private void BUTTON_PLUS_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(DISPLAY.Text);
            DISPLAY.Text = "0";
            Operator = '+';
        }

        private void BUTTON_MIN_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(DISPLAY.Text);
            DISPLAY.Text = "0";
            Operator = '-';
        }

        private void BUTTON_MULT_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(DISPLAY.Text);
            DISPLAY.Text = "0";
            Operator = '*';
        }

        private void BUTTON_DIV_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(DISPLAY.Text);
            DISPLAY.Text = "0";
            Operator = '÷';
        }

        private void BUTTON_TOTAL_Click(object sender, EventArgs e)
        {
            SecondNumber = Convert.ToDouble(DISPLAY.Text);
            switch (Operator)
            {
                case '+':
                    Result = FirstNumber + SecondNumber;
                    DISPLAY.Text = Convert.ToString(Result);
                    break;
                case '-':
                    Result = FirstNumber - SecondNumber;
                    DISPLAY.Text = Convert.ToString(Result);
                    break;
                case '*':
                    Result = FirstNumber * SecondNumber;
                    DISPLAY.Text = Convert.ToString(Result);
                    break;
                case '÷':
                    Result = FirstNumber / SecondNumber;
                    DISPLAY.Text = Convert.ToString(Result);
                    break;
            }
        }

        private void BUTTON_BACKSPACE_Click(object sender, EventArgs e)
        {
            if (DISPLAY.Text.Length > 1)
            {
                DISPLAY.Text = DISPLAY.Text.Substring(0, DISPLAY.Text.Length - 1);
            }
            else
            {
                DISPLAY.Text = "0";
            }
        }

        private void BUTTON_PERCENT_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(DISPLAY.Text);
            double percentValue = currentNumber / 100.0;
            DISPLAY.Text = percentValue.ToString();
        }
    }
}