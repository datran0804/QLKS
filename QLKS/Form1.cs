using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "dat" && txtPassword.Text == "123")
            {
                lblThongbao.Visible = false;
                fMain fMain = new fMain();
                this.Hide();
                fMain.Show();
            }
            else
            {
                lblThongbao.Visible=true;
                txtPassword.Clear();
            }
        }
    }
}
