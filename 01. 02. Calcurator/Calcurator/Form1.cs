using System;
using System.Windows.Forms;

namespace Calcurator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

      
        }

        private void setNum(string str)
        {
            if (output.Text == "0")
            {
                output.Text = str;
            }
            else
            {
                output.Text += str;
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            setNum("0");
        }
        
        private void num1_Click(object sender, EventArgs e)
        {
            setNum("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            setNum("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            setNum("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            setNum("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            setNum("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            setNum("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            setNum("7");
        }
        private void num8_Click(object sender, EventArgs e)
        {
            setNum("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            setNum("9");
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }
        private void btn_dot_Click(object sender, EventArgs e)
        {
            setNum(".");
        }
        private void btn_ac_Click(object sender, EventArgs e)
        {
            output.Text = "0";
            outtop.Text = "";
            oprate.Text = "";
            esym.Text = "";
            result.Text = "";
        }
        public void oprating(char sym)
        {
            char[] cops = oprate.Text.ToCharArray();
            if (cops.Length > 0)
            {
                float first = float.Parse(outtop.Text);
                float second = float.Parse(output.Text);
                char[] osym = oprate.Text.ToCharArray();
                float r = 0;
                switch (osym[0])
                {
                    case '+':
                        r = first + second;
                        break;
                    case '-':
                        r = first - second;
                        break;
                    case '*':
                        r = first * second;
                        break;
                    case '/':
                        r = first / second;
                        break;
                }
                outtop.Text = r.ToString();
                output.Text = "0";
                oprate.Text = sym.ToString();
            }
            else
            {
                switch (sym)
                {
                    case '+':
                        outtop.Text = output.Text;
                        oprate.Text = "+";
                        output.Text = "0";
                        break;
                    case '-':
                        outtop.Text = output.Text;
                        oprate.Text = "-";
                        output.Text = "0";
                        break;
                    case '*':
                        outtop.Text = output.Text;
                        oprate.Text = "*";
                        output.Text = "0";
                        break;
                    case '/':
                        outtop.Text = output.Text;
                        oprate.Text = "/";
                        output.Text = "0";
                        break;
                }
            }
        }
        private void btn_plus_Click(object sender, EventArgs e)
        {
            oprating('+');
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            oprating('-');
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            oprating('*');
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            oprating('/');
        }
        private void btn_equl_Click(object sender, EventArgs e)
        {
            float first  = float.Parse(outtop.Text);
            float second = float.Parse(output.Text);
            char[] sym = oprate.Text.ToCharArray();
            float r = 0;
            switch (sym[0])
            {
                case '+':
                    r = first + second;
                    break;
                case '-':
                    r = first - second;
                    break;
                case '*':
                    r = first * second;
                    break;
                case '/':
                    r = first / second;
                    break;
            }
            result.Text = r.ToString() ;
            esym.Text = "=";
        }

        
    }
}
