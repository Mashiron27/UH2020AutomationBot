namespace AutomaticGradingBot
{
    partial class SetModel
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
            this.setModelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setModelTitle
            // 
            this.setModelTitle.AutoSize = true;
            this.setModelTitle.Font = new System.Drawing.Font("Lucida Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.setModelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(159)))));
            this.setModelTitle.Location = new System.Drawing.Point(290, 18);
            this.setModelTitle.Name = "setModelTitle";
            this.setModelTitle.Size = new System.Drawing.Size(82, 16);
            this.setModelTitle.TabIndex = 1;
            this.setModelTitle.Text = "Set Model";
            // 
            // SetModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.setModelTitle);
            this.Name = "SetModel";
            this.Size = new System.Drawing.Size(725, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label setModelTitle;
    }
}
