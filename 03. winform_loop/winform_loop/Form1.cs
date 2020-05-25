using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_loop
{
    public partial class main : Form
    {
        
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float start_value = 0, rate = 0, years = 0, money = 0;

            start_value = float.Parse(int1.Text);
            rate = float.Parse(int2.Text);
            years = float.Parse(int3.Text);

            for (int i = 0; i <= years ; i++  )
            {
                money += (start_value * rate) / 100;   
            }

            int4.Text = money.ToString();
        }
    }
}
