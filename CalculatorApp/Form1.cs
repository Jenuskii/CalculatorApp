using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        private Rectangle oneButtonOriginalRectangle;
        private Rectangle twoButtonOriginalRectangle;
        private Rectangle threeButtonOriginalRectangle;
        private Rectangle fourButtonOriginalRectangle;
        private Rectangle fiveButtonOriginalRectangle;
        private Rectangle sixButtonOriginalRectangle;
        private Rectangle sevenButtonOriginalRectangle;
        private Rectangle eightButtonOriginalRectangle;
        private Rectangle nineButtonOriginalRectangle;
        private Rectangle zeroButtonOriginalRectangle;
        private Rectangle backSpaceButtonOriginalRectangle;
        private Rectangle negativeButtonOriginalRectangle;
        private Rectangle clearButtonOriginalRectangle;
        private Rectangle decimalButtonOriginalRectangle;
        private Rectangle sqrtButtonOriginalRectangle;
        private Rectangle multiplyButtonOriginalRectangle;
        private Rectangle divideButtonOriginalRectangle;
        private Rectangle minusButtonOriginalRectangle;
        private Rectangle plusButtonOriginalRectangle;
        private Rectangle equalButtonOriginalRectangle;
        private Rectangle displayLabelOriginalRectangle;
        private Rectangle historyLabelOriginalRectangle;
        private Rectangle AbsorbOriginalRectangle;
        private Size originalFormSize;
        
        float displayNum, historyNum;
        bool isNewNum, waitEqual = true;
        string lastOrder = "";

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    equalButton.PerformClick();
                    return true;
                case Keys.Up:
                    return true;
                case Keys.Down:
                    return true;
                case Keys.Right:
                    return true;
                case Keys.Left:
                    return true;
                default:
                    return false;
            }
        }

        public Calculator()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public void SetNum(string num)
        {
            
            if (isNewNum)
            {
                displayLabel.Text = num;
                isNewNum = false;
            }

            else if (displayLabel.Text == "0")
            { 
                displayLabel.Text = num; 
            }

            else
            { 
                displayLabel.Text += num; 
            }
        }

        public void SetOrder(string order)
        {
            isNewNum = true;
            if (waitEqual)
            {
                displayNum = float.Parse(displayLabel.Text);
                if (historyLabel.Text == "")
                {
                    historyNum = float.Parse(displayLabel.Text);
                    historyLabel.Text = historyLabel.Text + order;
                }
                else
                {
                    switch (lastOrder)
                    {
                        case " + ":
                            historyNum += displayNum;
                            break;
                        case " - ":
                            historyNum -= displayNum;
                            break;
                        case " * ":
                            historyNum *= displayNum;
                            break;
                        case " / ":
                            historyNum /= displayNum;
                            break;
                        default:
                            break;
                    }
                }
                lastOrder = order;
                historyLabel.Text = historyNum.ToString() + order;
            }
            else
            {
                historyNum = float.Parse(displayLabel.Text);
                historyLabel.Text = displayLabel.Text + order;                
                lastOrder = order;
                waitEqual = true;
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            oneButtonOriginalRectangle = new Rectangle(oneButton.Location.X,oneButton.Location.Y, oneButton.Width, oneButton.Height);
            twoButtonOriginalRectangle = new Rectangle(twoButton.Location.X, twoButton.Location.Y, twoButton.Width, twoButton.Height);
            threeButtonOriginalRectangle = new Rectangle(threeButton.Location.X, threeButton.Location.Y, threeButton.Width, threeButton.Height);
            fourButtonOriginalRectangle = new Rectangle(fourButton.Location.X, fourButton.Location.Y, fourButton.Width, fourButton.Height);
            fiveButtonOriginalRectangle = new Rectangle(fiveButton.Location.X, fiveButton.Location.Y, fiveButton.Width, fiveButton.Height);
            sixButtonOriginalRectangle = new Rectangle(sixButton.Location.X, sixButton.Location.Y, sixButton.Width, sixButton.Height);
            sevenButtonOriginalRectangle = new Rectangle(sevenButton.Location.X, sevenButton.Location.Y, sevenButton.Width, sevenButton.Height);
            eightButtonOriginalRectangle = new Rectangle(eightButton.Location.X, eightButton.Location.Y, eightButton.Width, eightButton.Height);
            nineButtonOriginalRectangle = new Rectangle(nineButton.Location.X, nineButton.Location.Y, nineButton.Width, nineButton.Height);
            zeroButtonOriginalRectangle = new Rectangle(zeroButton.Location.X, zeroButton.Location.Y, zeroButton.Width, zeroButton.Height);
            backSpaceButtonOriginalRectangle = new Rectangle(backSpaceButton.Location.X, backSpaceButton.Location.Y, backSpaceButton.Width, backSpaceButton.Height);
            negativeButtonOriginalRectangle = new Rectangle(negativeButton.Location.X, negativeButton.Location.Y, negativeButton.Width, negativeButton.Height);
            clearButtonOriginalRectangle = new Rectangle(clearButton.Location.X, clearButton.Location.Y, clearButton.Width, clearButton.Height);
            decimalButtonOriginalRectangle = new Rectangle(decimalButton.Location.X, decimalButton.Location.Y, decimalButton.Width, decimalButton.Height);
            sqrtButtonOriginalRectangle = new Rectangle(sqrtButton.Location.X, sqrtButton.Location.Y, sqrtButton.Width, sqrtButton.Height);
            multiplyButtonOriginalRectangle = new Rectangle(multiplyButton.Location.X, multiplyButton.Location.Y, multiplyButton.Width, multiplyButton.Height);
            divideButtonOriginalRectangle = new Rectangle(divideButton.Location.X, divideButton.Location.Y, divideButton.Width, divideButton.Height);
            minusButtonOriginalRectangle = new Rectangle(minusButton.Location.X, minusButton.Location.Y, minusButton.Width, minusButton.Height);
            plusButtonOriginalRectangle = new Rectangle(plusButton.Location.X, plusButton.Location.Y, plusButton.Width, plusButton.Height);
            equalButtonOriginalRectangle = new Rectangle(equalButton.Location.X, equalButton.Location.Y, equalButton.Width, equalButton.Height);
            displayLabelOriginalRectangle = new Rectangle(displayLabel.Location.X, displayLabel.Location.Y, displayLabel.Width, displayLabel.Height);
            historyLabelOriginalRectangle = new Rectangle(historyLabel.Location.X, historyLabel.Location.Y, historyLabel.Width, historyLabel.Height);
            AbsorbOriginalRectangle = new Rectangle(Absorb.Location.X, Absorb.Location.Y, Absorb.Width, Absorb.Height);
        }
        
        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(oneButtonOriginalRectangle, oneButton);
            resizeControl(twoButtonOriginalRectangle, twoButton);
            resizeControl(threeButtonOriginalRectangle, threeButton);
            resizeControl(fourButtonOriginalRectangle, fourButton);
            resizeControl(fiveButtonOriginalRectangle, fiveButton);
            resizeControl(sixButtonOriginalRectangle, sixButton);
            resizeControl(sevenButtonOriginalRectangle, sevenButton);
            resizeControl(eightButtonOriginalRectangle, eightButton);
            resizeControl(nineButtonOriginalRectangle, nineButton);
            resizeControl(zeroButtonOriginalRectangle, zeroButton);
            resizeControl(backSpaceButtonOriginalRectangle, backSpaceButton);
            resizeControl(negativeButtonOriginalRectangle, negativeButton);
            resizeControl(clearButtonOriginalRectangle, clearButton);
            resizeControl(decimalButtonOriginalRectangle, decimalButton);
            resizeControl(sqrtButtonOriginalRectangle, sqrtButton);
            resizeControl(multiplyButtonOriginalRectangle, multiplyButton);
            resizeControl(divideButtonOriginalRectangle, divideButton);
            resizeControl(minusButtonOriginalRectangle, minusButton);
            resizeControl(plusButtonOriginalRectangle, plusButton);
            resizeControl(equalButtonOriginalRectangle, equalButton);
            resizeControl(displayLabelOriginalRectangle, displayLabel);
            resizeControl(historyLabelOriginalRectangle, historyLabel);
            resizeControl(AbsorbOriginalRectangle, Absorb);
        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);

            int newXPosition = (int)(OriginalControlRect.X * xAxis);
            int newYPosition = (int)(OriginalControlRect.Y * yAxis);

            int newWidth = (int)(OriginalControlRect.Width * xAxis);
            int newHeight = (int)(OriginalControlRect.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            SetNum("0");
            Absorb.Select();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            SetNum("1");
            Absorb.Select();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            SetNum("2");
            Absorb.Select();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            SetNum("3");
            Absorb.Select();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            SetNum("4");
            Absorb.Select();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            SetNum("5");
            Absorb.Select();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            SetNum("6");
            Absorb.Select();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            SetNum("7");
            Absorb.Select();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            SetNum("8");
            Absorb.Select();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            SetNum("9");
            Absorb.Select();
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (displayLabel.Text.Contains(".") == false)
            {
                displayLabel.Text += ".";
                isNewNum = false;
            }
            Absorb.Select();
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            int stringLength = displayLabel.Text.Length;
            if (stringLength > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(0, stringLength - 1);
            }
            else
            {
                displayLabel.Text = "0";
            }
            Absorb.Select();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            isNewNum = true;
            waitEqual = true;
            displayLabel.Text = "0";
            historyLabel.Text = "";
            lastOrder = "";
            Absorb.Select();
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {
            if (displayLabel.Text.Substring(0,1) == "-")
            {
                displayLabel.Text = displayLabel.Text.Substring(1);
            }
            else
            {
                displayLabel.Text = "-" + displayLabel.Text;
            }
            Absorb.Select();
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            lastOrder = "";
            isNewNum = true;
            waitEqual = false;
            historyLabel.Text = "√" + displayLabel.Text;
            double sqrt = Math.Sqrt(float.Parse(displayLabel.Text));
            displayLabel.Text = sqrt.ToString();
            Absorb.Select();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            SetOrder(" * ");
            Absorb.Select();
        }

        private void divieButton_Click(object sender, EventArgs e)
        {
            SetOrder(" / ");
            Absorb.Select();
        }
        private void plusButton_Click(object sender, EventArgs e)
        {
            SetOrder(" + ");
            Absorb.Select();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            SetOrder(" - ");
            Absorb.Select();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                equalButton.PerformClick();
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.NumPad0:
                        zeroButton.PerformClick();
                        break;
                    case Keys.D0:
                        zeroButton.PerformClick();
                        break;

                    case Keys.NumPad1:
                        oneButton.PerformClick();
                        break;
                    case Keys.D1:
                        oneButton.PerformClick();
                        break;

                    case Keys.NumPad2:
                        twoButton.PerformClick();
                        break;
                    case Keys.D2:
                        twoButton.PerformClick();
                        break;

                    case Keys.NumPad3:
                        threeButton.PerformClick();
                        break;
                    case Keys.D3:
                        threeButton.PerformClick();
                        break;

                    case Keys.NumPad4:
                        fourButton.PerformClick();
                        break;
                    case Keys.D4:
                        fourButton.PerformClick();
                        break;

                    case Keys.NumPad5:
                        fiveButton.PerformClick();
                        break;
                    case Keys.D5:
                        fiveButton.PerformClick();
                        break;

                    case Keys.NumPad6:
                        sixButton.PerformClick();
                        break;
                    case Keys.D6:
                        sixButton.PerformClick();
                        break;

                    case Keys.NumPad7:
                        sevenButton.PerformClick();
                        break;
                    case Keys.D7:
                        sevenButton.PerformClick();
                        break;

                    case Keys.NumPad8:
                        eightButton.PerformClick();
                        break;
                    case Keys.D8:
                        eightButton.PerformClick();
                        break;

                    case Keys.NumPad9:
                        nineButton.PerformClick();
                        break;
                    case Keys.D9:
                        nineButton.PerformClick();
                        break;

                    case Keys.Divide:
                        divideButton.PerformClick();
                        break;

                    case Keys.Multiply:
                        multiplyButton.PerformClick();
                        break;

                    case Keys.Subtract:
                        minusButton.PerformClick();
                        break;

                    case Keys.Add:
                        plusButton.PerformClick();
                        break;

                    case Keys.Back:
                        backSpaceButton.PerformClick();
                        break;

                    default:
                        break;
                }
            }
           
        }

        private void Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {              
                default:
                    break;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {

            if (lastOrder == "")
            {
                historyLabel.Text = displayLabel.Text + " =";
                waitEqual = false;
            }
            else
            {
                if (waitEqual)
                {
                    historyLabel.Text += (displayLabel.Text + " =");
                    displayNum = float.Parse(displayLabel.Text);                    
                    waitEqual = false;
                }
                else
                {
                    historyNum = float.Parse(displayLabel.Text);
                    historyLabel.Text = displayLabel.Text + historyLabel.Text.Substring(historyLabel.Text.IndexOf(" "));
                }
                switch (lastOrder)
                {
                    case " + ":
                        displayLabel.Text = (historyNum + displayNum).ToString();
                        break;
                    case " - ":
                        displayLabel.Text = (historyNum - displayNum).ToString();
                        break;
                    case " * ":
                        displayLabel.Text = (historyNum * displayNum).ToString();
                        break;
                    case " / ":
                        displayLabel.Text = (historyNum / displayNum).ToString();
                        break;
                    default:
                        break;
                }
            }         
            isNewNum = true;
        }

    }
}
