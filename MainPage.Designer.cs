namespace AutomaticGradingBot
{
    partial class MainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Button();
            this.readEmailsButton = new System.Windows.Forms.Button();
            this.setModelButton = new System.Windows.Forms.Button();
            this.resultsButton = new System.Windows.Forms.Button();
            this.sendResultsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendResults1 = new AutomaticGradingBot.SendResults();
            this.seeResults1 = new AutomaticGradingBot.SeeResults();
            this.setModel1 = new AutomaticGradingBot.SetModel();
            this.readHomeworks1 = new AutomaticGradingBot.ReadHomeworks();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sendResultsButton);
            this.panel1.Controls.Add(this.resultsButton);
            this.panel1.Controls.Add(this.setModelButton);
            this.panel1.Controls.Add(this.readEmailsButton);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 646);
            this.panel1.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logo.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(159)))));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(219, 76);
            this.logo.TabIndex = 1;
            this.logo.Text = "Automatic Grading Bot";
            this.logo.UseVisualStyleBackColor = true;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // readEmailsButton
            // 
            this.readEmailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readEmailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.readEmailsButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readEmailsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(159)))));
            this.readEmailsButton.Location = new System.Drawing.Point(0, 169);
            this.readEmailsButton.Name = "readEmailsButton";
            this.readEmailsButton.Size = new System.Drawing.Size(219, 76);
            this.readEmailsButton.TabIndex = 2;
            this.readEmailsButton.Text = "Read Homeworks";
            this.readEmailsButton.UseVisualStyleBackColor = true;
            this.readEmailsButton.Click += new System.EventHandler(this.readEmailsButton_Click);
            // 
            // setModelButton
            // 
            this.setModelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setModelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setModelButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setModelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(159)))));
            this.setModelButton.Location = new System.Drawing.Point(0, 262);
            this.setModelButton.Name = "setModelButton";
            this.setModelButton.Size = new System.Drawing.Size(219, 76);
            this.setModelButton.TabIndex = 3;
            this.setModelButton.Text = "Set Model";
            this.setModelButton.UseVisualStyleBackColor = true;
            this.setModelButton.Click += new System.EventHandler(this.setModelButton_Click);
            // 
            // resultsButton
            // 
            this.resultsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultsButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(159)))));
            this.resultsButton.Location = new System.Drawing.Point(0, 356);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(219, 76);
            this.resultsButton.TabIndex = 4;
            this.resultsButton.Text = "See Results";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // sendResultsButton
            // 
            this.sendResultsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendResultsButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendResultsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(159)))));
            this.sendResultsButton.Location = new System.Drawing.Point(0, 450);
            this.sendResultsButton.Name = "sendResultsButton";
            this.sendResultsButton.Size = new System.Drawing.Size(219, 76);
            this.sendResultsButton.TabIndex = 5;
            this.sendResultsButton.Text = "Send Results";
            this.sendResultsButton.UseVisualStyleBackColor = true;
            this.sendResultsButton.Click += new System.EventHandler(this.sendResultsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(132)))), ((int)(((byte)(159)))));
            this.exitButton.Location = new System.Drawing.Point(945, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(43, 30);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.readHomeworks1);
            this.panel2.Controls.Add(this.setModel1);
            this.panel2.Controls.Add(this.seeResults1);
            this.panel2.Controls.Add(this.sendResults1);
            this.panel2.Location = new System.Drawing.Point(250, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 568);
            this.panel2.TabIndex = 7;
            // 
            // sendResults1
            // 
            this.sendResults1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.sendResults1.Location = new System.Drawing.Point(0, 0);
            this.sendResults1.Name = "sendResults1";
            this.sendResults1.Size = new System.Drawing.Size(725, 568);
            this.sendResults1.TabIndex = 0;
            // 
            // seeResults1
            // 
            this.seeResults1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.seeResults1.Location = new System.Drawing.Point(0, 0);
            this.seeResults1.Name = "seeResults1";
            this.seeResults1.Size = new System.Drawing.Size(725, 568);
            this.seeResults1.TabIndex = 1;
            // 
            // setModel1
            // 
            this.setModel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.setModel1.Location = new System.Drawing.Point(0, 0);
            this.setModel1.Name = "setModel1";
            this.setModel1.Size = new System.Drawing.Size(725, 568);
            this.setModel1.TabIndex = 2;
            // 
            // readHomeworks1
            // 
            this.readHomeworks1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.readHomeworks1.Location = new System.Drawing.Point(0, 0);
            this.readHomeworks1.Name = "readHomeworks1";
            this.readHomeworks1.Size = new System.Drawing.Size(725, 568);
            this.readHomeworks1.TabIndex = 3;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(119)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logo;
        private System.Windows.Forms.Button sendResultsButton;
        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.Button setModelButton;
        private System.Windows.Forms.Button readEmailsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel2;
        private SendResults sendResults1;
        private ReadHomeworks readHomeworks1;
        private SetModel setModel1;
        private SeeResults seeResults1;
    }
}

