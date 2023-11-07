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
    public partial class Collation : Form
    {
        public Collation()
        {
            InitializeComponent();
        }

        private void Collation_Load(object sender, EventArgs e)
        {
            lblmsg.Text = "";

            gridView();
            ElectionID();

            DbConnection.checkConnection();
            DbConnection.con.Open();

            string strcom = "select MAX(ID) from Election";
            SqlDataAdapter daDetails = new SqlDataAdapter(strcom, DbConnection.con);
            DataSet dsDetails = new DataSet();
            daDetails.Fill(dsDetails);

            if (dsDetails.Tables[0].Rows.Count > 0)
            {
                //
             txtNoCandidate.Text = dsDetails.Tables[0].Rows[0][0].ToString();

            }

            NameNvote();
        }

        public void NameNvote()
        {
            DbConnection.checkConnection();
            DbConnection.con.Open();

            string strcom = "select CandidateName,Vote from Election";
            SqlDataAdapter daDetails = new SqlDataAdapter(strcom, DbConnection.con);
            DataSet dsDetails = new DataSet();
            daDetails.Fill(dsDetails);

            if (dsDetails.Tables[0].Rows.Count > 0)
            {
                try
                {
                    //
                    txtVote1.Text = dsDetails.Tables[0].Rows[0][1].ToString();
                    txtName1.Text = dsDetails.Tables[0].Rows[0][0].ToString();
                    txtVote2.Text = dsDetails.Tables[0].Rows[1][1].ToString();
                    txtName2.Text = dsDetails.Tables[0].Rows[1][0].ToString();
                    txtVote3.Text = dsDetails.Tables[0].Rows[2][1].ToString();
                    txtName3.Text = dsDetails.Tables[0].Rows[2][0].ToString();
                }
                catch (Exception)
                {
                    lblmsg.Text = "Votes for atleast 3 Candidates is recommended";
                }

                

            }

            int aa, bb, cc;

            if (txtVote1.Text == "" || txtVote2.Text == "" || txtVote3.Text == "")
            {
                //
            }
            else
            {
                aa = int.Parse(txtVote1.Text);
                bb = int.Parse(txtVote2.Text);
                cc = int.Parse(txtVote3.Text);

                if (aa > bb && aa > cc)
                {
                    txtNoOfVotes.Text = aa.ToString();
                    txtWinner.Text = txtName1.Text;
                }
                else if (bb > aa && bb > cc)
                {
                    txtNoOfVotes.Text = bb.ToString();
                    txtWinner.Text = txtName2.Text;
                }
                else if (cc > aa && cc > bb)
                {
                    txtNoOfVotes.Text = cc.ToString();
                    txtWinner.Text = txtName3.Text;
                }

            }
            

            DbConnection.con.Close();
        }

        #region fill to Datagrid view
        public void gridView()
        {
            SqlCommand cmd = new SqlCommand("select ID as'Candidates ID', CandidateName as'Candidate Name', Vote as'Number of Votes' From Election", DbConnection.con);
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

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        private void ElectionID()
        {
            txtElectionID.Text = GetUniqueKey(6);
        }

        private void dataGridViewEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridViewEmployee.SelectedRows[0];
            txtNoCandidate.Text = dr.Cells[1].Value.ToString();
            //txtName.Text = dr.Cells[1].Value.ToString();
            //txtDOB.Text = dr.Cells[1].Value.ToString();
            //cmbGender.Text = dr.Cells[4].Value.ToString();
            //txtPhone.Text = dr.Cells[5].Value.ToString();
            //txtEmail.Text = dr.Cells[6].Value.ToString();
            //txtPhone.Text = dr.Cells[7].Value.ToString();
            //comboBoxjobType.Text = dr.Cells[8].Value.ToString();
            //comboBoxempType.Text = dr.Cells[9].Value.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DbConnection.checkConnection();
            if (txtWinner.Text == "" || txtNoOfVotes.Text == "" || txtVote1.Text == "" || txtName2.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Some field empty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    DbConnection.con.Open();

                    string cb = "insert into Winner(ElectionID,NumCandidates,EndDate,Winner,NumVotes) VALUES ('" + txtElectionID.Text + "','" + txtNoCandidate.Text + "','" + dateTimePicker1.Text + "','" + txtWinner.Text + "','" + txtNoOfVotes.Text + "')";

                    cmd = new SqlCommand(cb);
                    cmd.Connection = DbConnection.con;
                    cmd.ExecuteReader();
                    DbConnection.con.Close();
                    MessageBox.Show("Winner Added Successfully", "Biometric Voting System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    //Main main = new Main();
                    //main.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Reset()
        {
            txtWinner.Text = "";
            txtNoOfVotes.Text = "";
            txtNoCandidate.Text = "";
            txtElectionID.Text = "";
          
        }

    
    }
}
