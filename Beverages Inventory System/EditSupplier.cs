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
    public partial class EditSupplier : Form
    {
        public EditSupplier()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierName.Text == "" && txtContactNum.Text == "")
                {
                    MessageBox.Show("Please Fill All The Fields", "Blank Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSupplierName.Focus();
                }
                else if (txtSupplierName.Text == "" || txtContactNum.Text == "")
                {
                    MessageBox.Show("Please Fill All The Fields", "Blank Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContactNum.Focus();
                }
                else
                {
                    con.Open();
                    string updateSupplier = "UPDATE supplier SET supplierName='" + txtSupplierName.Text + "',contactNum='" + txtContactNum.Text + "' WHERE supplierID='" + supplierID.Text + "'";
                    cmd = new MySqlCommand(updateSupplier, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Query not Executable", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
