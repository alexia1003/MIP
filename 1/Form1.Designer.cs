namespace Proiect1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TextBoxUrl = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGO = new System.Windows.Forms.ToolStripButton();
            this.btnHOME = new System.Windows.Forms.ToolStripButton();
            this.btnBACK = new System.Windows.Forms.ToolStripButton();
            this.btnFORWARD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.ComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.LightPink;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBoxUrl,
            this.toolStripSeparator1,
            this.btnGO,
            this.btnHOME,
            this.btnBACK,
            this.btnFORWARD,
            this.toolStripSeparator2,
            this.btnAdd,
            this.ComboBox});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(854, 33);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // TextBoxUrl
            // 
            this.TextBoxUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUrl.Name = "TextBoxUrl";
            this.TextBoxUrl.Size = new System.Drawing.Size(400, 33);
            this.TextBoxUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUrl_KeyPress);
            this.TextBoxUrl.Click += new System.EventHandler(this.TextBoxUrl_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // btnGO
            // 
            this.btnGO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGO.Image = ((System.Drawing.Image)(resources.GetObject("btnGO.Image")));
            this.btnGO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(34, 28);
            this.btnGO.Text = "GO";
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnHOME
            // 
            this.btnHOME.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHOME.Image = ((System.Drawing.Image)(resources.GetObject("btnHOME.Image")));
            this.btnHOME.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(34, 28);
            this.btnHOME.Text = "HOME";
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBACK.Image = ((System.Drawing.Image)(resources.GetObject("btnBACK.Image")));
            this.btnBACK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(34, 28);
            this.btnBACK.Text = "BACK";
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // btnFORWARD
            // 
            this.btnFORWARD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFORWARD.Image = ((System.Drawing.Image)(resources.GetObject("btnFORWARD.Image")));
            this.btnFORWARD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFORWARD.Name = "btnFORWARD";
            this.btnFORWARD.Size = new System.Drawing.Size(34, 28);
            this.btnFORWARD.Text = "FORWARD";
            this.btnFORWARD.Click += new System.EventHandler(this.btnFORWARD_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 28);
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 33);
            this.ComboBox.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 33);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(854, 476);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Navigating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 509);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripTextBox TextBoxUrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGO;
        private System.Windows.Forms.ToolStripButton btnHOME;
        private System.Windows.Forms.ToolStripButton btnFORWARD;
        private System.Windows.Forms.ToolStripButton btnBACK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripComboBox ComboBox;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

