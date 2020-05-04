using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XF_Login.Droid
{

    public static class Constants
    {
        public const string ListenConnectionString = "<Endpoint=sb://humsubnotif.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=J202ZY+EBFweAdwTs046Q45Kf9jyep6SPXY/YyVLZZE=>";
        public const string NotificationHubName = "<Humsub>";
    }

    public class Page1 : ContentPage
    {
        public Page1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}