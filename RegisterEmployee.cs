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
    public partial class RegisterEmployee : Form
    {
        Thread tc;
        string connectionStringR = @"Data Source=DESKTOP-FPEE1DQ;Initial Catalog=LoginSystem;Integrated Security=True;";
        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void btnCloseRegEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tc = new Thread(closeregemp);
            tc.SetApartmentState(ApartmentState.STA);
            tc.Start();
        }

        void closeregemp (object obj)
        {
            Application.Run(new DirectorMenu());
        }

        private void btnRegEmployee_Click(object sender, EventArgs e)
        {
            if (txtboxFirstNameEmployee.Text == "" || txtboxLastNameEmployee.Text == "" || txtboxProffesionEmployee.Text == "" || txtboxSalaryEmployee.Text == "")
            {
                MessageBox.Show("You missed some field. Please fill every field in the form.");
            }
            else
            {
                using (SqlConnection sqlconR = new SqlConnection(connectionStringR))
                {

                    sqlconR.Open();
                    SqlCommand sqlcmdR = new SqlCommand(@"EmployeesAdd", sqlconR);
                    sqlcmdR.CommandType = CommandType.StoredProcedure;
                    sqlcmdR.Parameters.AddWithValue("@Name", txtboxFirstNameEmployee.Text.Trim());
                    sqlcmdR.Parameters.AddWithValue("@Surename", txtboxLastNameEmployee.Text.Trim());
                    sqlcmdR.Parameters.AddWithValue("@Salary", txtboxSalaryEmployee.Text.Trim());
                    sqlcmdR.Parameters.AddWithValue("@Proffesion", txtboxProffesionEmployee.Text.Trim());
                    sqlcmdR.ExecuteNonQuery();
                    MessageBox.Show("Succesful Registration as Director");

                    Clear();
                }

                void Clear()
                {
                    txtboxFirstNameEmployee.Text = txtboxLastNameEmployee.Text = txtboxProffesionEmployee.Text = txtboxSalaryEmployee.Text = " ";

                }
            }
        }
    }
}
