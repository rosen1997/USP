using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace infoApp
{
    public partial class people : Form
    {
        public people()
        {
            InitializeComponent();
        }

        private void people_Load(object sender, EventArgs e)
        {
            try
            {
                this.pEOPLETableAdapter.Fill(this.qRScannerDataSet.PEOPLE);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            // TODO: This line of code loads data into the 'qRScannerDataSet.PEOPLE' table. You can move, or remove it, as needed.
        }

        private void searchByNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pEOPLETableAdapter.SearchByName(this.qRScannerDataSet.PEOPLE, nAMEToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            people_Load(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pEOPLETableAdapter.DeleteQuery(ID);

            foreach (DataGridViewRow oneRow in dataGridView1.SelectedRows)
            {
                if (oneRow.Selected)
                {
                    DialogResult res = MessageBox.Show("Removing a person!", "Removing", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.OK)
                    {

                        string Num_to_del = oneRow.Cells[0].Value.ToString();

                        try
                        {
                            this.pEOPLETableAdapter.DeleteQuery(int.Parse(Num_to_del));
                            dataGridView1.Rows.RemoveAt(oneRow.Index);
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }

                    }
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n;
            string p;

            n = name.Text;
            p = position.Text;

            if (n == "" || p == "")
            {
                MessageBox.Show("Empty");
            }

            else
            {
                try
                {
                    pEOPLETableAdapter.InsertQuery(n, p);
                    people_Load(sender, e);
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
