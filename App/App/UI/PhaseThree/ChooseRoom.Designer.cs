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
            // ChooseRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 309);
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
    }
}