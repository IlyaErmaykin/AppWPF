using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppWPF.ViewModels
{
    /// <summary>
    /// Common command wrapper for most of desired commands
    /// </summary>
    public class DelegateCommand : ICommand
    {
        /// <summary>
        /// This delegate store method to be called that contains the body of the Execute for each particular instance of DelegateCommand
        /// </summary>
        private readonly Predicate<object> _canExecutePredicate;

        /// <summary>
        /// This delegate store method to be called that contains the body of the CanExecute for each particular instance of DelegateCommand
        /// </summary>
        private readonly Action<object> _executeAction;

        /// <summary>
        /// Can execute changed event
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Can execute predicate function
        /// </summary>
        /// <param name="parameter">Additional command parameter</param>
        /// <returns>Execution state: false if command blocked, otherwise — true</returns>
        public bool CanExecute(object parameter)
        {
            return this._canExecutePredicate?.Invoke(parameter) ?? true;
        }

        /// <summary>
        /// Execute action function
        /// </summary>
        /// <param name="parameter">Additional command parameter</param>
        public void Execute(object parameter)
        {
            if (!this.CanExecute(parameter))
            {
                return;
            }

            this._executeAction(parameter);

            this.RaiseCanExecuteChanged();
        }

        /// <summary>
        /// Not a part of ICommand interface, but commonly added so you can trigger a manual refresh on the result of CanExecute
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Constructor with Execute action and CanExecute predicate setup
        /// </summary>
        /// <param name="executeAction">Command execution action</param>
        /// <param name="canExecutePredicate">Command can execute condition predicate</param>
        public DelegateCommand(Action<object> executeAction, Predicate<object> canExecutePredicate)
        {
            this._canExecutePredicate = canExecutePredicate;
            this._executeAction = executeAction;
        }

        /// <summary>
        /// Constructor with Execute action setup
        /// </summary>
        /// <param name="executeAction">Command execution action</param>
        public DelegateCommand(Action<object> executeAction) : this(executeAction, null)
        {
        }
    }
}
