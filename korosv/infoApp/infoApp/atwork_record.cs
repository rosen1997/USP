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
            // TODO: This line of code loads data into the 'qRScannerDataSet4.ATWORK' table. You can move, or remove it, as needed.
            this.aTWORKTableAdapter1.Fill(this.qRScannerDataSet4.ATWORK);
            // TODO: This line of code loads data into the 'qRScannerDataSet3.RECORDS' table. You can move, or remove it, as needed.
            this.rECORDSTableAdapter.Fill(this.qRScannerDataSet3.RECORDS);
            // TODO: This line of code loads data into the 'qRScannerDataSet2.ATWORK' table. You can move, or remove it, as needed.
            this.aTWORKTableAdapter.Fill(this.qRScannerDataSet2.ATWORK);

        }
    }
}
