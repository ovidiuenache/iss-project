namespace App.UI.PhaseTwo
{
    partial class AuthorMain
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.openFileDialogBrowse = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.browseButton.Location = new System.Drawing.Point(291, 26);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(83, 44);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "BROWSE";
            this.browseButton.UseVisualStyleBackColor = false;
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uploadButton.Location = new System.Drawing.Point(39, 101);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(115, 55);
            this.uploadButton.TabIndex = 2;
            this.uploadButton.Text = "Upload information";
            this.uploadButton.UseVisualStyleBackColor = false;
            // 
            // openFileDialogBrowse
            // 
            this.openFileDialogBrowse.FileName = "openFileDialog1";
            // 
            // AuthorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 243);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.textBox1);
            this.Name = "AuthorMain";
            this.Text = "AuthorMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowse;
    }
}