using Singleton.Commands;
using Singleton.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Singleton.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        //public string Username => "Cody";
        //public string Email => "cody.estes@solidcam.com";

        public ICommand? NavigateHomeCommand { get; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }
    }
}
