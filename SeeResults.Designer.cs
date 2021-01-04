namespace AutomaticGradingBot
{
    partial class SeeResults
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
            this.seeResultsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seeResultsTitle
            // 
            this.seeResultsTitle.AutoSize = true;
            this.seeResultsTitle.Font = new System.Drawing.Font("Lucida Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.seeResultsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(159)))));
            this.seeResultsTitle.Location = new System.Drawing.Point(280, 22);
            this.seeResultsTitle.Name = "seeResultsTitle";
            this.seeResultsTitle.Size = new System.Drawing.Size(94, 16);
            this.seeResultsTitle.TabIndex = 1;
            this.seeResultsTitle.Text = "See Results";
            // 
            // SeeResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.seeResultsTitle);
            this.Name = "SeeResults";
            this.Size = new System.Drawing.Size(725, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label seeResultsTitle;
    }
}
