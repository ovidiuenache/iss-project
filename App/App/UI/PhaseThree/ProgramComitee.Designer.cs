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
            this.SuspendLayout();
            // 
            // btnSectionLeader
            // 
            this.btnSectionLeader.Location = new System.Drawing.Point(15, 130);
            this.btnSectionLeader.Name = "btnSectionLeader";
            this.btnSectionLeader.Size = new System.Drawing.Size(202, 52);
            this.btnSectionLeader.TabIndex = 0;
            this.btnSectionLeader.Text = "Pick section leader";
            this.btnSectionLeader.UseVisualStyleBackColor = true;
            this.btnSectionLeader.Click += new System.EventHandler(this.btnSectionLeader_Click);
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(12, 28);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSections.TabIndex = 1;
            this.comboBoxSections.SelectedIndexChanged += new System.EventHandler(this.comboBoxSections_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sections";
            // 
            // comboBoxComiteeMembers
            // 
            this.comboBoxComiteeMembers.FormattingEnabled = true;
            this.comboBoxComiteeMembers.Location = new System.Drawing.Point(12, 84);
            this.comboBoxComiteeMembers.Name = "comboBoxComiteeMembers";
            this.comboBoxComiteeMembers.Size = new System.Drawing.Size(137, 24);
            this.comboBoxComiteeMembers.TabIndex = 3;
            this.comboBoxComiteeMembers.SelectedIndexChanged += new System.EventHandler(this.comboBoxComiteeMembers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comitee Memebers";
            // 
            // ProgramComitee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxComiteeMembers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSections);
            this.Controls.Add(this.btnSectionLeader);
            this.Name = "ProgramComitee";
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
    }
}