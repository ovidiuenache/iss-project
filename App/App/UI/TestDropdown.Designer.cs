namespace App.UI
{
    partial class TestDropdown
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
            this.cbcl = new App.UI.ComboBoxCheckedList();
            this.buttonSurprise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbcl
            // 
            this.cbcl.CheckOnClick = true;
            this.cbcl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbcl.DropDownHeight = 1;
            this.cbcl.FormattingEnabled = true;
            this.cbcl.IntegralHeight = false;
            this.cbcl.Location = new System.Drawing.Point(31, 35);
            this.cbcl.Name = "cbcl";
            this.cbcl.Size = new System.Drawing.Size(510, 23);
            this.cbcl.TabIndex = 4;
            this.cbcl.ValueSeparator = ", ";
            this.cbcl.SelectedIndexChanged += new System.EventHandler(this.cbcl_SelectedIndexChanged);
            // 
            // buttonSurprise
            // 
            this.buttonSurprise.Location = new System.Drawing.Point(603, 245);
            this.buttonSurprise.Name = "buttonSurprise";
            this.buttonSurprise.Size = new System.Drawing.Size(117, 49);
            this.buttonSurprise.TabIndex = 5;
            this.buttonSurprise.Text = "Surprise";
            this.buttonSurprise.UseVisualStyleBackColor = true;
            this.buttonSurprise.Click += new System.EventHandler(this.buttonSurprise_Click);
            // 
            // TestDropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 324);
            this.Controls.Add(this.buttonSurprise);
            this.Controls.Add(this.cbcl);
            this.Name = "TestDropdown";
            this.Text = "TestDropdown";
            this.Load += new System.EventHandler(this.TestDropdown_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBoxCheckedList cbcl;
        private System.Windows.Forms.Button buttonSurprise;
    }
}