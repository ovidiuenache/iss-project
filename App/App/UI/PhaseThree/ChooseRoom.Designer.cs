namespace App.UI.PhaseThree
{
    partial class ChooseRoom
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
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRoomName = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(12, 29);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSections.TabIndex = 0;
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Location = new System.Drawing.Point(183, 56);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(147, 22);
            this.textBoxRoomName.TabIndex = 1;
            this.textBoxRoomName.TextChanged += new System.EventHandler(this.textBoxRoomName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room name";
            // 
            // btnAddRoomName
            // 
            this.btnAddRoomName.Location = new System.Drawing.Point(242, 96);
            this.btnAddRoomName.Name = "btnAddRoomName";
            this.btnAddRoomName.Size = new System.Drawing.Size(88, 28);
            this.btnAddRoomName.TabIndex = 3;
            this.btnAddRoomName.Text = "Add";
            this.btnAddRoomName.UseVisualStyleBackColor = true;
            this.btnAddRoomName.Click += new System.EventHandler(this.btnAddRoomName_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(90, 248);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(137, 48);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(258, 248);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 48);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ChooseRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 309);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.btnAddRoomName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.comboBoxSections);
            this.Name = "ChooseRoom";
            this.Text = "ChooseRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSections;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRoomName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button btnSubmit;
    }
}