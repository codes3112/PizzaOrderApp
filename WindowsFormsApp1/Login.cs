using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter a valid Username ");
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter a valid Password! ");
                txtUsername.Focus();
            }
            //string userName1, userPassword1;

            //userName1 = txtUsername.Text;
            //userPassword1 = txtPassword.Text;

            SqlConnection con = new SqlConnection
                (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30"); //User Instance=True;

            string query = "Select Count(*) From Users where Username='"+ txtUsername.Text.Trim() + "'and Password='" + txtPassword.Text.Trim()+"'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            //if (dt.Rows.Count == 1)
            {
                this.Hide();

                Main ss = new Main(txtUsername.Text);
                ss.Show();

            }
            else
            {
                MessageBox.Show("Please Check Your Username And Password");
            }




            //    DataSet ds = new DataSet("Login");

            //    foreach (DataRow dr in ds.Tables["Login"].Rows)
            //    {
            //        if (dr["Username"].ToString() == "userName1")

            //        {

            //            if (dr["Password"].ToString() == "userPassword1")
            //            {
            //                Login fs = new Login();//creating object of login form
            //                Main ss = new Main(); //creating object of main form

            //                fs.Hide();
            //                ss.Show();
            //                break;

            //            }
            //        }
            //        else
            //            MessageBox.Show("Please Check Your Username And Password");
            //    }
            


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Main ss = new Main(txtUsername.Text);
            ss.Show();
        }
    }
}


