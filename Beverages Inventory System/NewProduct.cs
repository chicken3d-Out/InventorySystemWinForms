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
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" && productSize.Text == "" && supplierID.Text=="")
                {
                    MessageBox.Show("Don't Leave the Fileds Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtProductName.Text == "" || productSize.Text == "" || supplierID.Text=="")
                {
                    MessageBox.Show("Don't Leave the Fields Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string checkDuplicateProduct = "SELECT Product, Size FROM product WHERE Product='" + txtProductName.Text + "' AND Size='" + productSize.Text + "'";
                    cmd = new MySqlCommand(checkDuplicateProduct, con);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read() == true)
                    {
                        MessageBox.Show("Product Already Exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProductName.Text = "";
                        productSize.Text = "";
                        txtProductName.Focus();
                        con.Close();
                    }
                    else if (dr.Read() == false)
                    {
                        dr.Close();
                        string add = "INSERT INTO product VALUES ('','" + txtProductName.Text + "','" + productSize.Text + "','"+ supplierID.Text +"');";
                        cmd = new MySqlCommand(add, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        txtProductName.Text = "";
                        productSize.Text = "";
                        this.Hide();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Query Not Executable", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
