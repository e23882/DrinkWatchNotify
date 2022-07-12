using System;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Watchdog
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Declarations
        private NotifyIcon notifyIcon = new NotifyIcon();
        private ContextMenu Cms = new ContextMenu();
        private MenuItem Mit = new MenuItem();
        private List<MenuItem> Mits = new List<MenuItem>();
        private readonly MainWindowViewModel _main;
        #endregion

        #region Memberfunction
        public MainWindow()
        {
            InitializeComponent();
            setMenuItem();
            setNotifyIcon();
            _main = new MainWindowViewModel();
            this.DataContext = _main;
        }
        #endregion

        private void setMenuItem()
        {
            Mit.Click += exit;
            Mit.Text = "EXIT";
            Mits.Add(Mit);
            Cms.MenuItems.AddRange(Mits.ToArray());
        }

        private void setNotifyIcon()
        {
            notifyIcon.ContextMenu = Cms;
            notifyIcon.Text = "喝水拉!";
            notifyIcon.Icon = new Icon("drink.ico", 40, 40);
            notifyIcon.Click += notifyIcon_Click;
            notifyIcon.Visible = true;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;            
            Hide();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (IsVisible)
            {
                Activate();
            }
            else
            {
                Show();
            }
        }

        private void exit(object sender, EventArgs e)
        {
            _main.KeepRunning = false;
            System.Environment.Exit(0);
        }

    }
}
