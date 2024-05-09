namespace Proiect2_MIP
{
    partial class Login
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
            this.labelUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.labelParola = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnStgU = new System.Windows.Forms.Button();
            this.btnAddU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(30, 57);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(83, 20);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(147, 54);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(234, 26);
            this.txtUser.TabIndex = 1;
            // 
            // txtPassw
            // 
            this.txtPassw.Location = new System.Drawing.Point(147, 136);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.Size = new System.Drawing.Size(234, 26);
            this.txtPassw.TabIndex = 3;
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Location = new System.Drawing.Point(30, 142);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(78, 20);
            this.labelParola.TabIndex = 2;
            this.labelParola.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Thistle;
            this.btnLogin.Location = new System.Drawing.Point(34, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login\r\n";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnStgU
            // 
            this.btnStgU.BackColor = System.Drawing.Color.Plum;
            this.btnStgU.Location = new System.Drawing.Point(291, 204);
            this.btnStgU.Name = "btnStgU";
            this.btnStgU.Size = new System.Drawing.Size(90, 72);
            this.btnStgU.TabIndex = 10;
            this.btnStgU.Text = "Sterge utilizator\r\n";
            this.btnStgU.UseVisualStyleBackColor = false;
            this.btnStgU.Click += new System.EventHandler(this.btnStgU_Click);
            // 
            // btnAddU
            // 
            this.btnAddU.BackColor = System.Drawing.Color.Plum;
            this.btnAddU.Location = new System.Drawing.Point(181, 204);
            this.btnAddU.Name = "btnAddU";
            this.btnAddU.Size = new System.Drawing.Size(90, 72);
            this.btnAddU.TabIndex = 9;
            this.btnAddU.Text = "Adauga utilizator";
            this.btnAddU.UseVisualStyleBackColor = false;
            this.btnAddU.Click += new System.EventHandler(this.btnAddU_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(449, 314);
            this.Controls.Add(this.btnStgU);
            this.Controls.Add(this.btnAddU);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelUser);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnStgU;
        private System.Windows.Forms.Button btnAddU;
    }
}