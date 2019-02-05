using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppWPF
{
    /// <summary>
    /// Логика взаимодействия для ChildWindow.xaml
    /// </summary>
    public partial class ChildView : Window
    {
        /// <summary>
        /// Default constructor;
        /// </summary>
        public ChildView()
        {
            this.DataContext = this;

            InitializeComponent();

            MainWindow mWindow = this.Owner as MainWindow;
        }

        /// <summary>
        /// ExitWindow;
        /// </summary>
        public void CloseWindow()
        {
            this.Close();
        }

        /// <summary>
        /// Exit window button click event;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ExitWindowButton_Click(object sender, RoutedEventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Executed close window event;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Executed_CloseWindow(object sender, ExecutedRoutedEventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Can executed close window event;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CanExecuted_CloseWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
