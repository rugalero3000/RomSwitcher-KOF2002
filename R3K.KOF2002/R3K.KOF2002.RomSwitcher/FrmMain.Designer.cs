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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.btnActivateOriginalKof2002 = new System.Windows.Forms.Button();
      this.btnActivateKof2002Green = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtRutaBaseRoms = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnActivateOriginalKof2002
      // 
      this.btnActivateOriginalKof2002.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnActivateOriginalKof2002.Image = ((System.Drawing.Image)(resources.GetObject("btnActivateOriginalKof2002.Image")));
      this.btnActivateOriginalKof2002.Location = new System.Drawing.Point(17, 84);
      this.btnActivateOriginalKof2002.Name = "btnActivateOriginalKof2002";
      this.btnActivateOriginalKof2002.Size = new System.Drawing.Size(292, 53);
      this.btnActivateOriginalKof2002.TabIndex = 0;
      this.btnActivateOriginalKof2002.Text = "ACTIVAR KOF ORIGINAL";
      this.btnActivateOriginalKof2002.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnActivateOriginalKof2002.UseVisualStyleBackColor = true;
      this.btnActivateOriginalKof2002.Click += new System.EventHandler(this.btnActivateOriginalKof2002_Click);
      // 
      // btnActivateKof2002Green
      // 
      this.btnActivateKof2002Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnActivateKof2002Green.Image = ((System.Drawing.Image)(resources.GetObject("btnActivateKof2002Green.Image")));
      this.btnActivateKof2002Green.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnActivateKof2002Green.Location = new System.Drawing.Point(360, 84);
      this.btnActivateKof2002Green.Name = "btnActivateKof2002Green";
      this.btnActivateKof2002Green.Size = new System.Drawing.Size(251, 53);
      this.btnActivateKof2002Green.TabIndex = 1;
      this.btnActivateKof2002Green.Text = "ACTIVAR KOF VERDE";
      this.btnActivateKof2002Green.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnActivateKof2002Green.UseVisualStyleBackColor = true;
      this.btnActivateKof2002Green.Click += new System.EventHandler(this.btnActivateKof2002Green_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(99, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "Carpeta ROMs:";
      // 
      // txtRutaBaseRoms
      // 
      this.txtRutaBaseRoms.Enabled = false;
      this.txtRutaBaseRoms.Location = new System.Drawing.Point(119, 16);
      this.txtRutaBaseRoms.Name = "txtRutaBaseRoms";
      this.txtRutaBaseRoms.Size = new System.Drawing.Size(492, 22);
      this.txtRutaBaseRoms.TabIndex = 3;
      this.txtRutaBaseRoms.TextChanged += new System.EventHandler(this.txtRutaBaseRoms_TextChanged);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(639, 158);
      this.Controls.Add(this.txtRutaBaseRoms);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnActivateKof2002Green);
      this.Controls.Add(this.btnActivateOriginalKof2002);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FrmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "KOF2002 Rom Switcher v1.0.0 by Rugalero3000";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnActivateOriginalKof2002;
    private System.Windows.Forms.Button btnActivateKof2002Green;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtRutaBaseRoms;
  }
}