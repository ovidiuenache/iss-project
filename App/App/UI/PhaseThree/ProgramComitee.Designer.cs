namespace App.UI.PhaseThree
{
    partial class ProgramComitee
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
            this.btnSectionLeader = new System.Windows.Forms.Button();
            this.comboBoxSections = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxComiteeMembers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSectionLeader
            // 
            this.btnSectionLeader.Location = new System.Drawing.Point(14, 75);
            this.btnSectionLeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSectionLeader.Name = "btnSectionLeader";
            this.btnSectionLeader.Size = new System.Drawing.Size(115, 37);
            this.btnSectionLeader.TabIndex = 0;
            this.btnSectionLeader.Text = "Pick section leader";
            this.btnSectionLeader.UseVisualStyleBackColor = true;
            this.btnSectionLeader.Click += new System.EventHandler(this.btnSectionLeader_Click);
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(144, 6);
            this.comboBoxSections.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(104, 21);
            this.comboBoxSections.TabIndex = 1;
            this.comboBoxSections.SelectedIndexChanged += new System.EventHandler(this.comboBoxSections_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sections";
            // 
            // comboBoxComiteeMembers
            // 
            this.comboBoxComiteeMembers.FormattingEnabled = true;
            this.comboBoxComiteeMembers.Location = new System.Drawing.Point(144, 35);
            this.comboBoxComiteeMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxComiteeMembers.Name = "comboBoxComiteeMembers";
            this.comboBoxComiteeMembers.Size = new System.Drawing.Size(104, 21);
            this.comboBoxComiteeMembers.TabIndex = 3;
            this.comboBoxComiteeMembers.SelectedIndexChanged += new System.EventHandler(this.comboBoxComiteeMembers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comitee Memebers";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.Control;
            this.submitButton.Location = new System.Drawing.Point(149, 75);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(99, 37);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(14, 122);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(234, 42);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ProgramComitee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 176);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxComiteeMembers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSections);
            this.Controls.Add(this.btnSectionLeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(276, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(276, 215);
            this.Name = "ProgramComitee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProgramComitee";
            this.Load += new System.EventHandler(this.ProgramComitee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSectionLeader;
        private System.Windows.Forms.ComboBox comboBoxSections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxComiteeMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button buttonBack;
    }
}