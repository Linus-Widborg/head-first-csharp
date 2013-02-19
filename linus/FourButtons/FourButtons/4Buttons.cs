using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FourButtons
{
    public partial class FourButtonsForm : Form
    {
        public FourButtonsForm()
        {
            InitializeComponent();
        }

        private void PIbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("========================\n" + "The number of pi: " + Math.PI + "\n========================");
        }
    }
}
