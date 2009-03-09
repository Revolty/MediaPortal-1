namespace WindowsApplication3
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
      this.sourcePath = new System.Windows.Forms.TextBox();
      this.destinationPath = new System.Windows.Forms.TextBox();
      this.buttonStart = new System.Windows.Forms.Button();
      this.buttonSource = new System.Windows.Forms.Button();
      this.buttonDest = new System.Windows.Forms.Button();
      this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // sourcePath
      // 
      this.sourcePath.Location = new System.Drawing.Point(23, 92);
      this.sourcePath.Name = "sourcePath";
      this.sourcePath.Size = new System.Drawing.Size(322, 20);
      this.sourcePath.TabIndex = 0;
      // 
      // destinationPath
      // 
      this.destinationPath.Location = new System.Drawing.Point(23, 160);
      this.destinationPath.Name = "destinationPath";
      this.destinationPath.Size = new System.Drawing.Size(322, 20);
      this.destinationPath.TabIndex = 1;
      // 
      // buttonStart
      // 
      this.buttonStart.Location = new System.Drawing.Point(135, 227);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(75, 23);
      this.buttonStart.TabIndex = 2;
      this.buttonStart.Text = "Start";
      this.buttonStart.UseVisualStyleBackColor = true;
      this.buttonStart.Click += new System.EventHandler(this.button1_Click);
      // 
      // buttonSource
      // 
      this.buttonSource.Location = new System.Drawing.Point(351, 92);
      this.buttonSource.Name = "buttonSource";
      this.buttonSource.Size = new System.Drawing.Size(28, 19);
      this.buttonSource.TabIndex = 3;
      this.buttonSource.Text = "...";
      this.buttonSource.UseVisualStyleBackColor = true;
      this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
      // 
      // buttonDest
      // 
      this.buttonDest.Location = new System.Drawing.Point(351, 160);
      this.buttonDest.Name = "buttonDest";
      this.buttonDest.Size = new System.Drawing.Size(27, 19);
      this.buttonDest.TabIndex = 4;
      this.buttonDest.Text = "...";
      this.buttonDest.UseVisualStyleBackColor = true;
      this.buttonDest.Click += new System.EventHandler(this.buttonDest_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(356, 39);
      this.label1.TabIndex = 5;
      this.label1.Text = "This small utility will build a list of all bmp/png files in \"Source directory\"\r\n" +
          "and check for a reference in all .cs/.xml files in the \"Destination directory\" \r" +
          "\nafter removing the extension.";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Source directory";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 141);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(103, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Destination directory";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(406, 283);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonDest);
      this.Controls.Add(this.buttonSource);
      this.Controls.Add(this.buttonStart);
      this.Controls.Add(this.destinationPath);
      this.Controls.Add(this.sourcePath);
      this.Name = "Form1";
      this.Text = "File reference checker for MediaPortal skins";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox sourcePath;
    private System.Windows.Forms.TextBox destinationPath;
    private System.Windows.Forms.Button buttonStart;
    private System.Windows.Forms.Button buttonSource;
    private System.Windows.Forms.Button buttonDest;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}

