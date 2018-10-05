using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppForDependencyProperty
{
    /// <summary>
    /// My control custom class
    /// </summary>
    class MyControl : FrameworkElement
    {
        /// <summary>
        /// Data reference dependency property registration
        /// </summary>
        public static DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(int), typeof(MyControl));

        /// <summary>
        /// Data reference dependency property
        /// </summary>
        public int Data
        {
            get
            {
                return (int) GetValue(DataProperty);
            }

            set
            {
                SetValue(DataProperty, value);
            }
        }
    }
}
