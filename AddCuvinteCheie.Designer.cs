namespace Proiect1
{
    partial class AddCuvinteCheie
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
            this.txtCuvCh = new System.Windows.Forms.TextBox();
            this.btnAddCuvCh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCuvCh
            // 
            this.txtCuvCh.Location = new System.Drawing.Point(93, 178);
            this.txtCuvCh.Name = "txtCuvCh";
            this.txtCuvCh.Size = new System.Drawing.Size(364, 26);
            this.txtCuvCh.TabIndex = 0;
            this.txtCuvCh.TextChanged += new System.EventHandler(this.txtCuvCh_TextChanged);
            // 
            // btnAddCuvCh
            // 
            this.btnAddCuvCh.BackColor = System.Drawing.Color.Plum;
            this.btnAddCuvCh.Location = new System.Drawing.Point(557, 160);
            this.btnAddCuvCh.Name = "btnAddCuvCh";
            this.btnAddCuvCh.Size = new System.Drawing.Size(123, 62);
            this.btnAddCuvCh.TabIndex = 1;
            this.btnAddCuvCh.Text = "ADD";
            this.btnAddCuvCh.UseVisualStyleBackColor = false;
            this.btnAddCuvCh.Click += new System.EventHandler(this.btnAddCuvCh_Click);
            // 
            // AddCuvinteCheie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddCuvCh);
            this.Controls.Add(this.txtCuvCh);
            this.Name = "AddCuvinteCheie";
            this.Text = "AddCuvinteCheie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuvCh;
        private System.Windows.Forms.Button btnAddCuvCh;
    }
}