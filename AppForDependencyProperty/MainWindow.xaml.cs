using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppForDependencyProperty
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _pathImage;

        public string PathImage
        {
            get
            {
                return this._pathImage;
            }

            set
            {
                this._pathImage = value;

                this.RaisePropertyChangedEvent(nameof(PathImage));
            }
        }

        /// <summary>
        /// Declaration of INotifyPropertyChanged PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Implementation of INotifyPropertyChanged onPropertyChange event
        /// </summary>
        /// <param name="propertyName">Changed property name</param>
        protected virtual void RaisePropertyChangedEvent(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Property for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(myControl.Data.ToString());
        }

        /// <summary>
        /// Property for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpClick(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(myControl.Data.ToString());
        }

        /// <summary>
        /// Property for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDownClick(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(myControl.Data.ToString());
        }
        
        /// <summary>
        /// Property for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewImageClick(object sender, RoutedEventArgs e)
        {
            this.PathImage = @"C:\Users\LEX\Downloads\_1.bmp";
        }

        private void getImagePath()
        {

        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            DataContext = this;

            this.PathImage = @"C:\Users\LEX\Downloads\_1.bmp";

            InitializeComponent();
        }
    }
}
