using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04.winform_array
{
    public partial class main : Form
    {
        string[][] jagged_arr = new string[2][];
        int flag = 0;
        public main()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            jagged_arr[flag][0] = name.Text.ToString();  
            flag += 1;
        }

        private void show_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= jagged_arr.Length; i++)
            {
                lists.Items.Add(jagged_arr[i][0]);
            }
        }

        
    }
}
