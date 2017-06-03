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
            this.buttonBrowseAbstract = new System.Windows.Forms.Button();
            this.textBoxAbstract = new System.Windows.Forms.TextBox();
            this.buttonUploadAbstract = new System.Windows.Forms.Button();
            this.textBoxFull = new System.Windows.Forms.TextBox();
            this.buttonBrowseFull = new System.Windows.Forms.Button();
            this.buttonUploadFull = new System.Windows.Forms.Button();
            this.openFileDialogAbstract = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogFull = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewProposals = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProposals)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowseAbstract
            // 
            this.buttonBrowseAbstract.Location = new System.Drawing.Point(276, 334);
            this.buttonBrowseAbstract.Name = "buttonBrowseAbstract";
            this.buttonBrowseAbstract.Size = new System.Drawing.Size(109, 23);
            this.buttonBrowseAbstract.TabIndex = 1;
            this.buttonBrowseAbstract.Text = "Browse...";
            this.buttonBrowseAbstract.UseVisualStyleBackColor = true;
            this.buttonBrowseAbstract.Click += new System.EventHandler(this.buttonBrowseAbstract_Click);
            // 
            // textBoxAbstract
            // 
            this.textBoxAbstract.Location = new System.Drawing.Point(64, 336);
            this.textBoxAbstract.Name = "textBoxAbstract";
            this.textBoxAbstract.Size = new System.Drawing.Size(206, 20);
            this.textBoxAbstract.TabIndex = 2;
            // 
            // buttonUploadAbstract
            // 
            this.buttonUploadAbstract.Location = new System.Drawing.Point(450, 327);
            this.buttonUploadAbstract.Name = "buttonUploadAbstract";
            this.buttonUploadAbstract.Size = new System.Drawing.Size(324, 36);
            this.buttonUploadAbstract.TabIndex = 3;
            this.buttonUploadAbstract.Text = "Upload Abstract";
            this.buttonUploadAbstract.UseVisualStyleBackColor = true;
            this.buttonUploadAbstract.Click += new System.EventHandler(this.buttonUploadAbstract_Click);
            // 
            // textBoxFull
            // 
            this.textBoxFull.Location = new System.Drawing.Point(64, 380);
            this.textBoxFull.Name = "textBoxFull";
            this.textBoxFull.Size = new System.Drawing.Size(206, 20);
            this.textBoxFull.TabIndex = 4;
            // 
            // buttonBrowseFull
            // 
            this.buttonBrowseFull.Location = new System.Drawing.Point(276, 377);
            this.buttonBrowseFull.Name = "buttonBrowseFull";
            this.buttonBrowseFull.Size = new System.Drawing.Size(109, 23);
            this.buttonBrowseFull.TabIndex = 5;
            this.buttonBrowseFull.Text = "Browse...";
            this.buttonBrowseFull.UseVisualStyleBackColor = true;
            this.buttonBrowseFull.Click += new System.EventHandler(this.buttonBrowseFull_Click);
            // 
            // buttonUploadFull
            // 
            this.buttonUploadFull.Location = new System.Drawing.Point(450, 372);
            this.buttonUploadFull.Name = "buttonUploadFull";
            this.buttonUploadFull.Size = new System.Drawing.Size(324, 35);
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
            // dataGridViewProposals
            // 
            this.dataGridViewProposals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProposals.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewProposals.Name = "dataGridViewProposals";
            this.dataGridViewProposals.Size = new System.Drawing.Size(762, 237);
            this.dataGridViewProposals.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(762, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(450, 418);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(324, 35);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(64, 418);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(321, 35);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh Proposals";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 465);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUploadFull);
            this.Controls.Add(this.buttonBrowseFull);
            this.Controls.Add(this.textBoxFull);
            this.Controls.Add(this.buttonUploadAbstract);
            this.Controls.Add(this.textBoxAbstract);
            this.Controls.Add(this.buttonBrowseAbstract);
            this.Controls.Add(this.dataGridViewProposals);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(735, 458);
            this.Name = "UserAccount";
            this.ShowIcon = false;
            this.Text = "Phase One";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserAccount_FormClosing);
            this.Load += new System.EventHandler(this.UserAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProposals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBrowseAbstract;
        private System.Windows.Forms.TextBox textBoxAbstract;
        private System.Windows.Forms.Button buttonUploadAbstract;
        private System.Windows.Forms.TextBox textBoxFull;
        private System.Windows.Forms.Button buttonBrowseFull;
        private System.Windows.Forms.Button buttonUploadFull;
        private System.Windows.Forms.OpenFileDialog openFileDialogAbstract;
        private System.Windows.Forms.OpenFileDialog openFileDialogFull;
        private System.Windows.Forms.DataGridView dataGridViewProposals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonRefresh;
    }
}