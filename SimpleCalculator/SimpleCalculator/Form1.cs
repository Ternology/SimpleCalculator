using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double firstNumber;
        double secondNumber;

        double answer;

        public Form1()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this Windows?", "Exit Simple Calculator", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                firstNumber = 0;
                secondNumber = 0;
                OutputBox.Text = "0";
            }
        }

        private void additionBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secondNumBOX.Text) && string.IsNullOrEmpty(firstNumBOX.Text))
            {
                MessageBox.Show("Cannot Accept, Input is Invalid.");
            }
            else
            {
                firstNumber = double.Parse(firstNumBOX.Text);
                secondNumber = double.Parse(secondNumBOX.Text);

                answer = firstNumber + secondNumber;

                OutputBox.Text = answer.ToString();
            }
        }

        private void substrBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secondNumBOX.Text) && string.IsNullOrEmpty(firstNumBOX.Text))
            {
                MessageBox.Show("Cannot Accept, Input is Invalid.");
            }
            else
            {
                firstNumber = double.Parse(firstNumBOX.Text);
                secondNumber = double.Parse(secondNumBOX.Text);

                answer = firstNumber - secondNumber;

                OutputBox.Text = answer.ToString();
            }
        }

        private void multipliBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secondNumBOX.Text) && string.IsNullOrEmpty(firstNumBOX.Text))
            {
                MessageBox.Show("Cannot Accept, Input is Invalid.");
            }
            else
            {
                firstNumber = double.Parse(firstNumBOX.Text);
                secondNumber = double.Parse(secondNumBOX.Text);

                answer = firstNumber * secondNumber;

                OutputBox.Text = answer.ToString();
            }
        }

        private void divisionBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secondNumBOX.Text) && string.IsNullOrEmpty(firstNumBOX.Text))
            {
                MessageBox.Show("Cannot Accept, Input is Invalid.");
            }
            else
            {
                firstNumber = double.Parse(firstNumBOX.Text);
                secondNumber = double.Parse(secondNumBOX.Text);

                answer = firstNumber / secondNumber;

                OutputBox.Text = answer.ToString();
            }
        }
    }
}