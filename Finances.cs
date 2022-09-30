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
    public partial class Finances : Form
    {
        Thread tc;
        string connectionStringFinances = @"Data Source=DESKTOP-FPEE1DQ;Initial Catalog=LoginSystem;Integrated Security=True;";

        public Finances()
        {
            InitializeComponent();
        }

        private void btnCloseLoginDirector_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tc = new Thread(closefinances);
            tc.SetApartmentState(ApartmentState.STA);
            tc.Start();
        }

        void closefinances (object obj)
        {
            Application.Run(new DirectorMenu());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconf = new SqlConnection(connectionStringFinances))
            {
                sqlconf.Open();
                SqlDataAdapter sqlaf = new SqlDataAdapter("Select SUM(Salary) as Salary From Employees", sqlconf);
                DataTable sqldf = new DataTable();
                sqlaf.Fill(sqldf);

                dgwSalary.DataSource = sqldf;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SqlConnection sqlconf = new SqlConnection(connectionStringFinances))
            {
                sqlconf.Open();
                SqlDataAdapter sqlaf = new SqlDataAdapter("Update Balances SET Standing = Balance - (Select SUM(Salary) FROM Employees) - MounthlyExpenses;Select Standing as Balance From Balances", sqlconf);
                DataTable sqldf = new DataTable();
                sqlaf.Fill(sqldf);

                dgwBalance.DataSource = sqldf;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconF = new SqlConnection(connectionStringFinances))
            {

                sqlconF.Open();
                SqlDataAdapter sqlalc = new SqlDataAdapter("Update Balances SET Balance = '" + txtboxNewBalance.Text +"'", sqlconF);
                DataTable sqldlc = new DataTable();
                sqlalc.Fill(sqldlc);
                MessageBox.Show("Balance Changed");
                Clear();
            }
            void Clear()
            {
                txtboxNewBalance.Text = "";
            }
        }

        private void btnEnterExpenses_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconF = new SqlConnection(connectionStringFinances))
            {

                sqlconF.Open();
                SqlDataAdapter sqlalc = new SqlDataAdapter("Update Balances SET MounthlyExpenses = '" + txtboxExpenses.Text + "'", sqlconF);
                DataTable sqldlc = new DataTable();
                sqlalc.Fill(sqldlc);
                MessageBox.Show("MounthlyExpenses Changed");
                Clear();
            }
            void Clear()
            {
                txtboxExpenses.Text = "";
            }
        }
    }
}
