namespace simp_ws_lei
{
    partial class mainWsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWsForm));
            this.mainHeaderPanel = new System.Windows.Forms.Panel();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.headerCloseBtt = new System.Windows.Forms.Button();
            this.mainFooterPanel = new System.Windows.Forms.Panel();
            this.footerClamBtt = new System.Windows.Forms.Button();
            this.footerSeaBtt = new System.Windows.Forms.Button();
            this.footerWarningBtt = new System.Windows.Forms.Button();
            this.footerHomeBtt = new System.Windows.Forms.Button();
            this.mainBodyPanel = new System.Windows.Forms.Panel();
            this.mainHeaderPanel.SuspendLayout();
            this.mainFooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainHeaderPanel
            // 
            this.mainHeaderPanel.Controls.Add(this.headerTitleLabel);
            this.mainHeaderPanel.Controls.Add(this.headerCloseBtt);
            this.mainHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.mainHeaderPanel.Name = "mainHeaderPanel";
            this.mainHeaderPanel.Size = new System.Drawing.Size(457, 43);
            this.mainHeaderPanel.TabIndex = 0;
            // 
            // headerTitleLabel
            // 
            this.headerTitleLabel.AutoSize = true;
            this.headerTitleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTitleLabel.Location = new System.Drawing.Point(12, 8);
            this.headerTitleLabel.Name = "headerTitleLabel";
            this.headerTitleLabel.Size = new System.Drawing.Size(193, 28);
            this.headerTitleLabel.TabIndex = 5;
            this.headerTitleLabel.Text = "Weather Station";
            // 
            // headerCloseBtt
            // 
            this.headerCloseBtt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.headerCloseBtt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.headerCloseBtt.FlatAppearance.BorderSize = 0;
            this.headerCloseBtt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.headerCloseBtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.headerCloseBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerCloseBtt.Image = ((System.Drawing.Image)(resources.GetObject("headerCloseBtt.Image")));
            this.headerCloseBtt.Location = new System.Drawing.Point(423, 8);
            this.headerCloseBtt.Name = "headerCloseBtt";
            this.headerCloseBtt.Size = new System.Drawing.Size(25, 25);
            this.headerCloseBtt.TabIndex = 4;
            this.headerCloseBtt.UseVisualStyleBackColor = true;
            // 
            // mainFooterPanel
            // 
            this.mainFooterPanel.Controls.Add(this.footerClamBtt);
            this.mainFooterPanel.Controls.Add(this.footerSeaBtt);
            this.mainFooterPanel.Controls.Add(this.footerWarningBtt);
            this.mainFooterPanel.Controls.Add(this.footerHomeBtt);
            this.mainFooterPanel.Location = new System.Drawing.Point(0, 603);
            this.mainFooterPanel.Name = "mainFooterPanel";
            this.mainFooterPanel.Size = new System.Drawing.Size(457, 61);
            this.mainFooterPanel.TabIndex = 1;
            // 
            // footerClamBtt
            // 
            this.footerClamBtt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.footerClamBtt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.footerClamBtt.FlatAppearance.BorderSize = 0;
            this.footerClamBtt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.footerClamBtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.footerClamBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.footerClamBtt.Image = ((System.Drawing.Image)(resources.GetObject("footerClamBtt.Image")));
            this.footerClamBtt.Location = new System.Drawing.Point(349, 2);
            this.footerClamBtt.Name = "footerClamBtt";
            this.footerClamBtt.Size = new System.Drawing.Size(106, 58);
            this.footerClamBtt.TabIndex = 6;
            this.footerClamBtt.UseVisualStyleBackColor = true;
            // 
            // footerSeaBtt
            // 
            this.footerSeaBtt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.footerSeaBtt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.footerSeaBtt.FlatAppearance.BorderSize = 0;
            this.footerSeaBtt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.footerSeaBtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.footerSeaBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.footerSeaBtt.Image = ((System.Drawing.Image)(resources.GetObject("footerSeaBtt.Image")));
            this.footerSeaBtt.Location = new System.Drawing.Point(233, 2);
            this.footerSeaBtt.Name = "footerSeaBtt";
            this.footerSeaBtt.Size = new System.Drawing.Size(116, 58);
            this.footerSeaBtt.TabIndex = 5;
            this.footerSeaBtt.UseVisualStyleBackColor = true;
            // 
            // footerWarningBtt
            // 
            this.footerWarningBtt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.footerWarningBtt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.footerWarningBtt.FlatAppearance.BorderSize = 0;
            this.footerWarningBtt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.footerWarningBtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.footerWarningBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.footerWarningBtt.Image = ((System.Drawing.Image)(resources.GetObject("footerWarningBtt.Image")));
            this.footerWarningBtt.Location = new System.Drawing.Point(118, 2);
            this.footerWarningBtt.Name = "footerWarningBtt";
            this.footerWarningBtt.Size = new System.Drawing.Size(115, 58);
            this.footerWarningBtt.TabIndex = 4;
            this.footerWarningBtt.UseVisualStyleBackColor = true;
            // 
            // footerHomeBtt
            // 
            this.footerHomeBtt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.footerHomeBtt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.footerHomeBtt.FlatAppearance.BorderSize = 0;
            this.footerHomeBtt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.footerHomeBtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.footerHomeBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.footerHomeBtt.Image = ((System.Drawing.Image)(resources.GetObject("footerHomeBtt.Image")));
            this.footerHomeBtt.Location = new System.Drawing.Point(2, 2);
            this.footerHomeBtt.Name = "footerHomeBtt";
            this.footerHomeBtt.Size = new System.Drawing.Size(116, 58);
            this.footerHomeBtt.TabIndex = 3;
            this.footerHomeBtt.UseVisualStyleBackColor = true;
            // 
            // mainBodyPanel
            // 
            this.mainBodyPanel.Location = new System.Drawing.Point(0, 42);
            this.mainBodyPanel.Name = "mainBodyPanel";
            this.mainBodyPanel.Size = new System.Drawing.Size(457, 565);
            this.mainBodyPanel.TabIndex = 2;
            // 
            // mainWsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 663);
            this.Controls.Add(this.mainBodyPanel);
            this.Controls.Add(this.mainFooterPanel);
            this.Controls.Add(this.mainHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainWsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Station";
            this.mainHeaderPanel.ResumeLayout(false);
            this.mainHeaderPanel.PerformLayout();
            this.mainFooterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainHeaderPanel;
        private System.Windows.Forms.Panel mainFooterPanel;
        private System.Windows.Forms.Button footerClamBtt;
        private System.Windows.Forms.Button footerSeaBtt;
        private System.Windows.Forms.Button footerWarningBtt;
        private System.Windows.Forms.Button footerHomeBtt;
        private System.Windows.Forms.Button headerCloseBtt;
        private System.Windows.Forms.Label headerTitleLabel;
        private System.Windows.Forms.Panel mainBodyPanel;
    }
}

