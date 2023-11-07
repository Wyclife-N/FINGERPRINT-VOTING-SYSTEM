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
    public partial class AddCandidate : Form
    {
        string imageLocation = "";

        public AddCandidate()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog pic = new OpenFileDialog();
            pic.Filter = "JPG Files|*.jpg|PNG Files|*.png";
            if (pic.ShowDialog() == DialogResult.OK)
            {
                imageLocation = pic.FileName.ToString();
                pictureBoxPicture.ImageLocation = imageLocation;
                //Image File Path
                txtPic.Text = pic.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Candidate();
        }

        #region Add Candidate
        private void Candidate()
        {
            DbConnection.checkConnection();
            if (txtAddress.Text == "" || txtName.Text == "" || txtPic.Text == "" || txtCandidateID.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Some field empty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //else if (textBoxpass.Text != textBoxrepass.Text)
            //{
            //    MessageBox.Show("Both password must be match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    DbConnection.con.Open();

                    string cb = "insert into CandidateReg(CandidateID,Name,Address,Image) VALUES ('" + txtCandidateID.Text + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtPic.Text + "')";

                    cmd = new SqlCommand(cb);
                    cmd.Connection = DbConnection.con;
                    cmd.ExecuteReader();
                    DbConnection.con.Close();
                    MessageBox.Show("Candidate Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        #endregion

        public void Reset()
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtPic.Text = "";
            pictureBoxPicture.Image = null;
            CandidateID();
        }

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

        private void CandidateID()
        {
           txtCandidateID.Text = GetUniqueKey(6);
        }

        private void AddCandidate_Load(object sender, EventArgs e)
        {
            CandidateID();
        }
    }
}
