
namespace m20
{
    partial class PrincipalAdmins
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
            this.btnCoordenadas = new System.Windows.Forms.Button();
            this.btnUsuaris = new System.Windows.Forms.Button();
            this.btnDispositius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCoordenadas
            // 
            this.btnCoordenadas.Location = new System.Drawing.Point(482, 74);
            this.btnCoordenadas.Name = "btnCoordenadas";
            this.btnCoordenadas.Size = new System.Drawing.Size(120, 120);
            this.btnCoordenadas.TabIndex = 0;
            this.btnCoordenadas.Text = "Tabla Coordenadas";
            this.btnCoordenadas.UseVisualStyleBackColor = true;
            this.btnCoordenadas.Click += new System.EventHandler(this.btnCoordenadas_Click);
            // 
            // btnUsuaris
            // 
            this.btnUsuaris.Location = new System.Drawing.Point(482, 255);
            this.btnUsuaris.Name = "btnUsuaris";
            this.btnUsuaris.Size = new System.Drawing.Size(120, 120);
            this.btnUsuaris.TabIndex = 1;
            this.btnUsuaris.Text = "Usuaris";
            this.btnUsuaris.UseVisualStyleBackColor = true;
            this.btnUsuaris.Click += new System.EventHandler(this.btnUsuaris_Click);
            // 
            // btnDispositius
            // 
            this.btnDispositius.Location = new System.Drawing.Point(647, 74);
            this.btnDispositius.Name = "btnDispositius";
            this.btnDispositius.Size = new System.Drawing.Size(120, 120);
            this.btnDispositius.TabIndex = 2;
            this.btnDispositius.Text = "Dispositius";
            this.btnDispositius.UseVisualStyleBackColor = true;
            this.btnDispositius.Click += new System.EventHandler(this.btnDispositius_Click);
            // 
            // PrincipalAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDispositius);
            this.Controls.Add(this.btnUsuaris);
            this.Controls.Add(this.btnCoordenadas);
            this.Name = "PrincipalAdmins";
            this.Text = "PrincipalAdmins";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoordenadas;
        private System.Windows.Forms.Button btnUsuaris;
        private System.Windows.Forms.Button btnDispositius;
    }
}