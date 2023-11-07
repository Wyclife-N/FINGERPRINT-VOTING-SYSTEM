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
    public partial class Main : Form
    {
        VoterRegistration vr = new VoterRegistration();

        public Main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newVoterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbConnection.checkConnection();
            vr.BringToFront();
            //emp.MdiParent = this;
            vr.ShowDialog();
            vr.WindowState = FormWindowState.Maximized;
        }

        private void addCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCandidate AddCan = new AddCandidate();
            AddCan.ShowDialog();
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

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void resultsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Collation cola = new Collation();
            cola.ShowDialog();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Winner win = new Winner();
            win.ShowDialog();
        }

        private void StudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegAdmin reg = new RegAdmin();
            reg.ShowDialog();
        }

        

      
    }
}
