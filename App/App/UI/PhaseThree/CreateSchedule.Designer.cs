namespace App.UI.PhaseThree
{
    partial class CreateSchedule
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
            this.comboBoxSections = new System.Windows.Forms.ComboBox();
            this.listBoxProposals = new System.Windows.Forms.ListBox();
            this.btnAddToSection = new System.Windows.Forms.Button();
            this.btnChooseRoom = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(15, 26);
            this.comboBoxSections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSections.TabIndex = 0;
            this.comboBoxSections.SelectedIndexChanged += new System.EventHandler(this.comboBoxSections_SelectedIndexChanged);
            // 
            // listBoxProposals
            // 
            this.listBoxProposals.FormattingEnabled = true;
            this.listBoxProposals.ItemHeight = 16;
            this.listBoxProposals.Location = new System.Drawing.Point(15, 71);
            this.listBoxProposals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxProposals.Name = "listBoxProposals";
            this.listBoxProposals.Size = new System.Drawing.Size(463, 148);
            this.listBoxProposals.TabIndex = 1;
            this.listBoxProposals.SelectedIndexChanged += new System.EventHandler(this.listBoxProposals_SelectedIndexChanged);
            // 
            // btnAddToSection
            // 
            this.btnAddToSection.Location = new System.Drawing.Point(15, 244);
            this.btnAddToSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToSection.Name = "btnAddToSection";
            this.btnAddToSection.Size = new System.Drawing.Size(464, 34);
            this.btnAddToSection.TabIndex = 2;
            this.btnAddToSection.Text = "Add to section";
            this.btnAddToSection.UseVisualStyleBackColor = true;
            this.btnAddToSection.Click += new System.EventHandler(this.btnAddToSection_Click);
            // 
            // btnChooseRoom
            // 
            this.btnChooseRoom.Location = new System.Drawing.Point(252, 305);
            this.btnChooseRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseRoom.Name = "btnChooseRoom";
            this.btnChooseRoom.Size = new System.Drawing.Size(227, 48);
            this.btnChooseRoom.TabIndex = 3;
            this.btnChooseRoom.Text = "Submit";
            this.btnChooseRoom.UseVisualStyleBackColor = true;
            this.btnChooseRoom.Click += new System.EventHandler(this.btnChooseRoom_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(15, 304);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(227, 48);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // CreateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 357);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.btnChooseRoom);
            this.Controls.Add(this.btnAddToSection);
            this.Controls.Add(this.listBoxProposals);
            this.Controls.Add(this.comboBoxSections);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 404);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 404);
            this.Name = "CreateSchedule";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateSchedule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSections;
        private System.Windows.Forms.ListBox listBoxProposals;
        private System.Windows.Forms.Button btnAddToSection;
        private System.Windows.Forms.Button btnChooseRoom;
        private System.Windows.Forms.Button buttonBack;
    }
}