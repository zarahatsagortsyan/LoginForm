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
    public partial class FormChangePassword : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\AccountBase.mdf;Integrated Security=True;Connect Timeout=30");
        public FormChangePassword()
        {
            InitializeComponent();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frLogIn f = new frLogIn();
            f.Show();
        }

        private void btConfirmPassword_Click(object sender, EventArgs e)
        {
            confirm();
        }

        private void clean()
        {
            txUsName.Text = "";
            txOldPassword.Text = "";
            txNewPassword.Text = "";
            txNewPasswordConf.Text = "";
        }

        private void confirm()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from InfoTable where UserName='" + txUsName.Text.Trim() + "' and Password='" + txOldPassword.Text.Trim() + "'", con);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            if (tb.Rows.Count != 0)
            {
                if (txNewPassword.Text == txNewPasswordConf.Text)
                {
                    SqlDataAdapter sda2 = new SqlDataAdapter("Update InfoTable set Password='" + txNewPassword.Text + "' where UserName='" + txUsName.Text + "' and Password='" + txOldPassword.Text + "'", con);
                    MessageBox.Show("You successfully changed your password.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sda2.Fill(tb);
                }
                else
                {
                    MessageBox.Show("Incorect username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clean();
            }
            else
            {
                clean();
                MessageBox.Show("Incorect username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txNewPasswordConf_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                confirm();
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                txOldPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txOldPassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                txNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txNewPasswordConf.UseSystemPasswordChar = false;
            }
            else
            {
                txNewPasswordConf.UseSystemPasswordChar = true;
            }
        }

        private void FormChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            frLogIn f = new frLogIn();
            f.Show();
        }
    }
}
