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
            this.comboBoxSections.Location = new System.Drawing.Point(13, 48);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSections.TabIndex = 0;
            this.comboBoxSections.SelectedIndexChanged += new System.EventHandler(this.comboBoxSections_SelectedIndexChanged);
            // 
            // listBoxProposals
            // 
            this.listBoxProposals.FormattingEnabled = true;
            this.listBoxProposals.ItemHeight = 16;
            this.listBoxProposals.Location = new System.Drawing.Point(140, 48);
            this.listBoxProposals.Name = "listBoxProposals";
            this.listBoxProposals.Size = new System.Drawing.Size(270, 212);
            this.listBoxProposals.TabIndex = 1;
            // 
            // btnAddToSection
            // 
            this.btnAddToSection.Location = new System.Drawing.Point(299, 266);
            this.btnAddToSection.Name = "btnAddToSection";
            this.btnAddToSection.Size = new System.Drawing.Size(111, 34);
            this.btnAddToSection.TabIndex = 2;
            this.btnAddToSection.Text = "Add to section";
            this.btnAddToSection.UseVisualStyleBackColor = true;
            this.btnAddToSection.Click += new System.EventHandler(this.btnAddToSection_Click);
            // 
            // btnChooseRoom
            // 
            this.btnChooseRoom.Location = new System.Drawing.Point(345, 307);
            this.btnChooseRoom.Name = "btnChooseRoom";
            this.btnChooseRoom.Size = new System.Drawing.Size(137, 48);
            this.btnChooseRoom.TabIndex = 3;
            this.btnChooseRoom.Text = "Submit";
            this.btnChooseRoom.UseVisualStyleBackColor = true;
            this.btnChooseRoom.Click += new System.EventHandler(this.btnChooseRoom_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(178, 307);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(137, 48);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // CreateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 367);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.btnChooseRoom);
            this.Controls.Add(this.btnAddToSection);
            this.Controls.Add(this.listBoxProposals);
            this.Controls.Add(this.comboBoxSections);
            this.Name = "CreateSchedule";
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