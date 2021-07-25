//using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ScrollingMessage
{
    class Publisher
    {
        // publisher's name
        public string PublisherName { get; private set; }

        // publisher's notification interval
        public int NotificationInterval { get; private set; }

        // declare a delegate function
        public delegate void Notify(Publisher p, NotificationEvent e);
        // declare a variable of the delegate with event keyword
        public event Notify OnPublish;
        public Publisher(string _publisherName, int _notificationInterval)
        {
            PublisherName = _publisherName;
            NotificationInterval = _notificationInterval;
        }

        //publish function publishes a Notification Event
        public void Publish()
        {
            while (true)
            {

                Thread.Sleep(NotificationInterval); // fire event after certain interval

                if (OnPublish != null)
                {
                    NotificationEvent notificationObj = new NotificationEvent(DateTime.Now, "New Notification Arrived from");
                    OnPublish(this, notificationObj);
                }
                Thread.Yield();
            }
        }
    }
}
