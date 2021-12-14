
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
            this.btnCoordenadas.BackColor = System.Drawing.Color.Black;
            this.btnCoordenadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoordenadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoordenadas.ForeColor = System.Drawing.Color.White;
            this.btnCoordenadas.Location = new System.Drawing.Point(203, 74);
            this.btnCoordenadas.Name = "btnCoordenadas";
            this.btnCoordenadas.Size = new System.Drawing.Size(133, 120);
            this.btnCoordenadas.TabIndex = 0;
            this.btnCoordenadas.Text = "Tabla Coordenadas";
            this.btnCoordenadas.UseVisualStyleBackColor = false;
            this.btnCoordenadas.Click += new System.EventHandler(this.btnCoordenadas_Click);
            // 
            // btnUsuaris
            // 
            this.btnUsuaris.BackColor = System.Drawing.Color.Black;
            this.btnUsuaris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuaris.ForeColor = System.Drawing.Color.White;
            this.btnUsuaris.Location = new System.Drawing.Point(203, 239);
            this.btnUsuaris.Name = "btnUsuaris";
            this.btnUsuaris.Size = new System.Drawing.Size(133, 120);
            this.btnUsuaris.TabIndex = 1;
            this.btnUsuaris.Text = "Usuaris";
            this.btnUsuaris.UseVisualStyleBackColor = false;
            this.btnUsuaris.Click += new System.EventHandler(this.btnUsuaris_Click);
            // 
            // btnDispositius
            // 
            this.btnDispositius.BackColor = System.Drawing.Color.Black;
            this.btnDispositius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispositius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispositius.ForeColor = System.Drawing.Color.White;
            this.btnDispositius.Location = new System.Drawing.Point(469, 74);
            this.btnDispositius.Name = "btnDispositius";
            this.btnDispositius.Size = new System.Drawing.Size(120, 120);
            this.btnDispositius.TabIndex = 2;
            this.btnDispositius.Text = "Dispositius";
            this.btnDispositius.UseVisualStyleBackColor = false;
            this.btnDispositius.Click += new System.EventHandler(this.btnDispositius_Click);
            // 
            // PrincipalAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDispositius);
            this.Controls.Add(this.btnUsuaris);
            this.Controls.Add(this.btnCoordenadas);
            this.Name = "PrincipalAdmins";
            this.Text = "PrincipalAdmins";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrincipalAdmins_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoordenadas;
        private System.Windows.Forms.Button btnUsuaris;
        private System.Windows.Forms.Button btnDispositius;
    }
}