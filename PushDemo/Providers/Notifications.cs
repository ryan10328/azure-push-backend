using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.NotificationHubs;

namespace PushDemo.Providers
{
    public class Notifications
    {
        private const string DefaultSharedAccessSignature =
            "Endpoint=sb://ryan-push.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=ZP8bIg8JxTJ63TkjAV0kHajp+1309UthGSJhiSOzB0k=";

        private const string HubName = "ryan-push";

        public static Notifications Instance = new Notifications();

        public NotificationHubClient Hub { get; set; }

        private Notifications()
        {
            // DefaultSharedAccessSignature, HubName
            Hub = NotificationHubClient.CreateClientFromConnectionString(DefaultSharedAccessSignature, HubName);
        }
    }
}