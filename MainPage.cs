using System;
using System.Windows.Forms;

namespace AutomaticGradingBot
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            readHomeworks1.Visible = true;
            setModel1.Visible = false;
            seeResults1.Visible = false;
            sendResults1.Visible = false;
        }

        // Exit the application when the "X" button is clicked:
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Show the root page (readHomeworks):
        private void logo_Click(object sender, EventArgs e)
        {
            readHomeworks1.Visible = true;
            setModel1.Visible = false;
            seeResults1.Visible = false;
            sendResults1.Visible = false;
        }

        // Show the readHomeworks page:
        private void readEmailsButton_Click(object sender, EventArgs e)
        {
            readHomeworks1.Visible = true;
            setModel1.Visible = false;
            seeResults1.Visible = false;
            sendResults1.Visible = false;
        }

        // Show the setModel page:
        private void setModelButton_Click(object sender, EventArgs e)
        {
            readHomeworks1.Visible = false;
            setModel1.Visible = true;
            seeResults1.Visible = false;
            sendResults1.Visible = false;
        }

        // Show the results page:
        private void resultsButton_Click(object sender, EventArgs e)
        {
            readHomeworks1.Visible = false;
            setModel1.Visible = false;
            seeResults1.Visible = true;
            sendResults1.Visible = false;
        }

        // Show the sendResults page:
        private void sendResultsButton_Click(object sender, EventArgs e)
        {
            readHomeworks1.Visible = false;
            setModel1.Visible = false;
            seeResults1.Visible = false;
            sendResults1.Visible = true;
        }
    }
}
