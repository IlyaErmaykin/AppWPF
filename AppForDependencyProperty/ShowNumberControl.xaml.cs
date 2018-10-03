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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppForDependencyProperty
{
    /// <summary>
    /// Логика взаимодействия для ShowNumberControl.xaml
    /// Logic of interaction for ShowNumberControl.xaml
    /// </summary>
    public partial class ShowNumberControl : UserControl
    {
        /// <summary>
        /// Default contructor
        /// </summary>
        public ShowNumberControl()
        {
            InitializeComponent();
        }

        // Свойство зависимости (CLR)
        public int MyProperty
        {
            get { return (int)GetValue(CurrentNumberProperty); }
            set { SetValue(CurrentNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        // Обратите внимание на второй параметр конструктора UIPropertyMetadata
        public static readonly DependencyProperty CurrentNumberProperty =
            DependencyProperty.Register("CurrentNumber", typeof(int),
                typeof(ShowNumberControl),
                new UIPropertyMetadata(100,
                    new PropertyChangedCallback(CurrentNumberChanged)),
                new ValidateValueCallback(ValidateCurrentNumber)
            );

        /// <summary>
        /// Validate current number function
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ValidateCurrentNumber(object value)
        {
            // Очень простое бизнес-правило: значение должно находиться в диапазоне между 0 и 500
            if (Convert.ToInt32(value) >= 0 && Convert.ToInt32(value) <= 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Current number changed function
        /// </summary>
        /// <param name="depObj"></param>
        /// <param name="args"></param>
        private static void CurrentNumberChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs args)
        {
            // Привести DependencyObject к ShowNumbeControl
            ShowNumberControl showNumberControl = (ShowNumberControl)depObj;

            // Получить элемент Label в ShowNumberControl
            Label theLabel = showNumberControl.numberDisplay;

            // Установить для Label новое значение
            theLabel.Content = args.NewValue.ToString();
        }

        // Обычное свойство .NET
        /// <summary>
        /// Currentr number field
        /// </summary>
        private int currNumber = 0;

        /// <summary>
        /// Currentr number property
        /// </summary>
        public int CurrentrNumber
        {
            get
            {
                return this.currNumber;
            }

            set
            {
                this.currNumber = value;

                numberDisplay.Content = CurrentrNumber.ToString();
            }
        }
    }
}
