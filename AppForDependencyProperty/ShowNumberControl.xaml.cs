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
    /// </summary>
    public partial class ShowNumberControl : UserControl
    {
        public ShowNumberControl()
        {
            InitializeComponent();
        }

        // Обычное свойство .NET
        private int currNumber = 0;

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
