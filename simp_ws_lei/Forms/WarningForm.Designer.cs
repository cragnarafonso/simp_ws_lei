namespace simp_ws_lei.Forms
{
    partial class WarningForm
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
            this.WarningLabel = new System.Windows.Forms.Label();
            this.WarningHeaderPanel = new System.Windows.Forms.Panel();
            this.WarningCmbBox = new System.Windows.Forms.ComboBox();
            this.WarningBodyPanel = new System.Windows.Forms.Panel();
            this.WarningHeaderPanel.SuspendLayout();
            this.WarningBodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Tomato;
            this.WarningLabel.Location = new System.Drawing.Point(12, 22);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(146, 19);
            this.WarningLabel.TabIndex = 0;
            this.WarningLabel.Text = "Warning Interface";
            // 
            // WarningHeaderPanel
            // 
            this.WarningHeaderPanel.Controls.Add(this.WarningCmbBox);
            this.WarningHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.WarningHeaderPanel.Name = "WarningHeaderPanel";
            this.WarningHeaderPanel.Size = new System.Drawing.Size(441, 38);
            this.WarningHeaderPanel.TabIndex = 1;
            // 
            // WarningCmbBox
            // 
            this.WarningCmbBox.DropDownHeight = 200;
            this.WarningCmbBox.DropDownWidth = 106;
            this.WarningCmbBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.WarningCmbBox.FormattingEnabled = true;
            this.WarningCmbBox.IntegralHeight = false;
            this.WarningCmbBox.Location = new System.Drawing.Point(0, 4);
            this.WarningCmbBox.Name = "WarningCmbBox";
            this.WarningCmbBox.Size = new System.Drawing.Size(441, 29);
            this.WarningCmbBox.TabIndex = 0;
            // 
            // WarningBodyPanel
            // 
            this.WarningBodyPanel.Controls.Add(this.WarningLabel);
            this.WarningBodyPanel.Location = new System.Drawing.Point(0, 36);
            this.WarningBodyPanel.Name = "WarningBodyPanel";
            this.WarningBodyPanel.Size = new System.Drawing.Size(441, 490);
            this.WarningBodyPanel.TabIndex = 2;
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 526);
            this.Controls.Add(this.WarningBodyPanel);
            this.Controls.Add(this.WarningHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarningForm";
            this.Text = "WarningForm";
            this.WarningHeaderPanel.ResumeLayout(false);
            this.WarningBodyPanel.ResumeLayout(false);
            this.WarningBodyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Panel WarningHeaderPanel;
        public System.Windows.Forms.Panel WarningBodyPanel;
        public System.Windows.Forms.ComboBox WarningCmbBox;
    }
}