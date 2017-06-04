namespace App.UI.PhaseThree
{
    partial class RoomsDistribution
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
            this.btnPickSectionLeader = new System.Windows.Forms.Button();
            this.btnScheduleSetup = new System.Windows.Forms.Button();
            this.btnChooseRooms = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPickSectionLeader
            // 
            this.btnPickSectionLeader.BackColor = System.Drawing.SystemColors.Control;
            this.btnPickSectionLeader.Location = new System.Drawing.Point(93, 13);
            this.btnPickSectionLeader.Margin = new System.Windows.Forms.Padding(4);
            this.btnPickSectionLeader.Name = "btnPickSectionLeader";
            this.btnPickSectionLeader.Size = new System.Drawing.Size(172, 46);
            this.btnPickSectionLeader.TabIndex = 6;
            this.btnPickSectionLeader.Text = "Pick Section Leader";
            this.btnPickSectionLeader.UseVisualStyleBackColor = false;
            this.btnPickSectionLeader.Click += new System.EventHandler(this.btnPickSectionLeader_Click);
            // 
            // btnScheduleSetup
            // 
            this.btnScheduleSetup.BackColor = System.Drawing.SystemColors.Control;
            this.btnScheduleSetup.Location = new System.Drawing.Point(93, 90);
            this.btnScheduleSetup.Margin = new System.Windows.Forms.Padding(4);
            this.btnScheduleSetup.Name = "btnScheduleSetup";
            this.btnScheduleSetup.Size = new System.Drawing.Size(172, 46);
            this.btnScheduleSetup.TabIndex = 7;
            this.btnScheduleSetup.Text = "Schedule";
            this.btnScheduleSetup.UseVisualStyleBackColor = false;
            this.btnScheduleSetup.Click += new System.EventHandler(this.btnScheduleSetup_Click);
            // 
            // btnChooseRooms
            // 
            this.btnChooseRooms.BackColor = System.Drawing.SystemColors.Control;
            this.btnChooseRooms.Location = new System.Drawing.Point(93, 163);
            this.btnChooseRooms.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseRooms.Name = "btnChooseRooms";
            this.btnChooseRooms.Size = new System.Drawing.Size(172, 46);
            this.btnChooseRooms.TabIndex = 8;
            this.btnChooseRooms.Text = "Choose Rooms";
            this.btnChooseRooms.UseVisualStyleBackColor = false;
            this.btnChooseRooms.Click += new System.EventHandler(this.btnChooseRooms_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 255);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.MaximumSize = new System.Drawing.Size(115, 53);
            this.buttonBack.MinimumSize = new System.Drawing.Size(115, 53);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 53);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // RoomsDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 312);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.btnChooseRooms);
            this.Controls.Add(this.btnScheduleSetup);
            this.Controls.Add(this.btnPickSectionLeader);
            this.Name = "RoomsDistribution";
            this.Text = "RoomsDistribution";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPickSectionLeader;
        private System.Windows.Forms.Button btnScheduleSetup;
        private System.Windows.Forms.Button btnChooseRooms;
        private System.Windows.Forms.Button buttonBack;
    }
}