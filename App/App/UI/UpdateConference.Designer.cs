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
            this.listBoxTopics = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelTopics = new System.Windows.Forms.Label();
            this.labelCommitee = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxCheckedListUpdate = new App.UI.ComboBoxCheckedList();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(32, 527);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 53);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(200, 527);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(271, 53);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Update Conference";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // listBoxTopics
            // 
            this.listBoxTopics.FormattingEnabled = true;
            this.listBoxTopics.ItemHeight = 16;
            this.listBoxTopics.Items.AddRange(new object[] {
            "Politics",
            "Environment",
            "Cars",
            "IT",
            "Technology",
            "Gaming",
            "Family"});
            this.listBoxTopics.Location = new System.Drawing.Point(200, 183);
            this.listBoxTopics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxTopics.Name = "listBoxTopics";
            this.listBoxTopics.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTopics.Size = new System.Drawing.Size(269, 260);
            this.listBoxTopics.TabIndex = 31;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(200, 55);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2017, 5, 5, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(269, 22);
            this.dateTimePicker.TabIndex = 30;
            this.dateTimePicker.Value = new System.DateTime(2017, 5, 5, 18, 45, 22, 0);
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(200, 470);
            this.textBoxFee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.Size = new System.Drawing.Size(269, 22);
            this.textBoxFee.TabIndex = 29;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(200, 17);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(269, 22);
            this.textBoxName.TabIndex = 28;
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(28, 474);
            this.labelFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(117, 17);
            this.labelFee.TabIndex = 27;
            this.labelFee.Text = "Conference Fee: ";
            // 
            // labelTopics
            // 
            this.labelTopics.AutoSize = true;
            this.labelTopics.Location = new System.Drawing.Point(28, 183);
            this.labelTopics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTopics.Name = "labelTopics";
            this.labelTopics.Size = new System.Drawing.Size(58, 17);
            this.labelTopics.TabIndex = 26;
            this.labelTopics.Text = "Topics: ";
            // 
            // labelCommitee
            // 
            this.labelCommitee.AutoSize = true;
            this.labelCommitee.Location = new System.Drawing.Point(28, 118);
            this.labelCommitee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCommitee.Name = "labelCommitee";
            this.labelCommitee.Size = new System.Drawing.Size(140, 17);
            this.labelCommitee.TabIndex = 25;
            this.labelCommitee.Text = "Commitee Members: ";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(28, 64);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(75, 17);
            this.labelEndDate.TabIndex = 24;
            this.labelEndDate.Text = "End Date: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 21);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 17);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name: ";
            // 
            // comboBoxCheckedListUpdate
            // 
            this.comboBoxCheckedListUpdate.CheckOnClick = true;
            this.comboBoxCheckedListUpdate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCheckedListUpdate.DropDownHeight = 1;
            this.comboBoxCheckedListUpdate.FormattingEnabled = true;
            this.comboBoxCheckedListUpdate.IntegralHeight = false;
            this.comboBoxCheckedListUpdate.Location = new System.Drawing.Point(200, 115);
            this.comboBoxCheckedListUpdate.Name = "comboBoxCheckedListUpdate";
            this.comboBoxCheckedListUpdate.Size = new System.Drawing.Size(269, 23);
            this.comboBoxCheckedListUpdate.TabIndex = 33;
            this.comboBoxCheckedListUpdate.ValueSeparator = ", ";
            // 
            // UpdateConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 592);
            this.Controls.Add(this.comboBoxCheckedListUpdate);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(519, 639);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(519, 639);
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
        private System.Windows.Forms.ListBox listBoxTopics;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelTopics;
        private System.Windows.Forms.Label labelCommitee;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelName;
        private ComboBoxCheckedList comboBoxCheckedListUpdate;
    }
}