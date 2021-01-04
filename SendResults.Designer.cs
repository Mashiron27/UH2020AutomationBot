namespace AutomaticGradingBot
{
    partial class SendResults
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendResultsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendResultsTitle
            // 
            this.sendResultsTitle.AutoSize = true;
            this.sendResultsTitle.Font = new System.Drawing.Font("Lucida Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.sendResultsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(159)))));
            this.sendResultsTitle.Location = new System.Drawing.Point(276, 17);
            this.sendResultsTitle.Name = "sendResultsTitle";
            this.sendResultsTitle.Size = new System.Drawing.Size(103, 16);
            this.sendResultsTitle.TabIndex = 0;
            this.sendResultsTitle.Text = "Send Results";
            // 
            // SendResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.sendResultsTitle);
            this.Name = "SendResults";
            this.Size = new System.Drawing.Size(725, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sendResultsTitle;
    }
}
