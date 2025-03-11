using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Calculator
{
    public partial class csharpcalculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "";

        public csharpcalculator()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }

        private void DeciBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void PosNegBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = "-" + TxtBox.Text;
            }
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
        }

        private void ModuleBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "%";
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "exp";
        }

        private void PercentBtn_Click(object sender, EventArgs e)
        {
            valueFirst = (decimal.Parse(TxtBox.Text) / 100);
            TxtBox.Text = valueFirst.ToString();
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst - valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst + valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst / valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst * valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
                case "%":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst % valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
                case "exp":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    double i = Convert.ToDouble(valueFirst);
                    double j = Convert.ToDouble(valueSecond);
                    Result = (decimal)Math.Exp(i * Math.Log(j * 4));
                    TxtBox.Text = Result.ToString();
                    break;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            TxtBox.Text = "0";
        }

        private void csharpcalculator_Load(object sender, EventArgs e)
        {
            this.Width = 500;
            TxtBox.Width = 450;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 500;
            TxtBox.Width = 450;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 950;
            TxtBox.Width = 900;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "3.141592653589976323";
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(TxtBox.Text);
            log = Math.Log10(log);
            TxtBox.Text = Convert.ToString(log);
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(TxtBox.Text);
            sqrt = Math.Sqrt(sqrt);
            TxtBox.Text = Convert.ToString(sqrt);
        }

        private void buttonx2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtBox.Text) * Convert.ToDouble(TxtBox.Text);
            TxtBox.Text = Convert.ToString(x);
        }

        private void buttonx3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtBox.Text) * Convert.ToDouble(TxtBox.Text) * Convert.ToDouble(TxtBox.Text);
            TxtBox.Text = Convert.ToString(x);
        }

        private void buttonSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(TxtBox.Text);
            sh = Math.Sinh(sh);
            TxtBox.Text = Convert.ToString(sh);
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(TxtBox.Text);
            s = Math.Sin(s);
            TxtBox.Text = Convert.ToString(s);
        }

        private void buttonCosh_Click(object sender, EventArgs e)
        {
            double ch = Convert.ToDouble(TxtBox.Text);
            ch = Math.Cosh(ch);
            TxtBox.Text = Convert.ToString(ch);
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(TxtBox.Text);
            c = Math.Cos(c);
            TxtBox.Text = Convert.ToString(c);
        }

        private void buttonTanh_Click(object sender, EventArgs e)
        {
            double th = Convert.ToDouble(TxtBox.Text);
            th = Math.Tanh(th);
            TxtBox.Text = Convert.ToString(th);
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(TxtBox.Text);
            t = Math.Tan(t);
            TxtBox.Text = Convert.ToString(t);
        }

        private void buttonlnx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(TxtBox.Text);
            lnx = Math.Log(lnx);
            TxtBox.Text = Convert.ToString(lnx);
        }

        private void buttondivx_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(1 / Convert.ToDouble(TxtBox.Text));
            TxtBox.Text = Convert.ToString(a);
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(TxtBox.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)i1;
            TxtBox.Text = Convert.ToString(i2);
        }

        private void buttonBin_Click(object sender, EventArgs e)
        {
            int bin = int.Parse(TxtBox.Text);
            TxtBox.Text = Convert.ToString(bin, 2);
        }

        private void buttonHex_Click(object sender, EventArgs e)
        {
            int hex = int.Parse(TxtBox.Text);
            TxtBox.Text = Convert.ToString(hex, 16);
        }

        private void buttonoct_Click(object sender, EventArgs e)
        {
            int oct = int.Parse(TxtBox.Text);
            TxtBox.Text = Convert.ToString(oct, 8);
        }
    }
}
