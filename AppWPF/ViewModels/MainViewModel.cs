using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppWPF.ViewModels
{
    /// <summary>
    /// Main view model class
    /// </summary>
    class MainViewModel
    {
        /// <summary>
        /// View shower field
        /// </summary>
        ViewShower viewShower;

        /// <summary>
        /// Data field
        /// </summary>
        private ObservableCollection<int> _data;

        /// <summary>
        /// Show first view command property
        /// </summary>
        public ICommand ShowFirstViewCommand { get; set; }

        /// <summary>
        /// Show second view command property
        /// </summary>
        public ICommand ShowSecondViewCommand { get; set; }

        /// <summary>
        /// Main view model constructor
        /// </summary>
        public MainViewModel()
        {
            _data = new ObservableCollection<int>(new int[] { 1, 2, 3, 4 });
            ShowFirstViewCommand = new DelegateCommand(ShowFirstView);
            ShowSecondViewCommand = new DelegateCommand(ShowSecondView);
        }

        /// <summary>
        /// Show first view event
        /// </summary>
        /// <param name="parameter"></param>
        public void ShowFirstView(object parameter)
        {
            EditViewModel vm = new EditViewModel() { Value = _data[0] };
            viewShower.Show(0, vm, true, b => { if (b != null && b.Value) _data[0] = vm.Value; });
        }

        /// <summary>
        /// Show second view event
        /// </summary>
        /// <param name="parameter"></param>
        public void ShowSecondView(object parameter)
        {
            viewShower.Show(1, _data, false, b => { });
        }
    }
}
