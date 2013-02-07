namespace Contacts
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.OPCLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OPCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // OPCLogo
            // 
            this.OPCLogo.Image = ((System.Drawing.Image)(resources.GetObject("OPCLogo.Image")));
            this.OPCLogo.Location = new System.Drawing.Point(318, 39);
            this.OPCLogo.Name = "OPCLogo";
            this.OPCLogo.Size = new System.Drawing.Size(177, 77);
            this.OPCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OPCLogo.TabIndex = 0;
            this.OPCLogo.TabStop = false;
            this.OPCLogo.Click += new System.EventHandler(this.OPCLogo_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 489);
            this.Controls.Add(this.OPCLogo);
            this.Name = "main";
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.OPCLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox OPCLogo;
    }
}

