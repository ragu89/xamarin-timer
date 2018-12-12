using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using Mvvmicro;
using ServiceContracts;
using ServiceContracts.Interfaces;
using ServiceContracts.Model;
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

            Timers = new List<MyTimer>();

#if DEBUG
            Timers.Add(new MyTimer { Name = "Round 1", Duration = new TimeSpan(0, 0, 30) });
            Timers.Add(new MyTimer { Name = "Recovery", Duration = new TimeSpan(0, 0, 25) });
            Timers.Add(new MyTimer { Name = "Round 2", Duration = new TimeSpan(0, 0, 30) });
            Timers.Add(new MyTimer { Name = "Recovery", Duration = new TimeSpan(0, 0, 25) });
            Timers.Add(new MyTimer { Name = "Round 3", Duration = new TimeSpan(0, 0, 30) });
            Timers.Add(new MyTimer { Name = "Recovery", Duration = new TimeSpan(0, 1, 00) });
#endif
        }

        public ICommand SelectTimerCommand { get; private set; }

        public List<MyTimer> Timers { get; }

        void SelectTimerCommandExecute()
        {
            navigationService.NavigateToView(PageEnum.TimerDetail);
        }
    }
}
