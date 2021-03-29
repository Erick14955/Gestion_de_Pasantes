
namespace Gestion_de_Pasantes
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsuariopictureBox = new System.Windows.Forms.PictureBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.ErroreserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErroreserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariopictureBox
            // 
            this.UsuariopictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UsuariopictureBox.Image")));
            this.UsuariopictureBox.Location = new System.Drawing.Point(100, 21);
            this.UsuariopictureBox.Name = "UsuariopictureBox";
            this.UsuariopictureBox.Size = new System.Drawing.Size(131, 138);
            this.UsuariopictureBox.TabIndex = 1;
            this.UsuariopictureBox.TabStop = false;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(100, 162);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(36, 15);
            this.Emaillabel.TabIndex = 2;
            this.Emaillabel.Text = "Email";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailtextBox.Location = new System.Drawing.Point(100, 180);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(131, 23);
            this.EmailtextBox.TabIndex = 3;
            this.EmailtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailtextBox_KeyPress);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(100, 216);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(67, 15);
            this.passwordlabel.TabIndex = 4;
            this.passwordlabel.Text = "Contraseña";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordtextBox.Location = new System.Drawing.Point(100, 234);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(131, 23);
            this.passwordtextBox.TabIndex = 5;
            this.passwordtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordtextBox_KeyPress);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Loginbutton.Location = new System.Drawing.Point(100, 275);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(88, 23);
            this.Loginbutton.TabIndex = 6;
            this.Loginbutton.Text = "Iniciar sesion";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // ErroreserrorProvider
            // 
            this.ErroreserrorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(331, 318);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.UsuariopictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(347, 357);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.UsuariopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErroreserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UsuariopictureBox;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.ErrorProvider ErroreserrorProvider;
    }
}

