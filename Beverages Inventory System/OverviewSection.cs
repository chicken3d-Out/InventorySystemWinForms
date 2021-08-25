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
    public partial class OverviewSection : UserControl
    {
        public OverviewSection()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void OverviewSection_Load(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT Product,Size ,Price,Stock, SupplierName, Date_Added FROM product p INNER JOIN price pr ON p.productID = pr.productID INNER JOIN stock s ON p.productID = s.productID INNER JOIN supplier sp ON sp.supplierID = p.supplierID Order by p.productID ASC;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewOverview.DataSource = dtable;
                con.Close();
            }

            catch
            {
                MessageBox.Show("Action Cannot Be Processed", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            
        }

        private void dataGridViewOverview_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewOverview.ClearSelection();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataOverview = "SELECT Product,Size ,Price,Stock, SupplierName, Date_Added FROM product p INNER JOIN price pr ON p.productID = pr.productID INNER JOIN stock s ON p.productID = s.productID INNER JOIN supplier sp ON sp.supplierID = p.supplierID Order by p.productID ASC;";
                adp = new MySqlDataAdapter(dataOverview, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewOverview.DataSource = dtable;
                dataGridViewOverview.CurrentCell.Selected = false;
                con.Close();

                //clear search fields
                searchBy.Text = "";
                txtSearch.Text = "";
            }

            catch
            {
                MessageBox.Show("Action Cannot Be Processed", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (searchBy.Text == "")
            {
                MessageBox.Show("Don't Leave the Fields Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                searchBy.Focus();
            }
            else if (txtSearch.Text == "")
            {
                MessageBox.Show("Don't Leave the Fields Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
            }
            else
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT Product,Size ,Price,Stock, SupplierName, Date_Added FROM product p INNER JOIN price pr ON p.productID = pr.productID INNER JOIN stock s ON p.productID = s.productID INNER JOIN supplier sp ON sp.supplierID = p.supplierID WHERE "+searchBy.Text+" LIKE '%"+txtSearch.Text+"%' Order by p.productID ASC;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewOverview.DataSource = dtable;
                con.Close();
            }
        }
    }
}
