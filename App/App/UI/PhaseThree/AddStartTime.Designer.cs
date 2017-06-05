namespace App.UI.PhaseThree
{
    partial class AddStartTime
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
            this.labelProposalTitle = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.dateTimePickerProposalTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelProposalTitle
            // 
            this.labelProposalTitle.AutoSize = true;
            this.labelProposalTitle.Location = new System.Drawing.Point(11, 28);
            this.labelProposalTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProposalTitle.Name = "labelProposalTitle";
            this.labelProposalTitle.Size = new System.Drawing.Size(35, 13);
            this.labelProposalTitle.TabIndex = 0;
            this.labelProposalTitle.Text = "label1";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(14, 86);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(148, 29);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // dateTimePickerProposalTime
            // 
            this.dateTimePickerProposalTime.Location = new System.Drawing.Point(14, 53);
            this.dateTimePickerProposalTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerProposalTime.Name = "dateTimePickerProposalTime";
            this.dateTimePickerProposalTime.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerProposalTime.TabIndex = 1;
            // 
            // AddStartTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 128);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dateTimePickerProposalTime);
            this.Controls.Add(this.labelProposalTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(199, 167);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(199, 167);
            this.Name = "AddStartTime";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddStartTime";
            this.Load += new System.EventHandler(this.AddStartTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProposalTitle;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DateTimePicker dateTimePickerProposalTime;
    }
}