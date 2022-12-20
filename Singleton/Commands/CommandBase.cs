using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Commands
{
    /// <summary>
    /// Everything from <see cref="ICommand"/>
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter) => true;

        public abstract void Execute(object? parameter);

        //protected void OnCanExecuteChanged()
        //{
        //    CanExecuteChanged?.Invoke(this, new EventArgs());
        //}
    }
}
