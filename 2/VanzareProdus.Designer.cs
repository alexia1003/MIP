namespace Proiect2_MIP
{
    partial class VanzareProdus
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
            this.btnVanzare = new System.Windows.Forms.Button();
            this.lblDetaliiProdus = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.Cantitate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVanzare
            // 
            this.btnVanzare.BackColor = System.Drawing.Color.Thistle;
            this.btnVanzare.Location = new System.Drawing.Point(484, 129);
            this.btnVanzare.Name = "btnVanzare";
            this.btnVanzare.Size = new System.Drawing.Size(107, 46);
            this.btnVanzare.TabIndex = 1;
            this.btnVanzare.Text = "Vanzare";
            this.btnVanzare.UseVisualStyleBackColor = false;
            this.btnVanzare.Click += new System.EventHandler(this.btnVanzare_Click);
            // 
            // lblDetaliiProdus
            // 
            this.lblDetaliiProdus.Location = new System.Drawing.Point(40, 58);
            this.lblDetaliiProdus.Name = "lblDetaliiProdus";
            this.lblDetaliiProdus.Size = new System.Drawing.Size(551, 26);
            this.lblDetaliiProdus.TabIndex = 2;
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(165, 139);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(270, 26);
            this.txtCantitate.TabIndex = 3;
            // 
            // Cantitate
            // 
            this.Cantitate.AutoSize = true;
            this.Cantitate.Location = new System.Drawing.Point(45, 142);
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.Size = new System.Drawing.Size(74, 20);
            this.Cantitate.TabIndex = 4;
            this.Cantitate.Text = "Cantitate";
            // 
            // VanzareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(641, 220);
            this.Controls.Add(this.Cantitate);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.lblDetaliiProdus);
            this.Controls.Add(this.btnVanzare);
            this.Name = "VanzareProdus";
            this.Text = "VanzareProdus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVanzare;
        private System.Windows.Forms.TextBox lblDetaliiProdus;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.Label Cantitate;
    }
}