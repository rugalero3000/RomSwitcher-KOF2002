namespace R3K.KOF2002.RomSwitcher
{
  partial class FrmLoader
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoader));
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.pbBanner = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
      this.SuspendLayout();
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(1, 207);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(675, 40);
      this.progressBar1.TabIndex = 0;
      // 
      // pbBanner
      // 
      this.pbBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbBanner.Image")));
      this.pbBanner.Location = new System.Drawing.Point(1, 3);
      this.pbBanner.Name = "pbBanner";
      this.pbBanner.Size = new System.Drawing.Size(675, 198);
      this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pbBanner.TabIndex = 1;
      this.pbBanner.TabStop = false;
      // 
      // FrmLoader
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(677, 245);
      this.Controls.Add(this.pbBanner);
      this.Controls.Add(this.progressBar1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmLoader";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "KOF2002 Rom Switcher v1.0.0 by Rugalero3000";
      this.Load += new System.EventHandler(this.FrmLoader_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.PictureBox pbBanner;
  }
}

