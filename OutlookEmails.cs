﻿using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;

namespace AutomaticGradingBot
{
    public class OutlookEmails
    {
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public static List<OutlookEmails> ReadMailItems()
        {
            Application outlookApplication = null;
            NameSpace outlookNameSpace = null;
            MAPIFolder inboxFolder = null;

            Items mailItems = null;
            List<OutlookEmails> listEmailDetails = new List<OutlookEmails>();
            OutlookEmails emailDetails;

            try
            {
                outlookApplication = new Application();
                outlookNameSpace = outlookApplication.GetNamespace("MAPI");
                inboxFolder = outlookNameSpace.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
                mailItems = inboxFolder.Items;
                foreach(MailItem item in mailItems)
                {
                    emailDetails = new OutlookEmails();
                    emailDetails.EmailFrom = item.SenderEmailAddress;
                    emailDetails.EmailSubject = item.Subject;
                    emailDetails.EmailBody = item.Body;
                    listEmailDetails.Add(emailDetails);
                    ReleaseComObject(item);
                }
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ReleaseComObject(mailItems);
                ReleaseComObject(inboxFolder);
                ReleaseComObject(outlookNameSpace);
                ReleaseComObject(outlookApplication);
            }

            return listEmailDetails;
        }

        private static void ReleaseComObject(object obj)
        {
            if(obj != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
        }
    }
}
