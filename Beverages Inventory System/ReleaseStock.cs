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
    public partial class ReleaseStock : Form
    {
        public ReleaseStock()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void btnRelease_Click(object sender, EventArgs e)
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
                else if (Convert.ToInt32(txtCurrentStock.Text) < Convert.ToInt32(txtNewStock.Text))
                {
                    MessageBox.Show("Stocks is not Sufficient!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNewStock.Text == "")
                {
                    MessageBox.Show("Please input how many stocks", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string release = "UPDATE stock SET Stock=('" + txtCurrentStock.Text + "' - '" + txtNewStock.Text + "'), username = '"+usernameNew.Text+"' WHERE productID='" + txtProductID.Text + "'";
                    cmd = new MySqlCommand(release, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.Hide();
                }
            }catch
            {
                MessageBox.Show("Query not Executable!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
