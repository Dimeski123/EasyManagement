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

namespace LoginSistem
{
    public partial class DirectorMenu : Form
    {
        Thread tc;
        Thread tl;
        Thread tr;
        Thread tf;
        public DirectorMenu()
        {
            InitializeComponent();
        }

        private void btnCloseLoginDirector_Click(object sender, EventArgs e)
        {
            this.Close();
            tc = new Thread(closedirector);
            tc.SetApartmentState(ApartmentState.STA);
            tc.Start();
        }

        private void closedirector(object obj)
        {
            Application.Run(new Form1());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tl = new Thread(openlist);
            tl.SetApartmentState(ApartmentState.STA);
            tl.Start();
        }

        void openlist (object obj)
        {
            Application.Run(new List());
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tr = new Thread(openreg);
            tr.SetApartmentState(ApartmentState.STA);
            tr.Start();
        }

        void openreg (object obj)
        {
            Application.Run(new RegisterEmployee());
        }

        private void btnFinances_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tf = new Thread(openfinances);
            tf.SetApartmentState(ApartmentState.STA);
            tf.Start();
        }

        void openfinances(object obj)
        {
            Application.Run(new Finances());
        }
    }
}
