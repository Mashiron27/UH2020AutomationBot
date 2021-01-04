namespace AutomaticGradingBot
{
    partial class ReadHomeworks
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
            this.readHomeworksTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readHomeworksTitle
            // 
            this.readHomeworksTitle.AutoSize = true;
            this.readHomeworksTitle.Font = new System.Drawing.Font("Lucida Sans", 10.25F, System.Drawing.FontStyle.Bold);
            this.readHomeworksTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(159)))));
            this.readHomeworksTitle.Location = new System.Drawing.Point(273, 21);
            this.readHomeworksTitle.Name = "readHomeworksTitle";
            this.readHomeworksTitle.Size = new System.Drawing.Size(134, 16);
            this.readHomeworksTitle.TabIndex = 1;
            this.readHomeworksTitle.Text = "Read Homeworks";
            // 
            // ReadHomeworks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.readHomeworksTitle);
            this.Name = "ReadHomeworks";
            this.Size = new System.Drawing.Size(725, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label readHomeworksTitle;
    }
}
