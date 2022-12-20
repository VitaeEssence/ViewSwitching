using Singleton.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Singleton.Stores
{
    /// <summary>
    /// <see cref="Action"/> with <see cref="INotifyPropertyChanged"/>
    /// </summary>
    public class NavigationStore
    {
        public event Action? CurrentViewModelChanged;

        #region Private Backing Fields

        private ViewModelBase? _currentViewModel;

        #endregion


        #region Public Fields

        public ViewModelBase? CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        #endregion


        #region Action Methods
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        #endregion
    }
}
