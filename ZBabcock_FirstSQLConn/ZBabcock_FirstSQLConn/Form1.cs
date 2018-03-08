using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBabcock_FirstSQLConn
{
    public partial class frmVendor : Form
    {
        public frmVendor()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {         //Edit first row of connString to change the server, second row for database.
            try
            {
                string connString = @"Server=PL1\MTCDB;
                                    Database=AdventureWorks2012;
                                        Trusted_Connection=True";

                SqlConnection sqlConn = new SqlConnection(connString);

                SqlDataAdapter sqlDataAd = new SqlDataAdapter("sp_VendorInfo", sqlConn);

                DataTable dtVendors = new DataTable();

                sqlDataAd.Fill(dtVendors);

                dataGridVend.DataSource = dtVendors;

            }
            catch
            {
                MessageBox.Show("There was an error with displaying the data. It was most likely due to either the attempted connection string or the data adapter.");

            }


        }
    }
}
