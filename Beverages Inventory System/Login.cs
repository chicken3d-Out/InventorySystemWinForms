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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //instantiate connection to server
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=inventory");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string login = "SELECT * FROM account WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";
                cmd = new MySqlCommand(login, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    dashboard.username.Text = txtUsername.Text;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Query Not Executable!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Exit?", "Close the Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
