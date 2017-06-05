namespace App.UI
{
    partial class MetaInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKeywords = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimePickerAnPublicare = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAuthors = new App.UI.ComboBoxCheckedList();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Authors:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxKeywords
            // 
            this.textBoxKeywords.Location = new System.Drawing.Point(107, 68);
            this.textBoxKeywords.Name = "textBoxKeywords";
            this.textBoxKeywords.Size = new System.Drawing.Size(183, 20);
            this.textBoxKeywords.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(28, 177);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(262, 33);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(25, 142);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(32, 13);
            this.labelData.TabIndex = 9;
            this.labelData.Text = "Year:";
            // 
            // dateTimePickerAnPublicare
            // 
            this.dateTimePickerAnPublicare.Location = new System.Drawing.Point(107, 136);
            this.dateTimePickerAnPublicare.Name = "dateTimePickerAnPublicare";
            this.dateTimePickerAnPublicare.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerAnPublicare.TabIndex = 10;
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.CheckOnClick = true;
            this.comboBoxAuthors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxAuthors.DropDownHeight = 1;
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.IntegralHeight = false;
            this.comboBoxAuthors.Location = new System.Drawing.Point(107, 102);
            this.comboBoxAuthors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(183, 21);
            this.comboBoxAuthors.TabIndex = 11;
            this.comboBoxAuthors.ValueSeparator = ", ";
            // 
            // MetaInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 229);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.dateTimePickerAnPublicare);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxKeywords);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 268);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 268);
            this.Name = "MetaInformation";
            this.ShowIcon = false;
            this.Text = "Meta Information";
            this.Load += new System.EventHandler(this.MetaInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxKeywords;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnPublicare;
        private ComboBoxCheckedList comboBoxAuthors;
    }
}