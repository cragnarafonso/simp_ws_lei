namespace simp_ws_lei.Forms
{
    partial class SeaForm
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
            this.SeaPanel = new System.Windows.Forms.Panel();
            this.SeaLabel = new System.Windows.Forms.Label();
            this.SeaHeaderPanel = new System.Windows.Forms.Panel();
            this.SeaCmbBox = new System.Windows.Forms.ComboBox();
            this.SeaPanel.SuspendLayout();
            this.SeaHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeaPanel
            // 
            this.SeaPanel.Controls.Add(this.SeaLabel);
            this.SeaPanel.Location = new System.Drawing.Point(0, 36);
            this.SeaPanel.Name = "SeaPanel";
            this.SeaPanel.Size = new System.Drawing.Size(441, 490);
            this.SeaPanel.TabIndex = 3;
            // 
            // SeaLabel
            // 
            this.SeaLabel.AutoSize = true;
            this.SeaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeaLabel.ForeColor = System.Drawing.Color.Tomato;
            this.SeaLabel.Location = new System.Drawing.Point(12, 22);
            this.SeaLabel.Name = "SeaLabel";
            this.SeaLabel.Size = new System.Drawing.Size(110, 19);
            this.SeaLabel.TabIndex = 0;
            this.SeaLabel.Text = "Sea Interface";
            // 
            // SeaHeaderPanel
            // 
            this.SeaHeaderPanel.Controls.Add(this.SeaCmbBox);
            this.SeaHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.SeaHeaderPanel.Name = "SeaHeaderPanel";
            this.SeaHeaderPanel.Size = new System.Drawing.Size(441, 38);
            this.SeaHeaderPanel.TabIndex = 4;
            // 
            // SeaCmbBox
            // 
            this.SeaCmbBox.DropDownHeight = 200;
            this.SeaCmbBox.DropDownWidth = 106;
            this.SeaCmbBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.SeaCmbBox.FormattingEnabled = true;
            this.SeaCmbBox.IntegralHeight = false;
            this.SeaCmbBox.Location = new System.Drawing.Point(0, 4);
            this.SeaCmbBox.Name = "SeaCmbBox";
            this.SeaCmbBox.Size = new System.Drawing.Size(441, 29);
            this.SeaCmbBox.TabIndex = 0;
            // 
            // SeaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 526);
            this.Controls.Add(this.SeaHeaderPanel);
            this.Controls.Add(this.SeaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeaForm";
            this.Text = "SeaForm";
            this.SeaPanel.ResumeLayout(false);
            this.SeaPanel.PerformLayout();
            this.SeaHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel SeaPanel;
        private System.Windows.Forms.Label SeaLabel;
        private System.Windows.Forms.Panel SeaHeaderPanel;
        public System.Windows.Forms.ComboBox SeaCmbBox;
    }
}