using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Beverages_Inventory_System
{
    public partial class LogSection : UserControl
    {
        public LogSection()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void LogSection_Load(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT phrase1 AS 'Log', stockChange AS 'Records', phrase2 AS '-_', Product AS '-', Size AS '_-', phrase3 AS '.', dateChanged AS '..', phrase4 AS '...', firstName AS 'FirstName', lastName AS 'LastName' FROM logs l,product p, account a WHERE l.productID = p.productID AND a.username=l.username Order by logsID ASC;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewLogs.DataSource = dtable;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Action Cannot Be Processed", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Open Connection
            con.Open();
            string dataTable = "SELECT phrase1 AS 'Log', stockChange AS 'Records', phrase2 AS '-_', Product AS '-', Size AS '_-', phrase3 AS '.', dateChanged AS '..', phrase4 AS '...', firstName AS 'FirstName', lastName AS 'LastName' FROM logs l,product p, account a WHERE l.productID = p.productID AND a.username=l.username Order by logsID ASC;";
            adp = new MySqlDataAdapter(dataTable, con);
            DataTable dtable = new DataTable();
            adp.Fill(dtable);

            //fills the datagridview
            dataGridViewLogs.DataSource = dtable;
            dataGridViewLogs.CurrentCell.Selected = false;
            con.Close();
        }

        private void dataGridViewLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
