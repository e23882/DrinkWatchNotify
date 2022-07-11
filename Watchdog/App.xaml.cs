using Notifications.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Watchdog
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        public void ShowMessage(string title, string message, NotificationType type)
        {
            var notificationManager = new NotificationManager();
            var ts = new TimeSpan(2, 40, 0) - new TimeSpan(1, 30, 0);
            //notificationManager.Show(message, "提醒喝水減肥", null, null);
            notificationManager.Show(new NotificationContent
            {
                Title = title,
                Message = message,
                Type = type,
            }, "", ts);

        }
    }
}
