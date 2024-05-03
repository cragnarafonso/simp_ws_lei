namespace simp_ws_lei.Forms
{
    partial class HomeForm
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
            this.HomeHeaderPanel = new System.Windows.Forms.Panel();
            this.HomeCmbBox = new System.Windows.Forms.ComboBox();
            this.HomeBodyPanel = new System.Windows.Forms.Panel();
            this.HomeHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeHeaderPanel
            // 
            this.HomeHeaderPanel.Controls.Add(this.HomeCmbBox);
            this.HomeHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeHeaderPanel.Name = "HomeHeaderPanel";
            this.HomeHeaderPanel.Size = new System.Drawing.Size(441, 38);
            this.HomeHeaderPanel.TabIndex = 0;
            // 
            // HomeCmbBox
            // 
            this.HomeCmbBox.DropDownHeight = 200;
            this.HomeCmbBox.DropDownWidth = 106;
            this.HomeCmbBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeCmbBox.FormattingEnabled = true;
            this.HomeCmbBox.IntegralHeight = false;
            this.HomeCmbBox.Location = new System.Drawing.Point(0, 4);
            this.HomeCmbBox.Name = "HomeCmbBox";
            this.HomeCmbBox.Size = new System.Drawing.Size(441, 29);
            this.HomeCmbBox.TabIndex = 0;
            this.HomeCmbBox.SelectedIndexChanged += new System.EventHandler(this.HomeCmbBox_SelectedIndexChanged);
            // 
            // HomeBodyPanel
            // 
            this.HomeBodyPanel.AutoScroll = true;
            this.HomeBodyPanel.Location = new System.Drawing.Point(0, 36);
            this.HomeBodyPanel.Name = "HomeBodyPanel";
            this.HomeBodyPanel.Size = new System.Drawing.Size(441, 490);
            this.HomeBodyPanel.TabIndex = 1;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 526);
            this.Controls.Add(this.HomeBodyPanel);
            this.Controls.Add(this.HomeHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomeForm";
            this.HomeHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox HomeCmbBox;
        private System.Windows.Forms.Panel HomeHeaderPanel;
        public System.Windows.Forms.Panel HomeBodyPanel;
    }
}