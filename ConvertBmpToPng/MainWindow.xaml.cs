using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConvertBmpToPng
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Get path property
        /// </summary>
        public string GetPath { get; set; }

        /// <summary>
        /// Main window default constructor
        /// </summary>
        public MainWindow()
        {
            this.DataContext = this;

            this.GetPath = this.IconPath();

            InitializeComponent();
        }

        //public void ConfertFunction()
        //{
        //    Bitmap bitmap = (Bitmap)pictureBox1.Image;
        //}

        /// <summary>
        /// Button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// Icon path function
        /// </summary>
        /// <returns></returns>
        public string IconPath()
        {
            return @"C:\Projects\Spotweld_New\Spotweld\BMP\Cursor.bmp";
        }
    }
}
