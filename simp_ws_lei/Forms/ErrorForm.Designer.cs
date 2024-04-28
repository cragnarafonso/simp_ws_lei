namespace simp_ws_lei.Forms
{
    partial class ErrorForm
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
            this.ErrorMsgLabel = new System.Windows.Forms.Label();
            this.ErrorPicbox = new System.Windows.Forms.PictureBox();
            this.OKErrorBtt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorMsgLabel
            // 
            this.ErrorMsgLabel.AutoSize = true;
            this.ErrorMsgLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsgLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ErrorMsgLabel.Location = new System.Drawing.Point(1, 81);
            this.ErrorMsgLabel.Name = "ErrorMsgLabel";
            this.ErrorMsgLabel.Size = new System.Drawing.Size(37, 17);
            this.ErrorMsgLabel.TabIndex = 1;
            this.ErrorMsgLabel.Text = "error";
            // 
            // ErrorPicbox
            // 
            this.ErrorPicbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ErrorPicbox.Image = global::simp_ws_lei.Properties.Resources.arquivo_corrompido;
            this.ErrorPicbox.ImageLocation = "";
            this.ErrorPicbox.Location = new System.Drawing.Point(5, 3);
            this.ErrorPicbox.Name = "ErrorPicbox";
            this.ErrorPicbox.Size = new System.Drawing.Size(65, 65);
            this.ErrorPicbox.TabIndex = 0;
            this.ErrorPicbox.TabStop = false;
            // 
            // OKErrorBtt
            // 
            this.OKErrorBtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKErrorBtt.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.OKErrorBtt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OKErrorBtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.OKErrorBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKErrorBtt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKErrorBtt.Location = new System.Drawing.Point(223, 118);
            this.OKErrorBtt.Name = "OKErrorBtt";
            this.OKErrorBtt.Size = new System.Drawing.Size(75, 30);
            this.OKErrorBtt.TabIndex = 2;
            this.OKErrorBtt.Text = "Ok";
            this.OKErrorBtt.UseVisualStyleBackColor = true;
            this.OKErrorBtt.Click += new System.EventHandler(this.OKErrorBtt_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.OKErrorBtt);
            this.Controls.Add(this.ErrorMsgLabel);
            this.Controls.Add(this.ErrorPicbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ErrorMsgLabel;
        private System.Windows.Forms.PictureBox ErrorPicbox;
        private System.Windows.Forms.Button OKErrorBtt;
    }
}