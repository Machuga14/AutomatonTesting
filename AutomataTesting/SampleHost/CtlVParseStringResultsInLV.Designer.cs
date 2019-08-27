namespace SampleHost
{
  partial class CtlVParseStringResultsInLV
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
      this.lvParseStringResults = new System.Windows.Forms.ListView();
      this.columnHeaderInputString = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderValidated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderError = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderOffendingCharacter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.SuspendLayout();
      // 
      // lvParseStringResults
      // 
      this.lvParseStringResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lvParseStringResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderInputString,
            this.columnHeaderValidated,
            this.columnHeaderError,
            this.columnHeaderOffendingCharacter});
      this.lvParseStringResults.FullRowSelect = true;
      this.lvParseStringResults.GridLines = true;
      this.lvParseStringResults.HideSelection = false;
      this.lvParseStringResults.Location = new System.Drawing.Point(0, 16);
      this.lvParseStringResults.MultiSelect = false;
      this.lvParseStringResults.Name = "lvParseStringResults";
      this.lvParseStringResults.Size = new System.Drawing.Size(617, 367);
      this.lvParseStringResults.TabIndex = 0;
      this.lvParseStringResults.UseCompatibleStateImageBehavior = false;
      this.lvParseStringResults.View = System.Windows.Forms.View.Details;
      this.lvParseStringResults.SelectedIndexChanged += new System.EventHandler(this.LvParseStringResults_SelectedIndexChanged);
      // 
      // columnHeaderInputString
      // 
      this.columnHeaderInputString.Text = "Input String";
      this.columnHeaderInputString.Width = 120;
      // 
      // columnHeaderValidated
      // 
      this.columnHeaderValidated.Text = "Validated";
      // 
      // columnHeaderError
      // 
      this.columnHeaderError.Text = "Err?";
      this.columnHeaderError.Width = 40;
      // 
      // columnHeaderOffendingCharacter
      // 
      this.columnHeaderOffendingCharacter.Text = "Char";
      // 
      // CtlVParseStringResultsInLV
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lvParseStringResults);
      this.Name = "CtlVParseStringResultsInLV";
      this.Size = new System.Drawing.Size(617, 383);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView lvParseStringResults;
    private System.Windows.Forms.ColumnHeader columnHeaderInputString;
    private System.Windows.Forms.ColumnHeader columnHeaderValidated;
    private System.Windows.Forms.ColumnHeader columnHeaderError;
    private System.Windows.Forms.ColumnHeader columnHeaderOffendingCharacter;
  }
}
