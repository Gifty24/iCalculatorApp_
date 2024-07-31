using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCalculatorApp_
{
    public partial class CalculatorForm : Form
    {
        private Math calculator=new Math();
        private string currentInput = "";
        private string history = "";
        private double? firstNumber= null;
        private double? secondNumber= null;
        private string operation = null;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Button button =sender as Button;
            currentInput += button.Text;
            txtDisplay.Text = currentInput;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Text;
            txtDisplay.Text = currentInput;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Text;
            txtDisplay.Text = currentInput;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Text;
            txtDisplay.Text = currentInput;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Text;
            txtDisplay.Text = currentInput;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Text;
            txtDisplay.Text = currentInput;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Text;
            txtDisplay.Text = currentInput;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Text;
            txtDisplay.Text = currentInput;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Text;
            txtDisplay.Text = currentInput;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Text;
            txtDisplay.Text = currentInput;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (double.TryParse(currentInput, out double number))
            {
                firstNumber = number;
                currentInput = "";
                operation = button.Text;
                history += firstNumber + " " + operation + " ";
                txtHistory.Text = history;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Button button =sender as Button;
            if (double.TryParse(currentInput, out double number))
            {
                firstNumber=number;
                currentInput = "";
                operation=button.Text;
                history += firstNumber + " " + operation + " ";
                txtHistory.Text = history;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (double.TryParse(currentInput, out double number))
            {
                firstNumber = number;
                currentInput = "";
                operation = button.Text;
                history += firstNumber + " " + operation + " ";
                txtHistory.Text = history;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (double.TryParse(currentInput, out double number))
            {
                firstNumber = number;
                currentInput = "";
                operation = button.Text;
                history += firstNumber + " " + operation + " ";
                txtHistory.Text = history;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if(double.TryParse(currentInput, out double number))
            {
                secondNumber = number;
                double result = 0;
                    try
                {
                    switch(operation)
                    {
                        case "+":
                            result = calculator.Add((double)firstNumber, (double)secondNumber);
                            break;
                        case "-":
                            result = calculator.Subtract((double)firstNumber, (double)secondNumber);
                            break;
                        case "*":
                            result = calculator.Multiply((double)firstNumber, (double)secondNumber);
                            break;
                        case "/":
                            result = calculator.Divide((double)firstNumber, (double)secondNumber);
                            break;
                        case "√":
                            result = calculator.SquareRoot((double)firstNumber);
                            break;
                        case "%":
                            result= calculator.Multiply((double)firstNumber,(double)secondNumber);
                            break;
                    }
                    txtHistory.Text = result.ToString();
                    history += secondNumber + "=" + result + "\n  ";
                    txtHistory.Text = history;
                    firstNumber = result;
                    secondNumber = null;
                    currentInput = "";

                }
                catch (Exception ex)
                {
                    txtDisplay.Text = "Error";
                    history += "Error: " + ex.Message + "\n  ";
                    txtHistory.Text = history;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            txtHistory.Text = "";
            currentInput = "";
            firstNumber = null;
            secondNumber=null;
            operation= null;
            history = "";
            txtHistory.Text = history;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if (double.TryParse(currentInput, out double number))
            {
                double result = 0;
                try
                {
                    result = calculator.SquareRoot(number);
                    txtDisplay.Text = result.ToString();
                    history += "√" + number + "=" + result + "\n";
                    txtHistory.Text = history;
                    currentInput = "";
                }
                catch (Exception ex)
                {
                    txtDisplay.Text = "Error";
                    history += "Error: " + ex.Message + "\n  ";
                    txtHistory.Text = history;
                }
                    
                
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(currentInput,out double number))
            {
                double result = 0;
                try
                {
                    result = calculator.Percentage((double)firstNumber, number);
                    txtDisplay.Text = result.ToString();
                    history += firstNumber + "%" + number + "=" + result + "\n";
                    currentInput = "";
                }
                catch(Exception ex)
                {
                    txtDisplay.Text = "Error";
                    history += "Error: " + ex.Message + "\n";
                    txtHistory.Text = history;
                }
            }
        }
    }
}
