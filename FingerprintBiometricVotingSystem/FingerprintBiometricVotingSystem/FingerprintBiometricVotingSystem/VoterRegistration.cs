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
using Business_Entities;
using DAL;

namespace FingerprintBiometricVotingSystem
{
    public partial class VoterRegistration : Form
    {
        string imageLocation = "";

        #region Add Staff Members
        public static List<Byte[]> prints = new List<byte[]>();
        Bus_Person busper = new Bus_Person();
        Dal_Person dalper = new Dal_Person();


        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate()
            {
                Template = template;
                if (Template != null)
                    MessageBox.Show("The Fingerprint Template is Saved.", "Fingerprint Enrollment");
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }
        private DPFP.Template Template;
        delegate void Function();

        #endregion

        public VoterRegistration()
        {
            InitializeComponent();
        }

        #region fill to Datagrid view
        public void gridView()
        {
            SqlCommand cmd = new SqlCommand("select EmpCNIC as'Voter ID', Name as'Name',DOB as'Date of Birth',Gender as'Gender',PhoneNumber as'Phone Number' From VoterReg", DbConnection.con);
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

        #region byte to image
        void image()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                string sql = "SELECT Picture FROM VoterReg WHERE EmpCNIC='" + IdUpdate.Text + "';";
                if (DbConnection.con.State != ConnectionState.Open)
                    DbConnection.con.Open();
                cmd = new SqlCommand(sql, DbConnection.con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
                    if (img == null)
                        pictureBoxPicture.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBoxPicture.Image = Image.FromStream(ms);
                    }
                }

                DbConnection.con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (prints.Count != 4)
            {
                MessageBox.Show("Please Enter Your Fingerprints");
            }
            else
            {
                foreach (Byte[] b in prints)
                {
                    saveprints(b);
                }
                
                prints.Clear();

                DbConnection.con.Close();
                lblmsg.Text = "";

            }

            //if (prints.Count != 0)
            //{
            //    foreach (Byte[] b in prints)
            //    {
            //        saveprints(b);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please Enter Your Finger Prints");
            //}

            if (txtName.Text == "" || txtPhone.Text == "" || txtVoterID.Text == "")
            {
                Verification.Input();
            }
            else if (imageLocation == "")
            {
                Verification.Picture();
            }

            else
            {
                SqlCommand cmdChk = new SqlCommand("select EmpCNIC from VoterReg where EmpCNIC ='" + txtVoterID.Text + "';", DbConnection.con);
                SqlParameter param = new SqlParameter();
                if (DbConnection.con.State != ConnectionState.Open)
                {
                    DbConnection.con.Open();
                }
                param.Value = this.txtVoterID.Text;
                cmdChk.Parameters.Add(param);
                SqlDataReader read = cmdChk.ExecuteReader();
                if (read.HasRows)
                {
                    DbConnection.con.Close();
                    Verification.Duplicate();
                }
                else
                {
                    try
                    {
                        DbConnection.con.Close();
                        if (DbConnection.con.State != ConnectionState.Open)
                        {
                            DbConnection.con.Open();
                        }
                        byte[] image = null;
                        FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        image = br.ReadBytes((int)fs.Length);
                        //////////////////////////////////////////////////////////////////////////////
                        SqlCommand cmd = new SqlCommand();
                        //cmd.Connection = DbConnection.con;

                        string cb = "insert into VoterReg(EmpCNIC,Name,DOB,Gender,PhoneNumber,Picture,Finger) VALUES ('" + txtVoterID.Text + "','" + txtName.Text + "','" + txtDOB.Text + "','" + cmbGender.Text + "','" + txtPhone.Text + "','" + txtPic.Text + "','" + image + "')";

                        cmd = new SqlCommand(cb);
                        cmd.Connection = DbConnection.con;
                        cmd.ExecuteReader();

                        Verification.Save();
                        DbConnection.con.Close();
                        gridView();
                        reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            EnrollmentForm rn = new EnrollmentForm();
            rn.OnTemplate += this.OnTemplate;
            rn.ShowDialog();
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

        private void saveprints(Byte[] array)
        {
            DbConnection.checkConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Finger (EmpCNIC,Finger)values(@cnic,@img)", DbConnection.con);

                cmd.Parameters.Add(new SqlParameter("@cnic", txtVoterID.Text));
                cmd.Parameters.Add(new SqlParameter("@img", array));
                if (DbConnection.con.State == System.Data.ConnectionState.Closed)
                {
                    DbConnection.con.Open();
                }
                cmd.ExecuteNonQuery();
                lblmsg.Text = "";
                lblmsg.ForeColor = System.Drawing.Color.Green;
                lblmsg.Text = "Finger Saved!";
                //MessageBox.Show("Finger Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VoterRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            // CHECK AND UN-COMMENT IT LATER

            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void VoterRegistration_Load(object sender, EventArgs e)
        {
            gridView();
            VoterId();
        }

        private void dataGridViewEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridViewEmployee.SelectedRows[0];
            IdUpdate.Text = dr.Cells[0].Value.ToString();
            txtName.Text = dr.Cells[1].Value.ToString();
            txtDOB.Text = dr.Cells[1].Value.ToString();
            cmbGender.Text = dr.Cells[4].Value.ToString();
            txtPhone.Text = dr.Cells[5].Value.ToString();
            //txtEmail.Text = dr.Cells[6].Value.ToString();
            //txtPhone.Text = dr.Cells[7].Value.ToString();
            //comboBoxjobType.Text = dr.Cells[8].Value.ToString();
            //comboBoxempType.Text = dr.Cells[9].Value.ToString();
        }

        public void reset()
        {
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPic.Text = string.Empty;
            pictureBoxPicture.Image = null;
            VoterId();
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

        private void VoterId()
        {
            txtVoterID.Text = "90T5B" + GetUniqueKey(10);
        }

    }
}
