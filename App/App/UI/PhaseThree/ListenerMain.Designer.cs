namespace App.UI.PhaseThree
{
    partial class ListenerMain
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
            this.listBoxTopics = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTopics
            // 
            this.listBoxTopics.FormattingEnabled = true;
            this.listBoxTopics.ItemHeight = 16;
            this.listBoxTopics.Location = new System.Drawing.Point(19, 60);
            this.listBoxTopics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTopics.Name = "listBoxTopics";
            this.listBoxTopics.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTopics.Size = new System.Drawing.Size(423, 100);
            this.listBoxTopics.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick interesting sections for you";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(19, 180);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(424, 34);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm selections";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(19, 228);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.MaximumSize = new System.Drawing.Size(115, 53);
            this.buttonBack.MinimumSize = new System.Drawing.Size(115, 53);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 53);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ListenerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 288);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTopics);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(473, 335);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(473, 335);
            this.Name = "ListenerMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ListenerMain";
            this.Load += new System.EventHandler(this.ListenerMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTopics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button buttonBack;
    }
}