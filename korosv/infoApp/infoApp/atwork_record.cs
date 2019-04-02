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
    public partial class atwork_record : Form
    {
        public atwork_record()
        {
            InitializeComponent();
        }

        private void atwork_record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qRScannerDataSet.RECORDS' table. You can move, or remove it, as needed.
            this.rECORDSTableAdapter1.Fill(this.qRScannerDataSet.RECORDS);
            // TODO: This line of code loads data into the 'qRScannerDataSet.ATWORK' table. You can move, or remove it, as needed.
            this.aTWORKTableAdapter2.Fill(this.qRScannerDataSet.ATWORK);

        }
    }
}
