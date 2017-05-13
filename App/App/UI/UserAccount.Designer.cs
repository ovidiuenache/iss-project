﻿namespace App.UI
{
    partial class UserAccount
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonBrowseAbstract = new System.Windows.Forms.Button();
            this.textBoxAbstract = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFull = new System.Windows.Forms.TextBox();
            this.buttonBrowseFull = new System.Windows.Forms.Button();
            this.buttonUploadFull = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(189, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonBrowseAbstract
            // 
            this.buttonBrowseAbstract.Location = new System.Drawing.Point(458, 55);
            this.buttonBrowseAbstract.Name = "buttonBrowseAbstract";
            this.buttonBrowseAbstract.Size = new System.Drawing.Size(109, 23);
            this.buttonBrowseAbstract.TabIndex = 1;
            this.buttonBrowseAbstract.Text = "Browse...";
            this.buttonBrowseAbstract.UseVisualStyleBackColor = true;
            // 
            // textBoxAbstract
            // 
            this.textBoxAbstract.Location = new System.Drawing.Point(246, 57);
            this.textBoxAbstract.Name = "textBoxAbstract";
            this.textBoxAbstract.Size = new System.Drawing.Size(206, 20);
            this.textBoxAbstract.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Upload Abstract";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxFull
            // 
            this.textBoxFull.Location = new System.Drawing.Point(246, 161);
            this.textBoxFull.Name = "textBoxFull";
            this.textBoxFull.Size = new System.Drawing.Size(206, 20);
            this.textBoxFull.TabIndex = 4;
            // 
            // buttonBrowseFull
            // 
            this.buttonBrowseFull.Location = new System.Drawing.Point(458, 158);
            this.buttonBrowseFull.Name = "buttonBrowseFull";
            this.buttonBrowseFull.Size = new System.Drawing.Size(109, 23);
            this.buttonBrowseFull.TabIndex = 5;
            this.buttonBrowseFull.Text = "Browse...";
            this.buttonBrowseFull.UseVisualStyleBackColor = true;
            // 
            // buttonUploadFull
            // 
            this.buttonUploadFull.Location = new System.Drawing.Point(354, 196);
            this.buttonUploadFull.Name = "buttonUploadFull";
            this.buttonUploadFull.Size = new System.Drawing.Size(177, 23);
            this.buttonUploadFull.TabIndex = 6;
            this.buttonUploadFull.Text = "Upload Full";
            this.buttonUploadFull.UseVisualStyleBackColor = true;
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 318);
            this.Controls.Add(this.buttonUploadFull);
            this.Controls.Add(this.buttonBrowseFull);
            this.Controls.Add(this.textBoxFull);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAbstract);
            this.Controls.Add(this.buttonBrowseAbstract);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserAccount";
            this.Text = "UserAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBrowseAbstract;
        private System.Windows.Forms.TextBox textBoxAbstract;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFull;
        private System.Windows.Forms.Button buttonBrowseFull;
        private System.Windows.Forms.Button buttonUploadFull;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}