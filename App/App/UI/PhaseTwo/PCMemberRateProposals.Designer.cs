namespace App.UI.PhaseTwo
{
    partial class PCMemberRateProposals
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
            this.commentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.strongAccceptButton = new System.Windows.Forms.RadioButton();
            this.acceptRadioButton = new System.Windows.Forms.RadioButton();
            this.weakAcceptRadioButton = new System.Windows.Forms.RadioButton();
            this.borderlineRadioButton = new System.Windows.Forms.RadioButton();
            this.weakRejectRadioButton = new System.Windows.Forms.RadioButton();
            this.rejectRadioButton = new System.Windows.Forms.RadioButton();
            this.strongRejectRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proposalsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // proposalsDataGridView
            // 
            this.proposalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proposalsDataGridView.Location = new System.Drawing.Point(13, 13);
            this.proposalsDataGridView.MultiSelect = false;
            this.proposalsDataGridView.Name = "proposalsDataGridView";
            this.proposalsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proposalsDataGridView.Size = new System.Drawing.Size(219, 490);
            this.proposalsDataGridView.TabIndex = 0;
            this.proposalsDataGridView.SelectionChanged += new System.EventHandler(this.proposalsDataGridView_SelectionChanged);
            // 
            // commentsRichTextBox
            // 
            this.commentsRichTextBox.Location = new System.Drawing.Point(249, 13);
            this.commentsRichTextBox.Name = "commentsRichTextBox";
            this.commentsRichTextBox.Size = new System.Drawing.Size(207, 229);
            this.commentsRichTextBox.TabIndex = 1;
            this.commentsRichTextBox.Text = "Comments";
            // 
            // strongAccceptButton
            // 
            this.strongAccceptButton.AutoSize = true;
            this.strongAccceptButton.Location = new System.Drawing.Point(249, 260);
            this.strongAccceptButton.Name = "strongAccceptButton";
            this.strongAccceptButton.Size = new System.Drawing.Size(92, 17);
            this.strongAccceptButton.TabIndex = 2;
            this.strongAccceptButton.TabStop = true;
            this.strongAccceptButton.Text = "Strong accept";
            this.strongAccceptButton.UseVisualStyleBackColor = true;
            // 
            // acceptRadioButton
            // 
            this.acceptRadioButton.AutoSize = true;
            this.acceptRadioButton.Location = new System.Drawing.Point(249, 284);
            this.acceptRadioButton.Name = "acceptRadioButton";
            this.acceptRadioButton.Size = new System.Drawing.Size(59, 17);
            this.acceptRadioButton.TabIndex = 3;
            this.acceptRadioButton.TabStop = true;
            this.acceptRadioButton.Text = "Accept";
            this.acceptRadioButton.UseVisualStyleBackColor = true;
            // 
            // weakAcceptRadioButton
            // 
            this.weakAcceptRadioButton.AutoSize = true;
            this.weakAcceptRadioButton.Location = new System.Drawing.Point(249, 308);
            this.weakAcceptRadioButton.Name = "weakAcceptRadioButton";
            this.weakAcceptRadioButton.Size = new System.Drawing.Size(90, 17);
            this.weakAcceptRadioButton.TabIndex = 4;
            this.weakAcceptRadioButton.TabStop = true;
            this.weakAcceptRadioButton.Text = "Weak accept";
            this.weakAcceptRadioButton.UseVisualStyleBackColor = true;
            // 
            // borderlineRadioButton
            // 
            this.borderlineRadioButton.AutoSize = true;
            this.borderlineRadioButton.Location = new System.Drawing.Point(249, 332);
            this.borderlineRadioButton.Name = "borderlineRadioButton";
            this.borderlineRadioButton.Size = new System.Drawing.Size(102, 17);
            this.borderlineRadioButton.TabIndex = 5;
            this.borderlineRadioButton.TabStop = true;
            this.borderlineRadioButton.Text = "Borderline paper";
            this.borderlineRadioButton.UseVisualStyleBackColor = true;
            // 
            // weakRejectRadioButton
            // 
            this.weakRejectRadioButton.AutoSize = true;
            this.weakRejectRadioButton.Location = new System.Drawing.Point(249, 356);
            this.weakRejectRadioButton.Name = "weakRejectRadioButton";
            this.weakRejectRadioButton.Size = new System.Drawing.Size(83, 17);
            this.weakRejectRadioButton.TabIndex = 6;
            this.weakRejectRadioButton.TabStop = true;
            this.weakRejectRadioButton.Text = "Weak reject";
            this.weakRejectRadioButton.UseVisualStyleBackColor = true;
            // 
            // rejectRadioButton
            // 
            this.rejectRadioButton.AutoSize = true;
            this.rejectRadioButton.Location = new System.Drawing.Point(249, 380);
            this.rejectRadioButton.Name = "rejectRadioButton";
            this.rejectRadioButton.Size = new System.Drawing.Size(56, 17);
            this.rejectRadioButton.TabIndex = 7;
            this.rejectRadioButton.TabStop = true;
            this.rejectRadioButton.Text = "Reject";
            this.rejectRadioButton.UseVisualStyleBackColor = true;
            // 
            // strongRejectRadioButton
            // 
            this.strongRejectRadioButton.AutoSize = true;
            this.strongRejectRadioButton.Location = new System.Drawing.Point(249, 404);
            this.strongRejectRadioButton.Name = "strongRejectRadioButton";
            this.strongRejectRadioButton.Size = new System.Drawing.Size(85, 17);
            this.strongRejectRadioButton.TabIndex = 8;
            this.strongRejectRadioButton.TabStop = true;
            this.strongRejectRadioButton.Text = "Strong reject";
            this.strongRejectRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.Control;
            this.submitButton.Location = new System.Drawing.Point(249, 451);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(95, 37);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(361, 451);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(95, 37);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PCMemberRateProposals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 515);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strongRejectRadioButton);
            this.Controls.Add(this.rejectRadioButton);
            this.Controls.Add(this.weakRejectRadioButton);
            this.Controls.Add(this.borderlineRadioButton);
            this.Controls.Add(this.weakAcceptRadioButton);
            this.Controls.Add(this.acceptRadioButton);
            this.Controls.Add(this.strongAccceptButton);
            this.Controls.Add(this.commentsRichTextBox);
            this.Controls.Add(this.proposalsDataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(484, 554);
            this.Name = "PCMemberRateProposals";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PCMemberRateProposals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PCMemberRateProposals_FormClosing);
            this.Load += new System.EventHandler(this.PCMemberRateProposals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proposalsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proposalsDataGridView;
        private System.Windows.Forms.RichTextBox commentsRichTextBox;
        private System.Windows.Forms.RadioButton strongAccceptButton;
        private System.Windows.Forms.RadioButton acceptRadioButton;
        private System.Windows.Forms.RadioButton weakAcceptRadioButton;
        private System.Windows.Forms.RadioButton borderlineRadioButton;
        private System.Windows.Forms.RadioButton weakRejectRadioButton;
        private System.Windows.Forms.RadioButton rejectRadioButton;
        private System.Windows.Forms.RadioButton strongRejectRadioButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button buttonBack;
    }
}