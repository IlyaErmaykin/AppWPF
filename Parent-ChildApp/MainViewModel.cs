using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Parent_ChildApp
{
    class MainViewModel
    {
        public ICommand ShowFirstViewCommand { get; set; }

        public ICommand ShowSecondViewCommand { get; set; }

        private ObservableCollection<int> _data;

        public MainViewModel()
        {
            _data = new ObservableCollection<int>(new int[] { 1, 2, 3, 4 });
            ShowFirstViewCommand = new SimpleCommand(ShowFirstView);
            ShowSecondViewCommand = new SimpleCommand(ShowSecondView);
        }

        public void ShowFirstView()
        {
            EditViewModel vm = new EditViewModel() { Value = _data[0] };
            ViewShower.Show(0, vm, true, b => { if (b != null && b.Value) _data[0] = vm.Value; });
        }

        public void ShowSecondView()
        {
            ViewShower.Show(1, _data, false, b => { });
        }
    }
}
