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
    public partial class List : Form
    {
        Thread tc;

        string connectionStringList = @"Data Source=DESKTOP-FPEE1DQ;Initial Catalog=LoginSystem;Integrated Security=True;";
        public List()
        {
            InitializeComponent();
        }

        private void btnCloseLoginDirector_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tc = new Thread(closelist);
            tc.SetApartmentState(ApartmentState.STA);
            tc.Start();
        }

        void closelist (object obj)
        {
            Application.Run(new DirectorMenu());
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconl = new SqlConnection(connectionStringList))
            {
                sqlconl.Open();
                SqlDataAdapter sqlal = new SqlDataAdapter("Select * From Employees", sqlconl);
                DataTable sqldl = new DataTable();
                sqlal.Fill(sqldl);

                dgwList.DataSource = sqldl;
            }

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconl = new SqlConnection(connectionStringList))
            {
                sqlconl.Open();
                SqlDataAdapter sqlald = new SqlDataAdapter("DELETE from Employees where ID = '"+ txtboxIDList.Text +"'", sqlconl);
                DataTable sqldld = new DataTable();
                sqlald.Fill(sqldld);

                dgwList.DataSource = sqldld;
            }
        }

        private void btnListChange_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconl = new SqlConnection(connectionStringList))
            {
                sqlconl.Open();
                SqlDataAdapter sqlalc = new SqlDataAdapter("Update Employees SET Salary = '"+txtboxSalary.Text+"'Where ID = '"+txtboxIDChange.Text+"'", sqlconl);
                DataTable sqldlc = new DataTable();
                sqlalc.Fill(sqldlc);

                dgwList.DataSource = sqldlc;
            }
        }
    }
}
