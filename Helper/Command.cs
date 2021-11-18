using System;
using System.Windows.Input;

namespace DressMakerPol.Helper
{
    public class Command : ICommand
    {
        private readonly Action _TargetExecuteMethod;
        private readonly Func<bool> _TargetCanExecuteMethod;
        public event EventHandler CanExecuteChanged;

        public Command(Action targetExecuteMethod)
        {
            _TargetExecuteMethod = targetExecuteMethod;
        }

        public Command(Action targetExecuteMethod, Func<bool> targetCanExecuteMethod) : this(targetExecuteMethod)
        {
            _TargetCanExecuteMethod = targetCanExecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            if (_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod();
            }

            if (_TargetExecuteMethod == null)
            {
                return false;
            }

            return true;
        }

        public void Execute(object parameter)
        {
            _TargetExecuteMethod?.Invoke();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
    }
}
