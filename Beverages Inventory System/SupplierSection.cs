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
    public partial class SupplierSection : UserControl
    {
        public SupplierSection()
        {
            InitializeComponent();
        }
        int indexRow;
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void SupplierSection_Load(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT supplierID AS 'Supplier ID', supplierName AS 'Supplier', contactNum AS 'Contact No.' FROM supplier;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewSupplier.DataSource = dtable;
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
            NewSupplier supplier = new NewSupplier();
            supplier.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Open Connection
            con.Open();
            string dataTable = "SELECT supplierID AS 'Supplier ID', supplierName AS 'Supplier', contactNum AS 'Contact No.' FROM supplier;";
            adp = new MySqlDataAdapter(dataTable, con);
            DataTable dtable = new DataTable();
            adp.Fill(dtable);

            //fills the datagridview
            dataGridViewSupplier.DataSource = dtable;
            dataGridViewSupplier.CurrentCell.Selected = false;
            con.Close();

            //clears search fields
            searchBy.Text = "";
            txtSearch.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow getID = dataGridViewSupplier.Rows[indexRow];
                //check if there is a selected row
                if (dataGridViewSupplier.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("You did not select a row!", "Select Row!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are You Sure To Permanently Delete This Data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        string delete = "DELETE FROM supplier WHERE supplierID ='" + getID.Cells[0].Value + "'";
                        cmd = new MySqlCommand(delete, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //updates the deleted row from the datagridview automatically
                        int rowIndex = dataGridViewSupplier.CurrentCell.RowIndex;
                        dataGridViewSupplier.Rows.RemoveAt(rowIndex);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed To Delete!", "Delete Unsucessfull!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void dataGridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridViewSupplier.Rows[indexRow];
            }
            catch
            {
                MessageBox.Show("Avoid Clicking Anywhere", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //instantiate the value of dgv to edit form
            EditSupplier editProduct = new EditSupplier();
            DataGridViewRow getData = dataGridViewSupplier.Rows[indexRow];

            editProduct.txtContactNum.Text = Convert.ToString(getData.Cells[2].Value);
            editProduct.txtSupplierName.Text = Convert.ToString(getData.Cells[1].Value);
            //this label is not visible its function is to get the productID
            editProduct.supplierID.Text = Convert.ToString(getData.Cells[0].Value);

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
                con.Open();
                string dataTable = "SELECT supplierID AS 'Supplier ID', supplierName AS 'Supplier', contactNum AS 'Contact No.' FROM supplier WHERE "+searchBy.Text+" LIKE '%"+txtSearch.Text+"%';";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewSupplier.DataSource = dtable;
                con.Close();
            }
        }
    }
}
