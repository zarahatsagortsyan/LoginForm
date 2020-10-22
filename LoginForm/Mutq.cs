using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LoginForm
{
    public partial class frLogIn : Form
    {
        public frLogIn()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            Enter_Main();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            SignUp_Form su = new SignUp_Form();
            this.Hide();
            su.Show();
        }

        private void lblLink_Erase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txUsername.Clear();
            txPassword.Clear();
            chkBoxShow_Password.Checked = false;
        }

        private void lblLinkSugnUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp_Form su = new SignUp_Form();
            this.Hide();
            su.Show();
        }

        private void chkBoxShow_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShow_Password.Checked==true)
            {
                txPassword.UseSystemPasswordChar = false; 
            }
            else
            {
                txPassword.UseSystemPasswordChar = true;
            }
        }


        private void txPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                Enter_Main();
            }
        }

        public void Enter_Main()
        {
            Main_Form mn = new Main_Form();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\AccountBase.mdf;Integrated Security=True;Connect Timeout=30");
            string sql="Select * from InfoTable where UserName='"+txUsername.Text.Trim()+"' and Password='"+txPassword.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(sql,con);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            if (tb.Rows.Count!=0)
            {
                this.Hide();
                mn.Show();
            }
            else
            {
                txUsername.Clear();
                txPassword.Clear();
                chkBoxShow_Password.Checked = false;
                MessageBox.Show("Wrong username or password!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void lblLinkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormChangePassword cp= new FormChangePassword();
            this.Hide();
            cp.Show();
        }
    }
}

