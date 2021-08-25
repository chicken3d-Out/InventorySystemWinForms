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
    public partial class PriceSection : UserControl
    {
        public PriceSection()
        {
            InitializeComponent();
        }
        int indexRow;
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void PriceSection_Load(object sender, EventArgs e)
        {
            try
            {
                //Open Connection
                con.Open();
                string dataTable = "SELECT productID, price AS 'Price(PhP)' FROM price;";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);


                //fills the datagridview
                dataGridViewPrice.DataSource = dtable;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Query not Executable", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewPrice price = new NewPrice();
            price.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Open Connection
            con.Open();
            string dataTable = "SELECT productID, price AS 'Price(PhP)' FROM price;";
            adp = new MySqlDataAdapter(dataTable, con);
            DataTable dtable = new DataTable();
            adp.Fill(dtable);

            //fills the datagridview
            dataGridViewPrice.DataSource = dtable;
            dataGridViewPrice.CurrentCell.Selected = false;
            con.Close();

            //clears the category text and itemSearch textbox
            searchBy.Text = "";
            txtSearch.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow getID = dataGridViewPrice.Rows[indexRow];
                //check if there is a selected row
                if (dataGridViewPrice.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("You did not select a row!", "Select Row!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are You Sure To Permanently Delete This Data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        string delete = "DELETE FROM price WHERE productID ='" + getID.Cells[0].Value + "'";
                        cmd = new MySqlCommand(delete, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //updates the deleted row from the datagridview automatically
                        int rowIndex = dataGridViewPrice.CurrentCell.RowIndex;
                        dataGridViewPrice.Rows.RemoveAt(rowIndex);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Action Cannot Be Processed!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridViewPrice.Rows[indexRow];
            }
            catch
            {
                MessageBox.Show("Avoid Clicking Anywhere", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPrice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //instantiate the value of dgv to edit form
            EditPrice editPrice = new EditPrice();
            DataGridViewRow getData = dataGridViewPrice.Rows[indexRow];

            //instantiate the value
            editPrice.txtNewPrice.Text = Convert.ToString(getData.Cells[1].Value);
            editPrice.txtproductID.Text = Convert.ToString(getData.Cells[0].Value);

            //shows the edit form
            editPrice.ShowDialog();
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
                string dataTable = "SELECT productID, price AS 'Price(PhP)' FROM price WHERE "+searchBy.Text+" LIKE '%"+txtSearch.Text+"%';";
                adp = new MySqlDataAdapter(dataTable, con);
                DataTable dtable = new DataTable();
                adp.Fill(dtable);


                //fills the datagridview
                dataGridViewPrice.DataSource = dtable;
                con.Close();
            }
        }
    }
}
