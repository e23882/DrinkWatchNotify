using Notifications.Wpf;
using System;
using System.Threading;
using System.Windows;

namespace Watchdog
{
    public class MainWindowViewModel:ViewModelBase
    {
        #region Declarations
        public bool KeepRunning = true;
        #endregion

        #region Property
        public RelayCommand ButtonClickCommand 
        {
            get 
            {
                return new RelayCommand(ButtonClickCommandAction); 
            }
        }

        public RelayCommand WindowCloseCommand
        {
            get 
            {
                KeepRunning = false;
                return new RelayCommand(ButtonClickCommandAction);
            }
        }
        

        private void ButtonClickCommandAction(object obj)
        {
            ((App)Application.Current).ShowMessage("Test", "hello", NotificationType.Error);
            ((App)Application.Current).ShowMessage("Test", "hello", NotificationType.Information);
            ((App)Application.Current).ShowMessage("Test", "hello", NotificationType.Success);
            ((App)Application.Current).ShowMessage("Test", "hello", NotificationType.Warning);
            ((App)Application.Current).ShowMessage("該喝一杯水增加飽足感減肥了", "一天要瘦0.1公斤", NotificationType.Error);
            ((App)Application.Current).ShowMessage("該喝一杯水增加飽足感減肥了", "一天要瘦0.1公斤", NotificationType.Information);
            ((App)Application.Current).ShowMessage("該喝一杯水增加飽足感減肥了", "一天要瘦0.1公斤", NotificationType.Success);
            ((App)Application.Current).ShowMessage("該喝一杯水增加飽足感減肥了", "一天要瘦0.1公斤", NotificationType.Warning);
        }


        
        #endregion

        #region Memberfunction
        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindowViewModel() 
        {
            Thread th = new Thread(Run);
            th.Start();
        }

        private void Run()
        {
            while (KeepRunning) 
            {
                var currentDateTime= DateTime.Now;
                var currentHr = currentDateTime.ToString("HH");
                var currentMin = currentDateTime.ToString("mm");
                //11.30
                if(currentHr.Equals("11") && currentMin.Equals("30")) 
                    Notify();

                //13.30
                if (currentHr.Equals("13") && currentMin.Equals("30"))
                    Notify();

                //15.30
                if (currentHr.Equals("15") && currentMin.Equals("30"))
                    Notify();

                //17.30
                if (currentHr.Equals("17") && currentMin.Equals("30"))
                    Notify();

                Thread.Sleep(1000 * 15);
            }
        }

        private void Notify()
        {
            ((App)Application.Current).ShowMessage("該喝一杯水減肥了", "一天要瘦0.1公斤", NotificationType.Error);
            ((App)Application.Current).ShowMessage("該喝一杯水減肥了", "一天要瘦0.1公斤", NotificationType.Information);
            ((App)Application.Current).ShowMessage("該喝一杯水減肥了", "一天要瘦0.1公斤", NotificationType.Success);
            ((App)Application.Current).ShowMessage("該喝一杯水減肥了", "一天要瘦0.1公斤", NotificationType.Warning);
            ((App)Application.Current).ShowMessage("該喝一杯水減肥了", "一天要瘦0.1公斤", NotificationType.Error);
            ((App)Application.Current).ShowMessage("該喝一杯水減肥了", "一天要瘦0.1公斤", NotificationType.Information);
            ((App)Application.Current).ShowMessage("該喝一杯水減肥了", "一天要瘦0.1公斤", NotificationType.Success);
            ((App)Application.Current).ShowMessage("該喝一杯水減肥了", "一天要瘦0.1公斤", NotificationType.Warning);
        }
        #endregion
    }
}
