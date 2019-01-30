using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Left button click event;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftBtnNewWindow_Click(object sender, RoutedEventArgs e)
        {
            createNewWindow();
            SetTimerInterripts();
        }

        /// <summary>
        /// Rigth button click event;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightBtnNewWindow_Click(object sender, RoutedEventArgs e)
        {
            createNewWindow();
        }

        /// <summary>
        /// Child window field;
        /// </summary>
        ChildView childWindow;

        /// <summary>
        /// Create new window function;
        /// </summary>
        private void createNewWindow()
        {
            if (childWindow == null)  // || childWindow.IsDisposed
            {
                childWindow = new ChildView();
                childWindow.Show();
            }
            else
            {
                childWindow.Close();
                childWindow = new ChildView();
                childWindow.Show();
            }
        }

        /// <summary>
        /// Close owner window function;
        /// </summary>
        private void closeWindow()
        {
            if (childWindow != null)
            {
                childWindow.Close();
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        }

        /// <summary>
        /// Executed new comand event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Executed_New(object sender, ExecutedRoutedEventArgs e)
        {
            createNewWindow();
            SetTimerInterripts();
        }

        /// <summary>
        /// Can executed new comand event;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CanExecuted_New(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        // Не то(...
        //System.Timers.Timer gTimerFlag = new System.Timers.Timer();

        //private void SetTimerInterrupts()
        //{
        //    gTimerFlag.Enabled = false;
        //    gTimerFlag.Interval = 500 * g.TIME_1_MSEC;
        //    gTimerFlag.Elapsed += new System.Timers.ElapsedEventHandler(TimerFlag_Elased);
        //    gTimerFlag.SynchronizingObject = this;
        //}

        //private void TimerFlag_Elased(object sender, ElapsedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Timer for window field;
        /// </summary>
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

        /// <summary>
        /// Set timer interripts function;
        /// </summary>
        private void SetTimerInterripts()
        {
            timer.IsEnabled = false;
            timer.Interval = TimeSpan.FromMilliseconds(3000); //Таймера на 3 секунды;
            timer.Tick += OnTimerTick;
            timer.Start(); //Запуск тамера
        }

        /// <summary>
        /// On timer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimerTick(object sender, EventArgs e)
        {
            if (timer.IsEnabled)
                UpdateTimerState(false);
            closeWindow();
        }

        /// <summary>
        /// Update timer state function;
        /// </summary>
        /// <param name="enabled"></param>
        private void UpdateTimerState(bool enabled)
        {
            timer.IsEnabled = enabled;
        }
    }
}
