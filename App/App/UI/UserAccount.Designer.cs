namespace App.UI
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
            this.dataGridViewProposals = new System.Windows.Forms.DataGridView();
            this.buttonBrowseAbstract = new System.Windows.Forms.Button();
            this.textBoxAbstract = new System.Windows.Forms.TextBox();
            this.buttonUploadAbstract = new System.Windows.Forms.Button();
            this.textBoxFull = new System.Windows.Forms.TextBox();
            this.buttonBrowseFull = new System.Windows.Forms.Button();
            this.buttonUploadFull = new System.Windows.Forms.Button();
            this.openFileDialogAbstract = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogFull = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProposals)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProposals
            // 
            this.dataGridViewProposals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProposals.Location = new System.Drawing.Point(24, 31);
            this.dataGridViewProposals.Name = "dataGridViewProposals";
            this.dataGridViewProposals.Size = new System.Drawing.Size(189, 252);
            this.dataGridViewProposals.TabIndex = 0;
            // 
            // buttonBrowseAbstract
            // 
            this.buttonBrowseAbstract.Location = new System.Drawing.Point(458, 55);
            this.buttonBrowseAbstract.Name = "buttonBrowseAbstract";
            this.buttonBrowseAbstract.Size = new System.Drawing.Size(109, 23);
            this.buttonBrowseAbstract.TabIndex = 1;
            this.buttonBrowseAbstract.Text = "Browse...";
            this.buttonBrowseAbstract.UseVisualStyleBackColor = true;
            this.buttonBrowseAbstract.Click += new System.EventHandler(this.buttonBrowseAbstract_Click);
            // 
            // textBoxAbstract
            // 
            this.textBoxAbstract.Location = new System.Drawing.Point(246, 57);
            this.textBoxAbstract.Name = "textBoxAbstract";
            this.textBoxAbstract.Size = new System.Drawing.Size(206, 20);
            this.textBoxAbstract.TabIndex = 2;
            // 
            // buttonUploadAbstract
            // 
            this.buttonUploadAbstract.Location = new System.Drawing.Point(354, 93);
            this.buttonUploadAbstract.Name = "buttonUploadAbstract";
            this.buttonUploadAbstract.Size = new System.Drawing.Size(177, 23);
            this.buttonUploadAbstract.TabIndex = 3;
            this.buttonUploadAbstract.Text = "Upload Abstract";
            this.buttonUploadAbstract.UseVisualStyleBackColor = true;
            this.buttonUploadAbstract.Click += new System.EventHandler(this.buttonUploadAbstract_Click);
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
            this.buttonBrowseFull.Click += new System.EventHandler(this.buttonBrowseFull_Click);
            // 
            // buttonUploadFull
            // 
            this.buttonUploadFull.Location = new System.Drawing.Point(354, 196);
            this.buttonUploadFull.Name = "buttonUploadFull";
            this.buttonUploadFull.Size = new System.Drawing.Size(177, 23);
            this.buttonUploadFull.TabIndex = 6;
            this.buttonUploadFull.Text = "Upload Full";
            this.buttonUploadFull.UseVisualStyleBackColor = true;
            this.buttonUploadFull.Click += new System.EventHandler(this.buttonUploadFull_Click);
            // 
            // openFileDialogAbstract
            // 
            this.openFileDialogAbstract.FileName = "openFileDialogAbstract";
            // 
            // openFileDialogFull
            // 
            this.openFileDialogFull.FileName = "openFileDialogFull";
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 318);
            this.Controls.Add(this.buttonUploadFull);
            this.Controls.Add(this.buttonBrowseFull);
            this.Controls.Add(this.textBoxFull);
            this.Controls.Add(this.buttonUploadAbstract);
            this.Controls.Add(this.textBoxAbstract);
            this.Controls.Add(this.buttonBrowseAbstract);
            this.Controls.Add(this.dataGridViewProposals);
            this.Name = "UserAccount";
            this.Text = "UserAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProposals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProposals;
        private System.Windows.Forms.Button buttonBrowseAbstract;
        private System.Windows.Forms.TextBox textBoxAbstract;
        private System.Windows.Forms.Button buttonUploadAbstract;
        private System.Windows.Forms.TextBox textBoxFull;
        private System.Windows.Forms.Button buttonBrowseFull;
        private System.Windows.Forms.Button buttonUploadFull;
        private System.Windows.Forms.OpenFileDialog openFileDialogAbstract;
        private System.Windows.Forms.OpenFileDialog openFileDialogFull;
    }
}