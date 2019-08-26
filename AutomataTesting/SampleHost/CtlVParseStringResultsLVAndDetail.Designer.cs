namespace SampleHost
{
  partial class CtlVParseStringResultsLVAndDetail
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.ctlVParseStringResultsInLV1 = new SampleHost.CtlVParseStringResultsInLV();
      this.ctlVParseStringResults1 = new SampleHost.CtlVParseStringResults();
      this.SuspendLayout();
      // 
      // ctlVParseStringResultsInLV1
      // 
      this.ctlVParseStringResultsInLV1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.ctlVParseStringResultsInLV1.Location = new System.Drawing.Point(0, 0);
      this.ctlVParseStringResultsInLV1.Name = "ctlVParseStringResultsInLV1";
      this.ctlVParseStringResultsInLV1.ResultsInLV = null;
      this.ctlVParseStringResultsInLV1.Size = new System.Drawing.Size(201, 437);
      this.ctlVParseStringResultsInLV1.TabIndex = 0;
      this.ctlVParseStringResultsInLV1.ParseStringResultsSelectedHandler += new SampleHost.ParseStringResultsDelegate(this.CtlVParseStringResultsInLV1_ParseStringResultsSelectedHandler);
      // 
      // ctlVParseStringResults1
      // 
      this.ctlVParseStringResults1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ctlVParseStringResults1.Location = new System.Drawing.Point(207, 0);
      this.ctlVParseStringResults1.Name = "ctlVParseStringResults1";
      this.ctlVParseStringResults1.ResultsOnScreen = null;
      this.ctlVParseStringResults1.Size = new System.Drawing.Size(616, 437);
      this.ctlVParseStringResults1.TabIndex = 1;
      // 
      // CtlVParseStringResultsLVAndDetail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ctlVParseStringResults1);
      this.Controls.Add(this.ctlVParseStringResultsInLV1);
      this.Name = "CtlVParseStringResultsLVAndDetail";
      this.Size = new System.Drawing.Size(823, 437);
      this.ResumeLayout(false);

    }

    #endregion

    private CtlVParseStringResultsInLV ctlVParseStringResultsInLV1;
    private CtlVParseStringResults ctlVParseStringResults1;
  }
}
