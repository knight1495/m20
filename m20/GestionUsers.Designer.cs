
namespace m20
{
    partial class GestionUsers
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
            this.lblMac = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRegis = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Location = new System.Drawing.Point(173, 82);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(37, 17);
            this.lblMac.TabIndex = 0;
            this.lblMac.Text = "MAC";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(173, 181);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(74, 17);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "HostName";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(433, 90);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(261, 176);
            this.txtHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHost.Name = "txtHost";
            this.txtHost.ReadOnly = true;
            this.txtHost.Size = new System.Drawing.Size(100, 22);
            this.txtHost.TabIndex = 3;
            // 
            // txtMac
            // 
            this.txtMac.Location = new System.Drawing.Point(261, 82);
            this.txtMac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMac.Name = "txtMac";
            this.txtMac.ReadOnly = true;
            this.txtMac.Size = new System.Drawing.Size(100, 22);
            this.txtMac.TabIndex = 5;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(515, 87);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 24);
            this.cmbUsers.TabIndex = 6;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(181, 302);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnRegis
            // 
            this.btnRegis.Location = new System.Drawing.Point(261, 302);
            this.btnRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(75, 23);
            this.btnRegis.TabIndex = 8;
            this.btnRegis.Text = "Resgister";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(343, 302);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // GestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.txtMac);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblMac);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionUsers";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionUsers_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button btnDel;
    }
}