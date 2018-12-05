using System;
using Mvvmicro;
using ServiceContracts.Interfaces;
using ServiceContracts.Model;
using VIewModels.Interfaces;

namespace VIewModels
{
    public class TimerDetailViewModel : Observable, ITimerDetailViewModel
    {
        private readonly IContextService contextService;
        MyTimer currentTimer;

        public TimerDetailViewModel(IContextService contextService)
        {
            this.contextService = contextService;
        }

        public MyTimer CurrentTimer
        {
            get => currentTimer;
            set => this.Set(ref currentTimer, value);
        }

        public void ReloadContext()
        {
            CurrentTimer = contextService.TimerSelected;
        }
    }
}
