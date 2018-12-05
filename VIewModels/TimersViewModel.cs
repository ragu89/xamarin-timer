using System;
using System.Windows.Input;
using Mvvmicro;
using ServiceContracts;
using ServiceContracts.Interfaces;
using VIewModels.Interfaces;

namespace VIewModels
{
    public class TimersViewModel : Observable, ITimersViewModel
    {
        private readonly INavigationService navigationService;

        public TimersViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            SelectTimerCommand = new RelayCommand(SelectTimerCommandExecute);
        }

        public ICommand SelectTimerCommand { get; private set; }

        void SelectTimerCommandExecute()
        {
            navigationService.NavigateToView(PageEnum.TimerDetail);
        }
    }
}
