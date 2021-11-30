
namespace m20
{
    partial class pantallaloggin
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
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxPasswrd = new System.Windows.Forms.TextBox();
            this.bttUser = new System.Windows.Forms.Button();
            this.bttPasswrd = new System.Windows.Forms.Button();
            this.bttEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxUser.Location = new System.Drawing.Point(369, 189);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(164, 20);
            this.txtBoxUser.TabIndex = 0;
            // 
            // txtBoxPasswrd
            // 
            this.txtBoxPasswrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPasswrd.Location = new System.Drawing.Point(369, 244);
            this.txtBoxPasswrd.Name = "txtBoxPasswrd";
            this.txtBoxPasswrd.PasswordChar = '*';
            this.txtBoxPasswrd.Size = new System.Drawing.Size(163, 20);
            this.txtBoxPasswrd.TabIndex = 1;
            // 
            // bttUser
            // 
            this.bttUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUser.Location = new System.Drawing.Point(214, 186);
            this.bttUser.Name = "bttUser";
            this.bttUser.Size = new System.Drawing.Size(126, 23);
            this.bttUser.TabIndex = 2;
            this.bttUser.Text = "User Name";
            this.bttUser.UseVisualStyleBackColor = true;
            // 
            // bttPasswrd
            // 
            this.bttPasswrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttPasswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPasswrd.Location = new System.Drawing.Point(214, 244);
            this.bttPasswrd.Name = "bttPasswrd";
            this.bttPasswrd.Size = new System.Drawing.Size(126, 23);
            this.bttPasswrd.TabIndex = 3;
            this.bttPasswrd.Text = "Password";
            this.bttPasswrd.UseVisualStyleBackColor = true;
            // 
            // bttEnter
            // 
            this.bttEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEnter.Location = new System.Drawing.Point(458, 303);
            this.bttEnter.Name = "bttEnter";
            this.bttEnter.Size = new System.Drawing.Size(75, 23);
            this.bttEnter.TabIndex = 4;
            this.bttEnter.Text = "Enter";
            this.bttEnter.UseVisualStyleBackColor = true;
            this.bttEnter.Click += new System.EventHandler(this.bttEnter_Click);
            // 
            // pantallaloggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttEnter);
            this.Controls.Add(this.bttPasswrd);
            this.Controls.Add(this.bttUser);
            this.Controls.Add(this.txtBoxPasswrd);
            this.Controls.Add(this.txtBoxUser);
            this.Name = "pantallaloggin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.pantallaloggin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxPasswrd;
        private System.Windows.Forms.Button bttUser;
        private System.Windows.Forms.Button bttPasswrd;
        private System.Windows.Forms.Button bttEnter;
    }
}