using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sulmar.WPF.Advanced.Common
{
    public class DelayRelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action execute;
        private readonly Func<bool> canExecute;

        private TimeSpan delay;

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        CancellationToken token;

        private bool isWaiting;

        public DelayRelayCommand(Action execute, Func<bool> canExecute = null, TimeSpan delay = default(TimeSpan))
        {
            this.execute = execute;
            this.canExecute = canExecute;
            this.delay = delay;
            token = cancellationTokenSource.Token;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute();
        }

        public void Execute(object parameter)
        {   
            if (isWaiting)
            {
                cancellationTokenSource.Cancel();
                return;
            }

            isWaiting = true;
            
            Task.Delay(delay, token)
                .ContinueWith(t=>execute?.Invoke(), TaskContinuationOptions.NotOnCanceled)
                    .ContinueWith(t => isWaiting = false);
            
        }
    }

    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action execute;
        private readonly Func<bool> canExecute;


        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute();
        }

        public void Execute(object parameter) => execute?.Invoke();
    }

    public class RelayCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action<T> execute;
        private readonly Func<bool> canExecute;

        public RelayCommand(Action<T> execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute();
        }

        public void Execute(object parameter) => execute?.Invoke((T) parameter);
    }
}
