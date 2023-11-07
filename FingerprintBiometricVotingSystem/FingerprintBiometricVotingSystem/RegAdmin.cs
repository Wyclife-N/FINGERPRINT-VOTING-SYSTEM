using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FingerprintBiometricVotingSystem
{
    public partial class RegAdmin : Form
    {
        public RegAdmin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        #region Create Admin
        private void CreateUser()
        {
            DbConnection.checkConnection();
            if (textBoxName.Text == "" || textBoxmail.Text == "" || textBoxpass.Text == "" || textBoxrepass.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Some field empty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (textBoxpass.Text != textBoxrepass.Text)
            {
                MessageBox.Show("Both password must be match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    DbConnection.con.Open();

                    string cb = "insert into AdminReg(Name,Username,Password,JoiningDate) VALUES ('" + textBoxName.Text + "','" + textBoxmail.Text + "','" + textBoxpass.Text + "','" + DateTime.Now.ToShortDateString() + "')";

                    cmd = new SqlCommand(cb);
                    cmd.Connection = DbConnection.con;
                    cmd.ExecuteReader();
                    DbConnection.con.Close();
                    MessageBox.Show("Account successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            textBoxmail.Text = "";
            textBoxName.Text = "";
            textBoxpass.Text = "";
            textBoxrepass.Text = "";
        }
    }
}
