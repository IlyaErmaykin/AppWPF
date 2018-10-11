using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AppForDependencyProperty
{
    class MyImageControl : Canvas
    {
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(Image),
                typeof(MyImageControl)
                //new UIPropertyMetadata(null, new PropertyChangedCallback(MyImageControl.CurrentImageChanged))
                );

        public Image Image
        {
            get
            {
                return (Image)this.GetValue(MyImageControl.ImageProperty);
            }

            set
            {
                this.SetValue(MyImageControl.ImageProperty, value);
            }
        }

        private static void CurrentImageChanged(DependencyProperty depObj, DependencyPropertyChangedEventArgs args)
        {
            //if (args.OldValue != args.NewValue)
            //{
            //    //var
            //}
        }
    }
}
