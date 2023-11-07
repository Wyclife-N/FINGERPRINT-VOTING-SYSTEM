using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FingerprintBiometricVotingSystem
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            Voter vota = new Voter();
            this.Hide();
            vota.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin admilog = new AdminLogin();
            this.Hide();
            admilog.ShowDialog();
            

            //Main main = new Main();
            //main.ShowDialog();
            //this.Close();
        }
    }
}
