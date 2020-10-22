using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }


        
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
