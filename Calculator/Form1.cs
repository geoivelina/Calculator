using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculater : Form
    {
        private Rectangle oneBtnOriginalRectangle;
        private Rectangle twoBtnOriginalRectangle;
        private Rectangle threeBtnOriginalRectangle;
        private Rectangle fourBtnOriginalRectangle;
        private Rectangle fiveBtnOriginalRectangle;
        private Rectangle sixBtnOriginalRectangle;
        private Rectangle sevenBtnOriginalRectangle;
        private Rectangle eightBtnOriginalRectangle;
        private Rectangle nineBtnOriginalRectangle;
        private Rectangle zeroBtnOriginalRectangle;

        private Rectangle decimalBtnOriginalRectangle;

        private Rectangle plusBtnOriginalRectangle;
        private Rectangle minusBtnOriginalRectangle;
        private Rectangle mupltiplyBtnOriginalRectangle;
        private Rectangle divideBtnOriginalRectangle;
        private Rectangle equalBtnOriginalRectangle;

        private Rectangle backspaceBtnOriginalRectangle;
        private Rectangle clearBtnOriginalRectangle;
        private Rectangle squareRootBtnOriginalRectangle;
        private Rectangle plusMinusBtnOriginalRectangle;

        private Rectangle displayOriginalRectangle;


        string userInput = "";

        string firstNum = "";
        char function;
        string secondNum = "";

        double result = 0.0;
        public Calculater()
        {
            InitializeComponent();
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "1";
            Display.Text += userInput;
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "2";
            Display.Text += userInput;
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "3";
            Display.Text += userInput;
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += 4;
            Display.Text += userInput;
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "5";
            Display.Text += userInput;
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "6";
            Display.Text += userInput;
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "7";
            Display.Text += userInput;
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "8";
            Display.Text += userInput;
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "9";
            Display.Text += userInput;
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            userInput += "0";
            Display.Text += userInput;
        }

     
        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            Display.Text += ".";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            function = '+';

            firstNum = userInput;
            userInput = "";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            function = '*';

            firstNum = userInput;
            userInput = "";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            function = '/';

            firstNum = userInput;
            userInput = "";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            function = '-';

            firstNum = userInput;
            userInput = "";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            secondNum = userInput;
            double first, second;
            first = Convert.ToDouble(firstNum);
            second = Convert.ToDouble(secondNum);
           
            //ADDING
            if (function == '+')
            {
                result = first + second;
                Display.Text = result.ToString();
            }

            //SUBSTRACTING
            else if (function == '-')
            {
                result = first - second;
                Display.Text = result.ToString();
            }

            //MULTIPLYING
            else if (function == '*')
            {
                if (first == '0' || second =='0')
                {
                    Display.Text = "0";
                }

                else
                {
                    result = first * second;
                    Display.Text = result.ToString();
                }
            }
            //DEVIDING
            else if (function == '/')
            {
                if (second == '0')
                {
                    Display.Text = "Cannot divide by zero";
                }

                else
                {
                    result = first / second;
                    Display.Text = result.ToString();
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            firstNum = "";
            secondNum = "";
            userInput = "";
            result = 0.0;
            Display.Text = "0";
        }

        private void BackspaceBtn_Click(object sender, EventArgs e)
        {

        }

        private void CquareRootBtn_Click(object sender, EventArgs e)
        {

        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
