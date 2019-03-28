using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QRScan
{
    class dbControl
    {
        private int ID;
        private static string connectionString = "Data Source=DESKTOP-9GS6M0J\\PARKING;Initial Catalog=QRControl;Integrated Security=True";
        private SqlConnection con=new SqlConnection(connectionString);

        public dbControl(int id) { this.ID = id; }
        public void setID(int id) { this.ID = id; }
        public int getID() { return this.ID; }

        public bool connectToDB()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void closeConnection()
        {
            con.Close();
        }

        private int rowsCount()
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) As Count FROM ATWORK WHERE ID_PERSON="+this.ID, con))
            {
                int row = Convert.ToInt16(command.ExecuteScalar());
                return row;
            }
        }
        public void writeToDB()
        {
            if (rowsCount() != 0)
            {
                using (SqlCommand command = new SqlCommand("UPDATE ATWORK SET LEAVE=GETDATE() WHERE ID_PERSON=" + this.ID, con)) 
                {
                    command.ExecuteNonQuery();
                }
                using (SqlCommand command = new SqlCommand("INSERT INTO RECORDS (ID_PERSON, ENTER, LEAVE) SELECT ID_PERSON, ENTER, LEAVE FROM ATWORK WHERE ID_PERSON=" + ID, con))
                {
                    command.ExecuteNonQuery();
                }
                using (SqlCommand command = new SqlCommand("DELETE FROM ATWORK WHERE ID_PERSON=" + ID, con))
                {
                    command.ExecuteNonQuery();
                }
                using (SqlCommand command = new SqlCommand("SELECT NAME FROM PEOPLE WHERE ID=" + this.ID, con))
                {
                    object Name = command.ExecuteScalar();
                    MessageBox.Show("Goodbye " + Name.ToString() + "!");
                }
            }
            else // Ако няма такова ID
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO ATWORK(ID_PERSON, ENTER) VALUES (" + ID + ", GETDATE())", con))
                {
                    command.ExecuteNonQuery();
                }
                using (SqlCommand command = new SqlCommand("SELECT NAME FROM PEOPLE WHERE ID=" + this.ID, con))
                {
                    object Name = command.ExecuteScalar();
                    MessageBox.Show("Hello " + Name.ToString() + "!");
                }

            }
        }
      
    }
}
