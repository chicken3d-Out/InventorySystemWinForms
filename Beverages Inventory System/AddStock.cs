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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewStock.Text == "" && txtProductID.Text == "")
                {
                    MessageBox.Show("Please Fill All The Fields", "Blank Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductID.Focus();
                }
                else if (txtNewStock.Text == "" || txtProductID.Text == "")
                {
                    MessageBox.Show("Please Fill All The Fields", "Blank Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductID.Focus();
                }
                else
                {
                    con.Open();
                    string updateAddStock = "UPDATE stock SET stock=('" + txtCurrentStock.Text + "' + '" + txtNewStock.Text + "'), username='"+usernameNew.Text+"' WHERE productID='" + txtProductID.Text + "'";
                    cmd = new MySqlCommand(updateAddStock, con);
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
    }
}
