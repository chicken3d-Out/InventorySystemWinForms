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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            //start clock tick
            timer1.Start();

            //display overview first
            lblSection.Text = "Overview";
            sidePanel.Top = btnOverview.Top;
            sidePanel.Height = btnOverview.Height;
            overviewSection1.BringToFront();

        }
        int indexRow;
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();
        private void btnStock_Click(object sender, EventArgs e)
        {
            lblSection.Text = "Stock";
            sidePanel.Top = btnStock.Top;
            sidePanel.Height = btnStock.Height;
            panelButtons.BringToFront();
            dataGridViewStock.BringToFront();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Exit?", "Close the Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //this following codes belongs to stockSection
        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT ProductID, stock AS 'Stock(Cases)', Date_Added FROM stock;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewStock.DataSource = dtable;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Query not Executable", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            

        }
        //this button brings each user forms to top
        private void btnOverview_Click(object sender, EventArgs e)
        {
            lblSection.Text = "Overview";
            sidePanel.Top = btnOverview.Top;
            sidePanel.Height = btnOverview.Height;
            overviewSection1.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            lblSection.Text = "Product";
            sidePanel.Top = btnProduct.Top;
            sidePanel.Height = btnProduct.Height;
            productOverview1.BringToFront();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            lblSection.Text = "Price";
            sidePanel.Top = btnPrice.Top;
            sidePanel.Height = btnPrice.Height;
            priceSection1.BringToFront();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            lblSection.Text = "Logs";
            sidePanel.Top = btnLogs.Top;
            sidePanel.Height = btnLogs.Height;
            logSection1.BringToFront();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            lblSection.Text = "Supplier";
            sidePanel.Top = btnSupplier.Top;
            sidePanel.Height = btnSupplier.Height;
            supplierSection1.BringToFront();
        }

        private void overviewSection1_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            NewStock stock = new NewStock();
            stock.usernameNew.Text = username.Text;
            stock.ShowDialog();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow getID = dataGridViewStock.Rows[indexRow];
                //check if there is a selected row
                if (dataGridViewStock.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("You did not select a row!", "Select Row!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are You Sure To Permanently Delete This Data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        string delete = "DELETE FROM stock WHERE productID ='" + getID.Cells[0].Value + "'";
                        cmd = new MySqlCommand(delete, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //updates the deleted row from the datagridview automatically
                        int rowIndex = dataGridViewStock.CurrentCell.RowIndex;
                        dataGridViewStock.Rows.RemoveAt(rowIndex);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Delete first from Price and Stocks!", "Delete Unsucessfull!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow getID = dataGridViewStock.Rows[indexRow];
                //check if there is a selected row
                if (dataGridViewStock.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("You did not select a row!", "Select Row!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AddStock addCurrentStock = new AddStock();
                    DataGridViewRow getData = dataGridViewStock.Rows[indexRow];
                    //pass the username to addstock modal
                    addCurrentStock.usernameNew.Text = username.Text;

                    //instantiate the value
                    addCurrentStock.txtNewStock.Text = Convert.ToString(getData.Cells[1].Value);
                    addCurrentStock.txtCurrentStock.Text = Convert.ToString(getData.Cells[1].Value);
                    addCurrentStock.txtProductID.Text = Convert.ToString(getData.Cells[0].Value);

                    addCurrentStock.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Querry Not Executable!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            //Open Connection
            con.Open();
            string dataTable = "SELECT ProductID, stock AS 'Stock(Cases)', Date_Added FROM stock;";
            adp = new MySqlDataAdapter(dataTable, con);
            DataTable dtable = new DataTable();
            adp.Fill(dtable);

            //fills the datagridview
            dataGridViewStock.DataSource = dtable;
            dataGridViewStock.CurrentCell.Selected = false;
            con.Close();

            //clears the search fields
            txtSearch.Text = "";
            searchBy.Text = "";
        }

        private void dataGridViewStock_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridViewStock.Rows[indexRow];
            }
            catch
            {
                MessageBox.Show("Avoid Clicking Anywhere", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewStock_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //instantiate the value of dgv to edit form
            ReleaseStock editStock = new ReleaseStock();
            DataGridViewRow getData = dataGridViewStock.Rows[indexRow];
            //pass username the value to editstock modal
            editStock.usernameNew.Text = username.Text;

            //instantiate the value
            editStock.txtNewStock.Text = Convert.ToString(getData.Cells[1].Value);
            editStock.txtCurrentStock.Text = Convert.ToString(getData.Cells[1].Value);
            editStock.txtProductID.Text = Convert.ToString(getData.Cells[0].Value);

            //shows the edit form
            editStock.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (searchBy.Text=="")
            {
                MessageBox.Show("Don't Leave the Fields Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                searchBy.Focus();
            }
            else if (txtSearch.Text =="")
            {
                MessageBox.Show("Don't Leave the Fields Empty!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
            }
            else
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT ProductID, stock AS 'Stock(Cases)', Date_Added FROM stock where " + searchBy.Text + " LIKE '%" + txtSearch.Text + "%';";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);

                //fills the datagridview
                dataGridViewStock.DataSource = dtable;
                con.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString().ToUpper();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
