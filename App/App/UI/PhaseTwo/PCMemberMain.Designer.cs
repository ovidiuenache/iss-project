namespace App.UI.PhaseTwo
{
    partial class PCMemberMain
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
            this.proposalListGridView = new System.Windows.Forms.DataGridView();
            this.ratingsGridView = new System.Windows.Forms.DataGridView();
            this.bidButton = new System.Windows.Forms.Button();
            this.rateButton = new System.Windows.Forms.Button();
            this.buttonRefreshReviews = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proposalListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // proposalListGridView
            // 
            this.proposalListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proposalListGridView.Location = new System.Drawing.Point(13, 13);
            this.proposalListGridView.Name = "proposalListGridView";
            this.proposalListGridView.Size = new System.Drawing.Size(194, 477);
            this.proposalListGridView.TabIndex = 0;
            // 
            // ratingsGridView
            // 
            this.ratingsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratingsGridView.Location = new System.Drawing.Point(345, 13);
            this.ratingsGridView.Name = "ratingsGridView";
            this.ratingsGridView.Size = new System.Drawing.Size(195, 477);
            this.ratingsGridView.TabIndex = 1;
            // 
            // bidButton
            // 
            this.bidButton.BackColor = System.Drawing.SystemColors.Control;
            this.bidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bidButton.Location = new System.Drawing.Point(233, 89);
            this.bidButton.Name = "bidButton";
            this.bidButton.Size = new System.Drawing.Size(94, 51);
            this.bidButton.TabIndex = 2;
            this.bidButton.Text = "Bid";
            this.bidButton.UseVisualStyleBackColor = false;
            this.bidButton.Click += new System.EventHandler(this.bidButton_Click);
            // 
            // rateButton
            // 
            this.rateButton.BackColor = System.Drawing.SystemColors.Control;
            this.rateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateButton.Location = new System.Drawing.Point(233, 184);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(94, 49);
            this.rateButton.TabIndex = 3;
            this.rateButton.Text = "Rate";
            this.rateButton.UseVisualStyleBackColor = false;
            this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
            // 
            // buttonRefreshReviews
            // 
            this.buttonRefreshReviews.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRefreshReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshReviews.Location = new System.Drawing.Point(233, 277);
            this.buttonRefreshReviews.Name = "buttonRefreshReviews";
            this.buttonRefreshReviews.Size = new System.Drawing.Size(94, 49);
            this.buttonRefreshReviews.TabIndex = 4;
            this.buttonRefreshReviews.Text = "Refresh";
            this.buttonRefreshReviews.UseVisualStyleBackColor = false;
            this.buttonRefreshReviews.Click += new System.EventHandler(this.buttonRefreshReviews_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(233, 353);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(94, 49);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // PCMemberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 502);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonRefreshReviews);
            this.Controls.Add(this.rateButton);
            this.Controls.Add(this.bidButton);
            this.Controls.Add(this.ratingsGridView);
            this.Controls.Add(this.proposalListGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(568, 541);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(568, 541);
            this.Name = "PCMemberMain";
            this.ShowIcon = false;
            this.Text = "PCMemberMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PCMemberMain_FormClosing);
            this.Load += new System.EventHandler(this.PCMemberMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proposalListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView proposalListGridView;
        private System.Windows.Forms.DataGridView ratingsGridView;
        private System.Windows.Forms.Button bidButton;
        private System.Windows.Forms.Button rateButton;
        private System.Windows.Forms.Button buttonRefreshReviews;
        private System.Windows.Forms.Button buttonLogout;
    }
}