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
            try
            {
                this.rECORDSTableAdapter1.Fill(this.qRScannerDataSet.RECORDS);
                this.aTWORKTableAdapter2.Fill(this.qRScannerDataSet.ATWORK);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void BTN_search_Click(object sender, EventArgs e)
        {
            DateTime date = monthCalendar1.SelectionRange.Start;
            DateTime dateNext = monthCalendar1.SelectionRange.Start;
            dateNext = dateNext.AddDays(1);

            try
            {
                this.rECORDSTableAdapter1.FillByDate(this.qRScannerDataSet.RECORDS, date, dateNext);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TSB_refresh_Click(object sender, EventArgs e)
        {
            atwork_record_Load(sender, e);
        }
    }
}
