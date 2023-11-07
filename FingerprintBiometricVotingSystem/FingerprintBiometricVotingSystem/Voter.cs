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
    public partial class Voter : Form
    {
        public Voter()
        {
            InitializeComponent();
        }

        private void voteMenuItem1_Click(object sender, EventArgs e)
        {
            VerificationForm vrfom = new VerificationForm();
            vrfom.ShowDialog();
            //this.Hide();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome wel = new Welcome();
            wel.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            day.Text = System.DateTime.Now.ToString("dddd");
            date.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
            timeNow.Text = System.DateTime.Now.ToString("HH:mm:ss");
        }

        private void Voter_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
