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
    public partial class Form1 : Form
    {
        Thread td;
        Thread tg;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.Close();
            td = new Thread(directorlogin);
            td.SetApartmentState(ApartmentState.STA);
            td.Start();
        }
        private void directorlogin(object obj)
        {
            Application.Run(new Login());
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tg = new Thread(openguide);
            tg.SetApartmentState(ApartmentState.STA);
            tg.Start();
        }

        void openguide (object obj)
        {
            Application.Run(new Guide());
        }
    }
}
