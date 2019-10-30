using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestAdaptationFatClient
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            if (MainForm.Login != String.Empty)
            {
                lblLoginView.Text = "Логин: \n\r" + MainForm.Login;
                lblRoleView.Text = "Роль: \n\r" + MainForm.Role;
                pView.Visible = true;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            llReg.Enabled = false;
            tbLogin.Enabled = false;
            tbPass.Enabled = false;
            this.Cursor = Cursors.AppStarting;
            Action action = () =>
            {
            Authoriz.Auth(tbLogin.Text, tbPass.Text);
            if (Authoriz.vhod)
            {
                MainForm.Login = tbLogin.Text;
                MainForm.Role = Authoriz.role;
                lblErr.Text = String.Empty;
                    this.Close();
            }
            else
            {
                tbLogin.Text = String.Empty;
                tbPass.Text = String.Empty;
                lblErr.Text = "Неверный логин или пароль! \n\r Попробуйте еще раз!";
            }
                btnLogin.Enabled = true;
                llReg.Enabled = true;
                this.Cursor = Cursors.Default;
                tbLogin.Enabled = true;
                tbPass.Enabled = true;
            };
            Invoke(action);
            
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblErr.Text = String.Empty;
            pReg.Visible = true;
            this.Text = "Регистрация";
        }

        private void LlBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblErr.Text = String.Empty;
            pReg.Visible = false;
            this.Text = "Авторизация";
        }

        private void TbReg_Click(object sender, EventArgs e)
        {

            llBack.Enabled = false;
            btnReg.Enabled = false;
            tbPassReg.Enabled = false;
            tbPassRegRe.Enabled = false;
            tbLoginReg.Enabled = false;
            this.Cursor = Cursors.AppStarting;
            Action action = () =>
            {
                MessageBox.Show(Registration.RegNewUser(tbLoginReg.Text, tbPassReg.Text, tbPassRegRe.Text, "UnknownUser"));
                llBack.Enabled = true;
                btnReg.Enabled = true;
                tbPassReg.Enabled = true;
                tbPassRegRe.Enabled = true;
                tbLoginReg.Enabled = true;
                pReg.Visible = false;
                tbPassReg.Text = String.Empty;
                tbPassRegRe.Text = String.Empty;
                tbLoginReg.Text = String.Empty;
                this.Cursor = Cursors.Default;
            };
            Invoke(action);
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainForm.Login == String.Empty) Application.Exit();
            
        }
    }
}
