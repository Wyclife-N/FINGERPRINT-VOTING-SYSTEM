using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;

namespace FingerprintBiometricVotingSystem
{
    public partial class Winner : Form
    {
        public Winner()
        {
            InitializeComponent();
        }

        #region fill to Datagrid view
        public void gridView()
        {
            SqlCommand cmd = new SqlCommand("select ElectionID as'Election ID', NumCandidates as'No. of Candidates',EndDate as'End Date',Winner as'Winner',NumVotes as'No. of Votes' From Winner", DbConnection.con);
            try
            {
                DbConnection.con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridViewEmployee.DataSource = dt;
                da.Update(dt);
                DbConnection.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void Winner_Load(object sender, EventArgs e)
        {
            gridView();
        }
    }
}
