namespace Proiect2_MIP
{
    partial class StergereUtilizatori
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
            this.dataGVUtilizatori = new System.Windows.Forms.DataGridView();
            this.btnStgUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUtilizatori)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVUtilizatori
            // 
            this.dataGVUtilizatori.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGVUtilizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUtilizatori.Location = new System.Drawing.Point(36, 12);
            this.dataGVUtilizatori.Name = "dataGVUtilizatori";
            this.dataGVUtilizatori.RowHeadersWidth = 62;
            this.dataGVUtilizatori.RowTemplate.Height = 28;
            this.dataGVUtilizatori.Size = new System.Drawing.Size(710, 251);
            this.dataGVUtilizatori.TabIndex = 0;
            this.dataGVUtilizatori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVUtilizatori_CellContentClick);
            // 
            // btnStgUser
            // 
            this.btnStgUser.BackColor = System.Drawing.Color.Thistle;
            this.btnStgUser.Location = new System.Drawing.Point(278, 283);
            this.btnStgUser.Name = "btnStgUser";
            this.btnStgUser.Size = new System.Drawing.Size(231, 54);
            this.btnStgUser.TabIndex = 1;
            this.btnStgUser.Text = "Sterge utilizator selectat";
            this.btnStgUser.UseVisualStyleBackColor = false;
            this.btnStgUser.Click += new System.EventHandler(this.btnStgUser_Click);
            // 
            // StergereUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(792, 367);
            this.Controls.Add(this.btnStgUser);
            this.Controls.Add(this.dataGVUtilizatori);
            this.Name = "StergereUtilizatori";
            this.Text = "StergereUtilizatori";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUtilizatori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVUtilizatori;
        private System.Windows.Forms.Button btnStgUser;
    }
}