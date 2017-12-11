using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteForce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string pass;
        bool numbersOnly;

        // Start Button

        private void UEstart_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Logic logic = new Logic(pass, numbersOnly);

            UEcounter.Text = logic.m_counter.ToString();
            UEinfo.Text = "Password found: " + logic.m_hackedPassword;

            this.Cursor = Cursors.Arrow;
        }

        // UE Events

        private void UEpassword_TextChanged(object sender, EventArgs e)
        {
            pass = UEpassword.Text;
        }

        private void UEnumbersOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (UEnumbersOnly.Checked)
                numbersOnly = true;
            else
                numbersOnly = false;
        }
    }
}
