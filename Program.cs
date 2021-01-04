using System;
using System.Windows.Forms;

namespace AutomaticGradingBot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());

            // Logic for the reading of the emails:
            var mails = OutlookEmails.ReadMailItems();
            int i = 1;
            foreach(var mail in mails)
            {
                Console.WriteLine("Mail No. " + i);
                Console.WriteLine("Mail Received from  " + mail.EmailFrom);
                Console.WriteLine("Mail Subject " + mail.EmailSubject);
                Console.WriteLine("Mail Body " + mail.EmailBody);
                Console.WriteLine("");
                i += 1;
            }
            Console.ReadKey();
        }
    }
}
