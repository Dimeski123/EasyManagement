using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LoginSistem
{
    public partial class Register : Form
    {
        Thread tc;
        Thread tr;
        string connectionStringD = @"Data Source=DESKTOP-FPEE1DQ;Initial Catalog=LoginSystem;Integrated Security=True;";
        public Register()
        {
            InitializeComponent();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            tc = new Thread(closeregister);
            tc.SetApartmentState(ApartmentState.STA);
            tc.Start();
        }
        private void closeregister (object obj)
        {
            Application.Run(new Login());
        }

        private void txtboxFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtboxFirstName.Text == "" || txtboxLastName.Text == "" || txtboxUserNameReg.Text == "" || txtbocPasswordReg.Text == "")
            {
                MessageBox.Show("You missed some field. Please fill every field in the form.");
            }
            else
            {
                using (SqlConnection sqlconD = new SqlConnection(connectionStringD))
                {
                        
                    sqlconD.Open();
                    SqlCommand sqlcmdD = new SqlCommand(@"DirectorAdd", sqlconD);
                    sqlcmdD.CommandType = CommandType.StoredProcedure;
                    sqlcmdD.Parameters.AddWithValue("@Name", txtboxFirstName.Text.Trim());
                    sqlcmdD.Parameters.AddWithValue("@Surename", txtboxLastName.Text.Trim());
                    sqlcmdD.Parameters.AddWithValue("@Username", txtboxUserNameReg.Text.Trim());
                    sqlcmdD.Parameters.AddWithValue("@Password", txtbocPasswordReg.Text.Trim());
                    sqlcmdD.ExecuteNonQuery();
                    MessageBox.Show("Succesful Registration as Director");
                    this.Close();
                    Thread tr = new Thread(closeregister);
                    tr.SetApartmentState(ApartmentState.STA);
                    tr.Start();

                    Clear();
                }
            }
            void Clear ()
            {
                txtboxFirstName.Text = txtboxLastName.Text = txtboxUserNameReg.Text = txtbocPasswordReg.Text = " ";
            }
        }
    }
}
