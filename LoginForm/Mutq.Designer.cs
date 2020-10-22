namespace LoginForm
{
    partial class frLogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLink_Erase = new System.Windows.Forms.LinkLabel();
            this.lblLinkSugnUp = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBoxShow_Password = new System.Windows.Forms.CheckBox();
            this.btClose = new System.Windows.Forms.Button();
            this.lblLinkChangePassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txUsername
            // 
            this.txUsername.Location = new System.Drawing.Point(75, 77);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(168, 20);
            this.txUsername.TabIndex = 2;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(75, 139);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(168, 20);
            this.txPassword.TabIndex = 3;
            this.txPassword.UseSystemPasswordChar = true;
            this.txPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPassword_KeyPress);
            // 
            // btEnter
            // 
            this.btEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEnter.Location = new System.Drawing.Point(379, 105);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(67, 30);
            this.btEnter.TabIndex = 4;
            this.btEnter.Text = "Sign In";
            this.btEnter.UseVisualStyleBackColor = false;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sign in";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLink_Erase
            // 
            this.lblLink_Erase.AutoSize = true;
            this.lblLink_Erase.Location = new System.Drawing.Point(251, 78);
            this.lblLink_Erase.Name = "lblLink_Erase";
            this.lblLink_Erase.Size = new System.Drawing.Size(34, 13);
            this.lblLink_Erase.TabIndex = 10;
            this.lblLink_Erase.TabStop = true;
            this.lblLink_Erase.Text = "Erase";
            this.lblLink_Erase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_Erase_LinkClicked);
            // 
            // lblLinkSugnUp
            // 
            this.lblLinkSugnUp.AutoSize = true;
            this.lblLinkSugnUp.Location = new System.Drawing.Point(499, 239);
            this.lblLinkSugnUp.Name = "lblLinkSugnUp";
            this.lblLinkSugnUp.Size = new System.Drawing.Size(45, 13);
            this.lblLinkSugnUp.TabIndex = 11;
            this.lblLinkSugnUp.TabStop = true;
            this.lblLinkSugnUp.Text = "Sign Up";
            this.lblLinkSugnUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkSugnUp_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "If you want to create an account click \"Sign Up\"";
            // 
            // chkBoxShow_Password
            // 
            this.chkBoxShow_Password.AutoSize = true;
            this.chkBoxShow_Password.Location = new System.Drawing.Point(254, 142);
            this.chkBoxShow_Password.Name = "chkBoxShow_Password";
            this.chkBoxShow_Password.Size = new System.Drawing.Size(99, 17);
            this.chkBoxShow_Password.TabIndex = 13;
            this.chkBoxShow_Password.Text = "show password";
            this.chkBoxShow_Password.UseVisualStyleBackColor = true;
            this.chkBoxShow_Password.CheckedChanged += new System.EventHandler(this.chkBoxShow_Password_CheckedChanged);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(452, 105);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(67, 30);
            this.btClose.TabIndex = 14;
            this.btClose.Text = "Exit";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lblLinkChangePassword
            // 
            this.lblLinkChangePassword.AutoSize = true;
            this.lblLinkChangePassword.Location = new System.Drawing.Point(72, 162);
            this.lblLinkChangePassword.Name = "lblLinkChangePassword";
            this.lblLinkChangePassword.Size = new System.Drawing.Size(138, 13);
            this.lblLinkChangePassword.TabIndex = 11;
            this.lblLinkChangePassword.TabStop = true;
            this.lblLinkChangePassword.Text = "Want to change password?";
            this.lblLinkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkChangePassword_LinkClicked);
            // 
            // frLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(556, 260);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.chkBoxShow_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLinkChangePassword);
            this.Controls.Add(this.lblLinkSugnUp);
            this.Controls.Add(this.lblLink_Erase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblLink_Erase;
        private System.Windows.Forms.LinkLabel lblLinkSugnUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBoxShow_Password;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.LinkLabel lblLinkChangePassword;
    }
}

