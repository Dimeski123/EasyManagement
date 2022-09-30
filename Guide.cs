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
    public partial class Guide : Form
    {
        Thread tc;
        public Guide()
        {
            InitializeComponent();
        }

        private void btnCloseReg_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tc = new Thread(closeguide);
            tc.SetApartmentState(ApartmentState.STA);
            tc.Start();
        }

        void closeguide (object obj)
        {
            Application.Run(new Form1());
        }
    }
}
