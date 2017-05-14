namespace App.UI
{
    partial class PreliminaryPhase
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
            this.buttonCreateConference = new System.Windows.Forms.Button();
            this.buttonUpdateConference = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelConferenceDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateConference
            // 
            this.buttonCreateConference.Location = new System.Drawing.Point(27, 108);
            this.buttonCreateConference.Name = "buttonCreateConference";
            this.buttonCreateConference.Size = new System.Drawing.Size(278, 43);
            this.buttonCreateConference.TabIndex = 0;
            this.buttonCreateConference.Text = "Create a Conference";
            this.buttonCreateConference.UseVisualStyleBackColor = true;
            this.buttonCreateConference.Visible = false;
            this.buttonCreateConference.Click += new System.EventHandler(this.buttonCreateConference_Click);
            // 
            // buttonUpdateConference
            // 
            this.buttonUpdateConference.Location = new System.Drawing.Point(27, 108);
            this.buttonUpdateConference.Name = "buttonUpdateConference";
            this.buttonUpdateConference.Size = new System.Drawing.Size(278, 43);
            this.buttonUpdateConference.TabIndex = 1;
            this.buttonUpdateConference.Text = "Update Conference Details";
            this.buttonUpdateConference.UseVisualStyleBackColor = true;
            this.buttonUpdateConference.Visible = false;
            this.buttonUpdateConference.Click += new System.EventHandler(this.buttonUpdateConference_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(24, 26);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(52, 13);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome";
            // 
            // labelConferenceDetails
            // 
            this.labelConferenceDetails.AutoSize = true;
            this.labelConferenceDetails.Location = new System.Drawing.Point(24, 63);
            this.labelConferenceDetails.Name = "labelConferenceDetails";
            this.labelConferenceDetails.Size = new System.Drawing.Size(281, 13);
            this.labelConferenceDetails.TabIndex = 3;
            this.labelConferenceDetails.Text = "A conference has been created is waiting to be submitted!";
            // 
            // Preliminary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 173);
            this.Controls.Add(this.labelConferenceDetails);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonUpdateConference);
            this.Controls.Add(this.buttonCreateConference);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preliminary";
            this.ShowIcon = false;
            this.Text = "Preliminary Phase";
            this.Load += new System.EventHandler(this.Preliminary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateConference;
        private System.Windows.Forms.Button buttonUpdateConference;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelConferenceDetails;
    }
}