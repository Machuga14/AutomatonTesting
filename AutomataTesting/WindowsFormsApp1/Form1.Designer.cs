namespace WindowsFormsApp1
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
      this.rtbxAutomaton = new System.Windows.Forms.RichTextBox();
      this.btnParse = new System.Windows.Forms.Button();
      this.spcAutomotaAndString = new System.Windows.Forms.SplitContainer();
      this.rtbxStringsToEval = new System.Windows.Forms.RichTextBox();
      this.btnEval = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.spcAutomotaAndString)).BeginInit();
      this.spcAutomotaAndString.Panel1.SuspendLayout();
      this.spcAutomotaAndString.Panel2.SuspendLayout();
      this.spcAutomotaAndString.SuspendLayout();
      this.SuspendLayout();
      // 
      // rtbxAutomaton
      // 
      this.rtbxAutomaton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rtbxAutomaton.Location = new System.Drawing.Point(3, 3);
      this.rtbxAutomaton.Name = "rtbxAutomaton";
      this.rtbxAutomaton.Size = new System.Drawing.Size(510, 430);
      this.rtbxAutomaton.TabIndex = 0;
      this.rtbxAutomaton.Text = "";
      // 
      // btnParse
      // 
      this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnParse.Location = new System.Drawing.Point(3, 443);
      this.btnParse.Name = "btnParse";
      this.btnParse.Size = new System.Drawing.Size(75, 23);
      this.btnParse.TabIndex = 1;
      this.btnParse.Text = "Parse";
      this.btnParse.UseVisualStyleBackColor = true;
      this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
      // 
      // spcAutomotaAndString
      // 
      this.spcAutomotaAndString.Location = new System.Drawing.Point(0, 0);
      this.spcAutomotaAndString.Name = "spcAutomotaAndString";
      // 
      // spcAutomotaAndString.Panel1
      // 
      this.spcAutomotaAndString.Panel1.Controls.Add(this.rtbxAutomaton);
      this.spcAutomotaAndString.Panel1.Controls.Add(this.btnParse);
      // 
      // spcAutomotaAndString.Panel2
      // 
      this.spcAutomotaAndString.Panel2.Controls.Add(this.rtbxStringsToEval);
      this.spcAutomotaAndString.Panel2.Controls.Add(this.btnEval);
      this.spcAutomotaAndString.Size = new System.Drawing.Size(1014, 466);
      this.spcAutomotaAndString.SplitterDistance = 516;
      this.spcAutomotaAndString.TabIndex = 2;
      // 
      // rtbxStringsToEval
      // 
      this.rtbxStringsToEval.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rtbxStringsToEval.Location = new System.Drawing.Point(3, 3);
      this.rtbxStringsToEval.Name = "rtbxStringsToEval";
      this.rtbxStringsToEval.Size = new System.Drawing.Size(476, 430);
      this.rtbxStringsToEval.TabIndex = 2;
      this.rtbxStringsToEval.Text = "";
      // 
      // btnEval
      // 
      this.btnEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnEval.Location = new System.Drawing.Point(3, 443);
      this.btnEval.Name = "btnEval";
      this.btnEval.Size = new System.Drawing.Size(75, 23);
      this.btnEval.TabIndex = 3;
      this.btnEval.Text = "Eval";
      this.btnEval.UseVisualStyleBackColor = true;
      this.btnEval.Click += new System.EventHandler(this.btnEval_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1011, 467);
      this.Controls.Add(this.spcAutomotaAndString);
      this.Name = "Form1";
      this.Text = "Form1";
      this.spcAutomotaAndString.Panel1.ResumeLayout(false);
      this.spcAutomotaAndString.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.spcAutomotaAndString)).EndInit();
      this.spcAutomotaAndString.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtbxAutomaton;
    private System.Windows.Forms.Button btnParse;
    private System.Windows.Forms.SplitContainer spcAutomotaAndString;
    private System.Windows.Forms.RichTextBox rtbxStringsToEval;
    private System.Windows.Forms.Button btnEval;
  }
}

