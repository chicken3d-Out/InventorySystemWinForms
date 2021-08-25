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
    public partial class NewPrice : Form
    {
        public NewPrice()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == "" && txtNewPrice.Text == "")
                {
                    MessageBox.Show("Don't Leave the Fileds Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNewPrice.Text == "" || txtProductID.Text == "")
                {
                    MessageBox.Show("Don't Leave the Fields Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Open();
                string checkDuplicate = "SELECT productID FROM price WHERE productID='" + txtProductID.Text + "'";
                cmd = new MySqlCommand(checkDuplicate, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    MessageBox.Show("ProductID Already Exist", "ProductID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductID.Text = "";
                    txtProductID.Focus();
                    con.Close();
                }
                else if (dr.Read() == false)
                {
                    dr.Close();
                    string add = "INSERT INTO price VALUES ('','" + txtNewPrice.Text + "','" + txtProductID.Text + "')";
                    cmd = new MySqlCommand(add, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtProductID.Text = "";
                    txtNewPrice.Text = "";
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Product Doesn't Exist", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
