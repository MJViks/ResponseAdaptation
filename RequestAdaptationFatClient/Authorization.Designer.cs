namespace RequestAdaptationFatClient
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.btnLogin = new System.Windows.Forms.Button();
            this.llReg = new System.Windows.Forms.LinkLabel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pReg = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.llBack = new System.Windows.Forms.LinkLabel();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbLoginReg = new System.Windows.Forms.TextBox();
            this.tbPassRegRe = new System.Windows.Forms.TextBox();
            this.tbPassReg = new System.Windows.Forms.TextBox();
            this.lblErr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pView = new System.Windows.Forms.Panel();
            this.lblRoleView = new System.Windows.Forms.Label();
            this.lblLoginView = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.pReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(131, 313);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 28);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Вход";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // llReg
            // 
            this.llReg.AutoSize = true;
            this.llReg.Location = new System.Drawing.Point(130, 343);
            this.llReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llReg.Name = "llReg";
            this.llReg.Size = new System.Drawing.Size(89, 19);
            this.llReg.TabIndex = 1;
            this.llReg.TabStop = true;
            this.llReg.Text = "Регистрация";
            this.llReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(79, 190);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(190, 24);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(77, 251);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(190, 24);
            this.tbPass.TabIndex = 3;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // pReg
            // 
            this.pReg.Controls.Add(this.label5);
            this.pReg.Controls.Add(this.label4);
            this.pReg.Controls.Add(this.label3);
            this.pReg.Controls.Add(this.pictureBox2);
            this.pReg.Controls.Add(this.llBack);
            this.pReg.Controls.Add(this.btnReg);
            this.pReg.Controls.Add(this.tbLoginReg);
            this.pReg.Controls.Add(this.tbPassRegRe);
            this.pReg.Controls.Add(this.tbPassReg);
            this.pReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReg.Location = new System.Drawing.Point(0, 0);
            this.pReg.Name = "pReg";
            this.pReg.Size = new System.Drawing.Size(326, 459);
            this.pReg.TabIndex = 7;
            this.pReg.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Повторите пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Логин";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RequestAdaptationFatClient.Properties.Resources.LantaGroup;
            this.pictureBox2.Location = new System.Drawing.Point(53, 80);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // llBack
            // 
            this.llBack.AutoSize = true;
            this.llBack.Location = new System.Drawing.Point(157, 419);
            this.llBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llBack.Name = "llBack";
            this.llBack.Size = new System.Drawing.Size(47, 19);
            this.llBack.TabIndex = 8;
            this.llBack.TabStop = true;
            this.llBack.Text = "Назад";
            this.llBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlBack_LinkClicked);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(120, 381);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(116, 28);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.TbReg_Click);
            // 
            // tbLoginReg
            // 
            this.tbLoginReg.Location = new System.Drawing.Point(82, 197);
            this.tbLoginReg.Margin = new System.Windows.Forms.Padding(4);
            this.tbLoginReg.Name = "tbLoginReg";
            this.tbLoginReg.Size = new System.Drawing.Size(190, 24);
            this.tbLoginReg.TabIndex = 6;
            // 
            // tbPassRegRe
            // 
            this.tbPassRegRe.Location = new System.Drawing.Point(84, 316);
            this.tbPassRegRe.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassRegRe.Name = "tbPassRegRe";
            this.tbPassRegRe.Size = new System.Drawing.Size(190, 24);
            this.tbPassRegRe.TabIndex = 5;
            this.tbPassRegRe.UseSystemPasswordChar = true;
            // 
            // tbPassReg
            // 
            this.tbPassReg.Location = new System.Drawing.Point(84, 254);
            this.tbPassReg.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassReg.Name = "tbPassReg";
            this.tbPassReg.Size = new System.Drawing.Size(190, 24);
            this.tbPassReg.TabIndex = 4;
            this.tbPassReg.UseSystemPasswordChar = true;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(95, 367);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 19);
            this.lblErr.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RequestAdaptationFatClient.Properties.Resources.LantaGroup;
            this.pictureBox1.Location = new System.Drawing.Point(53, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pView
            // 
            this.pView.Controls.Add(this.lblRoleView);
            this.pView.Controls.Add(this.lblLoginView);
            this.pView.Controls.Add(this.pictureBox3);
            this.pView.Controls.Add(this.btnOK);
            this.pView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pView.Location = new System.Drawing.Point(0, 0);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(326, 459);
            this.pView.TabIndex = 14;
            this.pView.Visible = false;
            // 
            // lblRoleView
            // 
            this.lblRoleView.AutoSize = true;
            this.lblRoleView.Location = new System.Drawing.Point(78, 224);
            this.lblRoleView.Name = "lblRoleView";
            this.lblRoleView.Size = new System.Drawing.Size(43, 19);
            this.lblRoleView.TabIndex = 12;
            this.lblRoleView.Text = "Роль:";
            // 
            // lblLoginView
            // 
            this.lblLoginView.AutoSize = true;
            this.lblLoginView.Location = new System.Drawing.Point(78, 174);
            this.lblLoginView.Name = "lblLoginView";
            this.lblLoginView.Size = new System.Drawing.Size(55, 19);
            this.lblLoginView.TabIndex = 10;
            this.lblLoginView.Text = "Логин: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RequestAdaptationFatClient.Properties.Resources.LantaGroup;
            this.pictureBox3.Location = new System.Drawing.Point(53, 80);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(239, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(118, 414);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 28);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 459);
            this.Controls.Add(this.pView);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.pReg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.llReg);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 498);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(342, 498);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.pReg.ResumeLayout(false);
            this.pReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pView.ResumeLayout(false);
            this.pView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llReg;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pReg;
        private System.Windows.Forms.LinkLabel llBack;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tbLoginReg;
        private System.Windows.Forms.TextBox tbPassRegRe;
        private System.Windows.Forms.TextBox tbPassReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Panel pView;
        private System.Windows.Forms.Label lblRoleView;
        private System.Windows.Forms.Label lblLoginView;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnOK;
    }
}

