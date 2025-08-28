namespace R3K.KOF2002.RomSwitcher
{
  partial class FrmMain
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
      this.btnActivateOriginalKof2002 = new System.Windows.Forms.Button();
      this.btnActivateKof2002Green = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnActivateOriginalKof2002
      // 
      this.btnActivateOriginalKof2002.Location = new System.Drawing.Point(38, 84);
      this.btnActivateOriginalKof2002.Name = "btnActivateOriginalKof2002";
      this.btnActivateOriginalKof2002.Size = new System.Drawing.Size(172, 53);
      this.btnActivateOriginalKof2002.TabIndex = 0;
      this.btnActivateOriginalKof2002.Text = "Activar KOF Original";
      this.btnActivateOriginalKof2002.UseVisualStyleBackColor = true;
      this.btnActivateOriginalKof2002.Click += new System.EventHandler(this.btnActivateOriginalKof2002_Click);
      // 
      // btnActivateKof2002Green
      // 
      this.btnActivateKof2002Green.Location = new System.Drawing.Point(265, 84);
      this.btnActivateKof2002Green.Name = "btnActivateKof2002Green";
      this.btnActivateKof2002Green.Size = new System.Drawing.Size(172, 53);
      this.btnActivateKof2002Green.TabIndex = 1;
      this.btnActivateKof2002Green.Text = "Activar KOF Verde";
      this.btnActivateKof2002Green.UseVisualStyleBackColor = true;
      this.btnActivateKof2002Green.Click += new System.EventHandler(this.btnActivateKof2002Green_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(572, 193);
      this.Controls.Add(this.btnActivateKof2002Green);
      this.Controls.Add(this.btnActivateOriginalKof2002);
      this.Name = "FrmMain";
      this.Text = "KOF2002 Rom Switcher v1.0.0 by Rugalero3000";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnActivateOriginalKof2002;
    private System.Windows.Forms.Button btnActivateKof2002Green;
  }
}