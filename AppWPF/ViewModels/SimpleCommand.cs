using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppWPF.ViewModels
{
    /// <summary>
    /// Simple command 
    /// </summary>
    class SimpleCommand : ICommand
    {
        /// <summary>
        /// Can execute changed event
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Can execute function
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Execute function
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Simple command function
        /// </summary>
        /// <param name="action"></param>
        public SimpleCommand(Action action)
        {
            return;
        }
    }
}
