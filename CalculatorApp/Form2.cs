using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            KeyDown += Form2_KeyDown;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(e);
        }
    }
}
