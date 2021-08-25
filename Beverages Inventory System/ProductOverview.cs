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
    public partial class ProductOverview : UserControl
    {
        public ProductOverview()
        {
            InitializeComponent();
        }
        int indexRow;
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void ProductOverview_Load(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT ProductID,Product ,Size,supplierName FROM supplier sl INNER JOIN product pd ON sl.supplierID = pd.supplierID ORDER BY productID ASC;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewProduct.DataSource = dtable;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Action Cannot Be Processed!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewProduct product = new NewProduct();
            product.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT ProductID,Product ,Size,supplierName FROM supplier sl INNER JOIN product pd ON sl.supplierID = pd.supplierID ORDER BY productID ASC;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewProduct.DataSource = dtable;
                dataGridViewProduct.CurrentCell.Selected = false;
                con.Close();

                //clears search field
                searchBy.Text = "";
                txtSearch.Text = "";
            }
            catch
            {
                MessageBox.Show("Action Cannot Be Processed!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow getID = dataGridViewProduct.Rows[indexRow];
                //check if there is a selected row
                if (dataGridViewProduct.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("You did not select a row!", "Select Row!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are You Sure To Permanently Delete This Data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        string delete = "DELETE FROM product WHERE productID ='" + getID.Cells[0].Value + "'";
                        cmd = new MySqlCommand(delete, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //updates the deleted row from the datagridview automatically
                        int rowIndex = dataGridViewProduct.CurrentCell.RowIndex;
                        dataGridViewProduct.Rows.RemoveAt(rowIndex);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Delete first from Price and Stocks!", "Delete Unsucessfull!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridViewProduct.Rows[indexRow];
            }
            catch
            {
                MessageBox.Show("Avoid Clicking Anywhere", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //instantiate the value of dgv to edit form
            EditProduct editProduct = new EditProduct();
            DataGridViewRow getData = dataGridViewProduct.Rows[indexRow];

            editProduct.productSize.Text = Convert.ToString(getData.Cells[2].Value);
            editProduct.txtProductName.Text = Convert.ToString(getData.Cells[1].Value);
            //this label is not visible its function is to get the productID
            editProduct.productID.Text = Convert.ToString(getData.Cells[0].Value);

            //shows the edit form
            editProduct.ShowDialog();
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
                string dataTable = "SELECT ProductID,Product ,Size,supplierName FROM supplier sl INNER JOIN product pd ON sl.supplierID = pd.supplierID WHERE "+searchBy.Text+" LIKE '%"+txtSearch.Text+"%'ORDER BY productID ASC;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewProduct.DataSource = dtable;
                con.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
