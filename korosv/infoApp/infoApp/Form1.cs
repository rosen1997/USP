using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            people form = new people();
            form.Show();
        }

        private void aTWORKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atwork_record form = new atwork_record();
            form.Show();
        }
    }
}
