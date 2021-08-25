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
    public partial class NewSupplier : Form
    {
        public NewSupplier()
        {
            InitializeComponent();
        }
        //Instantiate Connection to XAMPP Server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void productSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSupplierName.Text == "" && txtContactNum.Text == "")
                {
                    MessageBox.Show("Don't Leave the Fileds Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtSupplierName.Text == "" || txtContactNum.Text == "")
                {
                    MessageBox.Show("Don't Leave the Fields Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string checkDuplicateProduct = "SELECT supplierName, contactNum FROM supplier WHERE supplierName='" + txtSupplierName.Text + "' AND contactNum='" + txtContactNum.Text + "'";
                    cmd = new MySqlCommand(checkDuplicateProduct, con);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read() == true)
                    {
                        MessageBox.Show("Supplier Already Exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSupplierName.Text = "";
                        txtContactNum.Text = "";
                        txtSupplierName.Focus();
                        con.Close();
                    }
                    else if (dr.Read() == false)
                    {
                        dr.Close();
                        string addSupplier = "INSERT INTO supplier VALUES ('','" + txtSupplierName.Text + "','" + txtContactNum.Text + "')";
                        cmd = new MySqlCommand(addSupplier, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        txtSupplierName.Text = "";
                        txtContactNum.Text = "";
                        this.Hide();
                    }
                }
            }catch
            {
                MessageBox.Show("Avoid Using Single Qoute in Supplier Name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
         
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
