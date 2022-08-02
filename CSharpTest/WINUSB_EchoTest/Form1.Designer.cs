namespace WINUSB_EchoTest
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
            this.MsgBox = new System.Windows.Forms.ListBox();
            this.SendDataTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MsgBox
            // 
            this.MsgBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgBox.FormattingEnabled = true;
            this.MsgBox.ItemHeight = 20;
            this.MsgBox.Location = new System.Drawing.Point(638, 11);
            this.MsgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(732, 684);
            this.MsgBox.TabIndex = 0;
            this.MsgBox.SelectedIndexChanged += new System.EventHandler(this.MsgBox_SelectedIndexChanged);
            // 
            // SendDataTextBox
            // 
            this.SendDataTextBox.Location = new System.Drawing.Point(40, 109);
            this.SendDataTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendDataTextBox.Name = "SendDataTextBox";
            this.SendDataTextBox.Size = new System.Drawing.Size(571, 26);
            this.SendDataTextBox.TabIndex = 5;
            this.SendDataTextBox.Text = "30, 31,32, 33, 34, 35, 36, 37, 38, 39, 3A, 3B, 3C, 3D, 3E, 3F";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 91);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 717);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SendDataTextBox);
            this.Controls.Add(this.MsgBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "WINUSB_EchoTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox MsgBox;
      private System.Windows.Forms.TextBox SendDataTextBox;
      private System.Windows.Forms.Button button1;
   }
}

