namespace Proiect2_MIP
{
    partial class AddProduct
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
            this.nupCant = new System.Windows.Forms.NumericUpDown();
            this.labelCant = new System.Windows.Forms.Label();
            this.labelvalabilitate = new System.Windows.Forms.Label();
            this.labelIntInMag = new System.Windows.Forms.Label();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelDen = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.dtpTerVal = new System.Windows.Forms.DateTimePicker();
            this.dtpInMag = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nupCant)).BeginInit();
            this.SuspendLayout();
            // 
            // nupCant
            // 
            this.nupCant.Location = new System.Drawing.Point(251, 168);
            this.nupCant.Name = "nupCant";
            this.nupCant.Size = new System.Drawing.Size(120, 26);
            this.nupCant.TabIndex = 24;
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Location = new System.Drawing.Point(46, 174);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(74, 20);
            this.labelCant.TabIndex = 23;
            this.labelCant.Text = "Cantitate";
            // 
            // labelvalabilitate
            // 
            this.labelvalabilitate.AutoSize = true;
            this.labelvalabilitate.Location = new System.Drawing.Point(19, 310);
            this.labelvalabilitate.Name = "labelvalabilitate";
            this.labelvalabilitate.Size = new System.Drawing.Size(163, 20);
            this.labelvalabilitate.TabIndex = 22;
            this.labelvalabilitate.Text = "Termen de valabilitate";
            // 
            // labelIntInMag
            // 
            this.labelIntInMag.AutoSize = true;
            this.labelIntInMag.Location = new System.Drawing.Point(19, 230);
            this.labelIntInMag.Name = "labelIntInMag";
            this.labelIntInMag.Size = new System.Drawing.Size(136, 20);
            this.labelIntInMag.TabIndex = 21;
            this.labelIntInMag.Text = "Intrare in magazin";
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.Thistle;
            this.btnEXIT.Location = new System.Drawing.Point(251, 398);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(120, 59);
            this.btnEXIT.TabIndex = 20;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Thistle;
            this.btnADD.Location = new System.Drawing.Point(80, 398);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(120, 59);
            this.btnADD.TabIndex = 19;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Location = new System.Drawing.Point(46, 111);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(77, 20);
            this.labelDes.TabIndex = 18;
            this.labelDes.Text = "Descriere";
            // 
            // labelDen
            // 
            this.labelDen.AutoSize = true;
            this.labelDen.Location = new System.Drawing.Point(46, 33);
            this.labelDen.Name = "labelDen";
            this.labelDen.Size = new System.Drawing.Size(78, 20);
            this.labelDen.TabIndex = 17;
            this.labelDen.Text = "Denumire";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(201, 105);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(223, 26);
            this.txtDes.TabIndex = 16;
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(201, 27);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(223, 26);
            this.txtDen.TabIndex = 15;
            // 
            // dtpTerVal
            // 
            this.dtpTerVal.Location = new System.Drawing.Point(224, 304);
            this.dtpTerVal.Name = "dtpTerVal";
            this.dtpTerVal.Size = new System.Drawing.Size(200, 26);
            this.dtpTerVal.TabIndex = 14;
            // 
            // dtpInMag
            // 
            this.dtpInMag.Location = new System.Drawing.Point(224, 230);
            this.dtpInMag.Name = "dtpInMag";
            this.dtpInMag.Size = new System.Drawing.Size(200, 26);
            this.dtpInMag.TabIndex = 13;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(463, 493);
            this.Controls.Add(this.nupCant);
            this.Controls.Add(this.labelCant);
            this.Controls.Add(this.labelvalabilitate);
            this.Controls.Add(this.labelIntInMag);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.labelDen);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.dtpTerVal);
            this.Controls.Add(this.dtpInMag);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nupCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupCant;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Label labelvalabilitate;
        private System.Windows.Forms.Label labelIntInMag;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label labelDen;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.DateTimePicker dtpTerVal;
        private System.Windows.Forms.DateTimePicker dtpInMag;
    }
}