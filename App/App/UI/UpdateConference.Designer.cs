namespace App.UI
{
    partial class UpdateConference
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxTopics = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelTopics = new System.Windows.Forms.Label();
            this.labelCommitee = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(24, 428);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(86, 43);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(150, 428);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(203, 43);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Update Conference";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 32;
            // 
            // listBoxTopics
            // 
            this.listBoxTopics.FormattingEnabled = true;
            this.listBoxTopics.Items.AddRange(new object[] {
            "Politics",
            "Environment",
            "Cars",
            "IT",
            "Technology",
            "Gaming",
            "Family"});
            this.listBoxTopics.Location = new System.Drawing.Point(150, 149);
            this.listBoxTopics.Name = "listBoxTopics";
            this.listBoxTopics.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTopics.Size = new System.Drawing.Size(203, 212);
            this.listBoxTopics.TabIndex = 31;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(150, 45);
            this.dateTimePicker.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2017, 5, 5, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker.TabIndex = 30;
            this.dateTimePicker.Value = new System.DateTime(2017, 5, 5, 18, 45, 22, 0);
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(150, 382);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.Size = new System.Drawing.Size(203, 20);
            this.textBoxFee.TabIndex = 29;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 14);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(203, 20);
            this.textBoxName.TabIndex = 28;
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(21, 385);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(89, 13);
            this.labelFee.TabIndex = 27;
            this.labelFee.Text = "Conference Fee: ";
            // 
            // labelTopics
            // 
            this.labelTopics.AutoSize = true;
            this.labelTopics.Location = new System.Drawing.Point(21, 149);
            this.labelTopics.Name = "labelTopics";
            this.labelTopics.Size = new System.Drawing.Size(45, 13);
            this.labelTopics.TabIndex = 26;
            this.labelTopics.Text = "Topics: ";
            // 
            // labelCommitee
            // 
            this.labelCommitee.AutoSize = true;
            this.labelCommitee.Location = new System.Drawing.Point(21, 96);
            this.labelCommitee.Name = "labelCommitee";
            this.labelCommitee.Size = new System.Drawing.Size(105, 13);
            this.labelCommitee.TabIndex = 25;
            this.labelCommitee.Text = "Commitee Members: ";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(21, 52);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(58, 13);
            this.labelEndDate.TabIndex = 24;
            this.labelEndDate.Text = "End Date: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name: ";
            // 
            // UpdateConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 489);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxTopics);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.labelTopics);
            this.Controls.Add(this.labelCommitee);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 528);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 528);
            this.Name = "UpdateConference";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Update Conference";
            this.Load += new System.EventHandler(this.UpdateConferenceUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxTopics;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelTopics;
        private System.Windows.Forms.Label labelCommitee;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelName;
    }
}