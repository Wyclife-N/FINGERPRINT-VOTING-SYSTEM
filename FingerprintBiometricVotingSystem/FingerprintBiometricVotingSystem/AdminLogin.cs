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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        #region LogIN
        private void Login()
        {
            DbConnection.checkConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from AdminReg where Username='" + this.textBoxUserName.Text + "' AND Password='" + this.textBoxPassword.Text + "';", DbConnection.con);
                SqlDataReader mreader;
                DbConnection.con.Open();
                mreader = cmd.ExecuteReader();
                int count = 0;
                while (mreader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    Verification.InvalidUser();
                }
                DbConnection.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcom = new Welcome();
            welcom.ShowDialog();
        }
    }
}
