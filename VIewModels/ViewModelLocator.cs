using System;
using Mvvmicro;
using ServiceContracts.Interfaces;
using VIewModels.Interfaces;

namespace VIewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            var navigationService = Container.Default.Get<INavigationService>();

            RegisterViewModels(navigationService);
        }

        void RegisterViewModels(INavigationService navigationService)
        {
            Container.Default.Register<ITimersViewModel>((vm) => new TimersViewModel(navigationService), true);
            Container.Default.Register<ITimerDetailViewModel>((vm) => new TimerDetailViewModel(), true);
        }

        public ITimersViewModel TimersViewModel => Container.Default.Get<ITimersViewModel>();
        public ITimerDetailViewModel TimerDetailViewModel => Container.Default.Get<ITimerDetailViewModel>();
    }
}
