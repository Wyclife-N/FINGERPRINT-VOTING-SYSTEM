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
    public partial class Voting : Form
    {
        public Voting()
        {
            InitializeComponent();
            
        }
        public void refreshdata()
        {
            DataRow dr;


            DbConnection.checkConnection();
            DbConnection.con.Open();
            SqlCommand cmd = new SqlCommand("select * from CandidateReg", DbConnection.con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Candidate--" };
            dt.Rows.InsertAt(dr, 0);

            comboBox1.ValueMember = "ID";

            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = dt;

            DbConnection.con.Close();

        }

        private void Voting_Load(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                    DbConnection.checkConnection();
                    DbConnection.con.Open();

                    string strcom = "select Name,Image from CandidateReg where Name='" + comboBox1.Text + "'";
                    SqlDataAdapter daDetails = new SqlDataAdapter(strcom, DbConnection.con);
                    DataSet dsDetails = new DataSet();
                    daDetails.Fill(dsDetails);

                    if (dsDetails.Tables[0].Rows.Count > 0)
                    {
                        //
                        txtImg.Text = dsDetails.Tables[0].Rows[0][1].ToString();

                        pictureBox1.Image = new Bitmap(txtImg.Text);

                    }

                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //private bool checkvoterid()
        //{
        //    bool flag = true;
        //    DbConnection.checkConnection();
        //    DbConnection.con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Parameters.AddWithValue("@voterid", txtVoterID.Text);
        //    cmd.CommandText = "select * from Voted where VoterID=@voterid";
        //    cmd.Connection = DbConnection.con;
        //    SqlDataReader rd = cmd.ExecuteReader();
        //    while (rd.Read())
        //    {
        //        if (rd["VoterID"].ToString() == txtVoterID.Text)
        //        {
        //            flag = false;
        //            break;

        //        }
        //    }
        //    if (flag == false)
        //        return true;
        //    else
        //        return false;
        //}

        private void btnVote_Click(object sender, EventArgs e)
        {

            try
            {

                DbConnection.checkConnection();
                DbConnection.con.Open();

                string strcom = "select * from Voted where VoterID='" + txtVoterID.Text + "'";
                SqlDataAdapter daDetails = new SqlDataAdapter(strcom, DbConnection.con);
                DataSet dsDetails = new DataSet();
                daDetails.Fill(dsDetails);

                if (dsDetails.Tables[0].Rows.Count > 0)
                {
                    //
                    lblmsg.Text = "Sorry, you can not vote twice";
                    lblmsg.ForeColor = System.Drawing.Color.Red;

                }
                else
                {
                    lblmsg.Text = "YOU CAN VOTE NOW";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                }


            }
            catch (Exception ex)
            {
                lblmsg.Text = "Sorry, Error occur";
                lblmsg.ForeColor = System.Drawing.Color.Red;
                //MessageBox.Show(ex.Message);

            }
            ///////////////////////////////////////////////


            //if (checkvoterid() == true)
            //{
            //    lblmsg.Text = "you are not authorized to vote twice";
            //    lblmsg.ForeColor = System.Drawing.Color.Red;

            //}

            //DbConnection.checkConnection();
            //DbConnection.con.Open();
            //string query = "select * from Election where CandidateName=@cand_name";
            //SqlCommand com = new SqlCommand(query, DbConnection.con);
            //com.Parameters.AddWithValue("@cand_name", comboBox1.Text);

            //SqlDataReader dr;
            //dr = com.ExecuteReader();


            //if (dr.HasRows)
            //{
            //    dr.Read();

            //    update();
            //}
            //else
            //{               

            DbConnection.checkConnection();
            DbConnection.con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DbConnection.con;
            cmd.Parameters.AddWithValue("@cand_name", comboBox1.Text);
            //cmd.Parameters.AddWithValue("@matric_nu", Session["matric_no"].ToString());
            //cmd.Parameters.AddWithValue("@vote", 1);
            cmd.CommandText = "insert into Election(CandidateName) values(@cand_name)";
            cmd.ExecuteNonQuery();

            DbConnection.checkConnection();
            DbConnection.con.Open();
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = DbConnection.con;
            cmm.Parameters.AddWithValue("@voterID", txtVoterID.Text);
            //cmd.Parameters.AddWithValue("@matric_nu", Session["matric_no"].ToString());
            //cmd.Parameters.AddWithValue("@vote", 1);
            cmm.CommandText = "insert into Voted(VoterID) values(@voterID)";
            cmm.ExecuteNonQuery();
            //    //

                    DbConnection.checkConnection();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = DbConnection.con;
                    //cmd2.CommandType = CommandType.Text;
                    SqlCommand cmdUpdate = new SqlCommand("update Election set Vote = Vote+1 where CandidateName=@candi_name", DbConnection.con);
                    cmdUpdate.Parameters.AddWithValue("@candi_name", comboBox1.Text);
                    DbConnection.con.Open();

                    int i = cmdUpdate.ExecuteNonQuery();

                    if (i >= 0)
                    {
                        VerificationForm vrfom = new VerificationForm();
                        vrfom.ShowDialog();
                        this.Hide();
                    }
                    DbConnection.con.Close();

                }

            //}
        public void update()
        {
            DbConnection.checkConnection();
            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = DbConnection.con;
            //cmd2.CommandType = CommandType.Text;
            DbConnection.con.Open();
            SqlCommand cmdUpdate = new SqlCommand("update Election set Vote = Vote+1 where CandidateName=@cand_name", DbConnection.con);
            cmdUpdate.Parameters.AddWithValue("@cand_name", comboBox1.Text);
            

            int i = cmdUpdate.ExecuteNonQuery();

            if (i >= 0)
            {
                lblmsg.Text = "Thankyou, you have cast your vote.";
                lblmsg.ForeColor = System.Drawing.Color.Green;

            }
            //DbConnection.con.Close();
        }
        }
    }
