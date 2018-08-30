﻿using System;
using System.Collections.Generic;
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

namespace AppWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            childWindow = new ChildWindow();
            //childWindow.Owner = this;

            //OwnerFunction();
            //closeChildWindow();
        }
        ChildWindow childWindow;

        public void runChildWindow()
        {
            //MessageBox.Show(childWindow.Getmessage());
            //childWindow.Show();

            OwnerFunction();
        }

        public void closeChildWindow()
        {
            //MessageBox.Show(childWindow.Getmessage());
            childWindow.Close();
        }

        private void BtnNewWindow_Click(object sender, RoutedEventArgs e)
        {
            runChildWindow();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Size pSize = this.RenderSize;

            Size maxAllowed = new Size(pSize.Width - this.Left, pSize.Height - this.Top);

            //Изменение размера дочернего окна, если оно выходит за рамки
            if (this.Height > maxAllowed.Height)
                this.Height = maxAllowed.Height;

            if (this.Width > maxAllowed.Width)
                this.Width = maxAllowed.Width;
        }

        public void OwnerFunction()
        {
            ChildWindow window = new ChildWindow();
            window.Owner = this;
            window.Title = "ChildWindow";
            window.Show();
        }
    }
}
