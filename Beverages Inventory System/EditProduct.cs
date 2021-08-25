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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" && productSize.Text == "" && supplierID.Text=="")
                {
                    MessageBox.Show("Please Fill All The Fields", "Blank Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Focus();
                }
                else if (productSize.Text == "" || productSize.Text == "" || supplierID.Text == "")
                {
                    MessageBox.Show("Please Fill All The Fields", "Blank Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productSize.Focus();
                }
                else
                {
                    con.Open();
                    string update = "UPDATE product SET product='" + txtProductName.Text + "',size='" + productSize.Text + "', supplierID ='"+supplierID.Text+"' WHERE productID='" + productID.Text + "'";
                    cmd = new MySqlCommand(update, con);
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
            this.Hide();
        }
    }
}
