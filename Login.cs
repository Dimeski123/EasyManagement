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

namespace LoginSistem
{
    public partial class Login : Form
    {
        Thread th;
        Thread td;
        Thread tl;

        string connectionStringDLog = @"Data Source=DESKTOP-FPEE1DQ;Initial Catalog=LoginSystem;Integrated Security=True;";
        public Login()
        {
            InitializeComponent();
        }

        private void lblOr_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(closethisform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void closethisform(object obj)
        {
            Application.Run(new Form1());
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            td = new Thread(openregister);
            td.SetApartmentState(ApartmentState.STA);
            td.Start();
        }

        private void openregister(object obj)
        {
            Application.Run(new Register());
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconDL = new SqlConnection(connectionStringDLog);
            SqlDataAdapter sqlaDL = new SqlDataAdapter("Select Count(*) From Directors where Username='" + txtboxUserNameLogin.Text + "' and Password='" + txtboxPasswordLoginDirector.Text + "'", sqlconDL);
            DataTable sqldDL = new DataTable();
            sqlaDL.Fill(sqldDL);
            if (sqldDL.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Welcome to your Dashboard");
                this.Close();
                tl = new Thread(login);
                tl.SetApartmentState(ApartmentState.STA);
                tl.Start();
            }
            else
            {
                MessageBox.Show("You entered wrong Username or Password. Please Try again.");
                Clear();
            }
        }

        public void login (Object obj)
        {
            Application.Run(new DirectorMenu());
        }
        void Clear()
        {
            txtboxUserNameLogin.Text = txtboxPasswordLoginDirector.Text = "";
        }
    }
}
