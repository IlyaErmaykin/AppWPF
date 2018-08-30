using System;
using System.Windows.Input;

namespace Parent_ChildApp
{
    internal class SimpleCommand : ICommand
    {
        private Action showSecondView;

        public SimpleCommand(Action showSecondView)
        {
            this.showSecondView = showSecondView;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}