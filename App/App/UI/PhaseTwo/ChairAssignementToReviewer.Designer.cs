namespace App.UI.PhaseTwo
{
    partial class ChairAssignementToReviewer
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
            this.proposalsDataGridView = new System.Windows.Forms.DataGridView();
            this.reviewersDataGridView = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proposalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // proposalsDataGridView
            // 
            this.proposalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proposalsDataGridView.Location = new System.Drawing.Point(13, 13);
            this.proposalsDataGridView.Name = "proposalsDataGridView";
            this.proposalsDataGridView.Size = new System.Drawing.Size(189, 494);
            this.proposalsDataGridView.TabIndex = 0;
            // 
            // reviewersDataGridView
            // 
            this.reviewersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewersDataGridView.Location = new System.Drawing.Point(227, 13);
            this.reviewersDataGridView.Name = "reviewersDataGridView";
            this.reviewersDataGridView.Size = new System.Drawing.Size(200, 360);
            this.reviewersDataGridView.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.submitButton.Location = new System.Drawing.Point(260, 435);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(115, 30);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ChairAssignementToReviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 519);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.reviewersDataGridView);
            this.Controls.Add(this.proposalsDataGridView);
            this.Name = "ChairAssignementToReviewer";
            this.Text = "ChairAssignementToReviewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChairAssignementToReviewer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.proposalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView proposalsDataGridView;
        private System.Windows.Forms.DataGridView reviewersDataGridView;
        private System.Windows.Forms.Button submitButton;
    }
}