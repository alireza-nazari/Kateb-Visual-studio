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
    
    public partial class mainFrom : Form
    {
        
        
        public mainFrom()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Globals.jagged_arr[1][Globals.flag] = nameOf.Text;
            Console.WriteLine(Globals.jagged_arr[1][Globals.flag]);
            Console.WriteLine(Globals.flag);
            Console.WriteLine(nameOf.Text);
            if (Globals.jagged_arr[1][Globals.flag].Length > Globals.flag)
            {
                Globals.flag += 1;
            }
            
        }
        
        private void show_Click(object sender, EventArgs e)
        {

            foreach (string name in Globals.jagged_arr[1])
            {
                if (name != null || name != String.Empty)
                {
                    Console.WriteLine(name);
                    lists.Items.Add(name);
                }
                else {
                    Console.WriteLine("NULL");
                }
                
            }
        }

        
    }

    public static class Globals
    {
        public static int flag = 0;
        public static string[][] jagged_arr = new String[3][];
    }
}
