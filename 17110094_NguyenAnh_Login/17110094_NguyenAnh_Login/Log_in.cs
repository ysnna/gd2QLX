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

namespace _17110094_NguyenAnh_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_LOGIN_Click(object sender, EventArgs e)
        {
            if (login() == 1)
            {
                if (chkUser.Checked == true)
                {
                    MainForm mf = new MainForm();
                    mf.ShowDialog();
                }
                else if (chkAdmin.Checked == true)
                {
                    HumanResource hm = new HumanResource();
                    hm.ShowDialog();
                }
                else MessageBox.Show("Please chose Who You Are to login", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else  MessageBox.Show("Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateControls();
            //CreateErrorProvider();
        }
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            Register rgis = new Register();
            rgis.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        void CreateControls()
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.IsBalloon = true;
            ToolTip1.AutoPopDelay = 5000;
            ToolTip1.InitialDelay = 600;

            ToolTip1.ReshowDelay = 500;
            ToolTip1.ToolTipIcon = ToolTipIcon.Info;
            ToolTip1.ToolTipTitle = "Login";
            ToolTip1.SetToolTip(this.txtUsername, "Nhap ky tu");
            ToolTip1.SetToolTip(this.txtPassword, "Nhap ky tu");
        }
        void CreateErrorProvider()
        {
            ErrorProvider error = new ErrorProvider();
            error.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            TextBox txt = new TextBox();
            txt.Name = "txtUsername";
            //error.SetError(txt, "Blank is not valid");
            this.Controls.Add(txt);
        }
        ErrorProvider errorProvider = new ErrorProvider();
        private void txtUsername_Validated(object sender, EventArgs e)
        {
            if(txtUsername.Text!="")
            {
                errorProvider.SetError(this.txtUsername, "");
            }
            else
            {
                errorProvider.SetError(this.txtUsername, "Password is required");
            }
        }
        public int login()
        {
            int id = 0;
            if (IsNumber(txtUsername.Text))
            {
                id = int.Parse(txtUsername.Text);
            }
            int flag = 0;
            MY_DB db = new MY_DB();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Login where (Id=@id and password=@pass) or (username=@user and password=@pass)", db.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            da.SelectCommand = cmd;
            da.Fill(dt);
            int count = dt.Rows.Count;
            if (count > 0)
            {
                int userid = Convert.ToInt16(dt.Rows[0][0].ToString());
                GlobalID.SetGlobalUserID(userid);
                flag = 1;
            }
            return flag;
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            chkUser.Checked = false;
        }
        private void chkUser_CheckedChanged(object sender, EventArgs e)
        {
            chkAdmin.Checked = false;
        }
    }
}