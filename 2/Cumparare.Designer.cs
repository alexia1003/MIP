namespace Proiect2_MIP
{
    partial class Cumparare
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
            this.dgvIstoricVanzare = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricVanzare)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIstoricVanzare
            // 
            this.dgvIstoricVanzare.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvIstoricVanzare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIstoricVanzare.GridColor = System.Drawing.Color.LavenderBlush;
            this.dgvIstoricVanzare.Location = new System.Drawing.Point(12, 23);
            this.dgvIstoricVanzare.Name = "dgvIstoricVanzare";
            this.dgvIstoricVanzare.RowHeadersWidth = 62;
            this.dgvIstoricVanzare.RowTemplate.Height = 28;
            this.dgvIstoricVanzare.Size = new System.Drawing.Size(776, 405);
            this.dgvIstoricVanzare.TabIndex = 1;
            this.dgvIstoricVanzare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIstoricVanzare_CellContentClick);
            // 
            // Cumparare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIstoricVanzare);
            this.Name = "Cumparare";
            this.Text = "Cumparare";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricVanzare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvIstoricVanzare;
    }
}