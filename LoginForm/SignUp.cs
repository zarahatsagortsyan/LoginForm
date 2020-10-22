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
    public partial class SignUp_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\AccountBase.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void SignUp_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            frLogIn f = new frLogIn();
            f.Show();
        }

        private void bt_LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg;*.PNG)|*.JPG;*.PNG| All file(* . *) |*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(op.FileName);
            }
        }

        private void InfoClean()
        {
            txtMobile.Text = "";
            txFname.Text = "";
            txLname.Text = "";
            txEmail.Text = "";
            txAddress.Text = "";
            txUname.Text = "";
            txPass.Text = "";
        }
        private bool checkSpace(string text)
        {
            if (text.Contains(" "))
            {
                return true;
            }
            else
                return false;
        }
        private bool IsValid()
        {
            if (txFname.Text == string.Empty || txLname.Text == string.Empty || txEmail.Text == string.Empty || txUname.Text == string.Empty || txPass.Text == string.Empty)

            {
                MessageBox.Show("Fill required information.", "Exception of required information։", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        private bool checkMobile(string text)
        {
            if (txtMobile.Text.Contains("-"))
            {
                return true;
            }
            else
                return false;
        }
        private bool checkEmail(string text)
        {
            if (text.Contains("@"))
            {
                return true;
            }
            else
                return false;
        }

        private void Protection()
        {
            if (checkSpace(txFname.Text))
            {
                txFname.Text = txFname.Text.Replace(" ", "");
            }
            if (checkSpace(txLname.Text))
            {
                txLname.Text = txLname.Text.Replace(" ", "");
            }
            if (checkSpace(txEmail.Text))
            {
                txEmail.Text = txEmail.Text.Replace(" ", "");
            }
            if (checkSpace(txtMobile.Text))
            {
                txtMobile.Text = txtMobile.Text.Replace(" ", "");
            }
            if (checkMobile(txtMobile.Text))
            {
                txtMobile.Text = txtMobile.Text.Replace("-", "");
            }
            if (checkMobile(txUname.Text))
            {
                txUname.Text = txUname.Text.Replace("-", "");
            }
            if (checkMobile(txPass.Text))
            {
                txPass.Text = txPass.Text.Replace("-", "");
            }
        }

        private void btsignUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void SignUp()
        {
            Protection();
            if (checkEmail(txEmail.Text) == false)
            {
                MessageBox.Show("Please enter a correct email address", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (IsValid())
                {
                    SqlCommand com = new SqlCommand("Insert into InfoTable Values (@fname, @lname,@address,@mobile,@email,@usname,@password)", con);
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@fname", txFname.Text);
                    com.Parameters.AddWithValue("@lname", txLname.Text);
                    com.Parameters.AddWithValue("@address", txAddress.Text);
                    com.Parameters.AddWithValue("@mobile", txtMobile.Text);
                    com.Parameters.AddWithValue("@email", txEmail.Text);
                    com.Parameters.AddWithValue("@usname", txUname.Text);
                    com.Parameters.AddWithValue("@password", txPass.Text);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("You seccessfully registered.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InfoClean();
                }
            }
        }

        private void btErase_Click(object sender, EventArgs e)
        {
            InfoClean();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txPass.UseSystemPasswordChar = false;
            }
            else
            {
                txPass.UseSystemPasswordChar = true;
            }
        }

        private void txPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SignUp();
            }
        }
    }
}
