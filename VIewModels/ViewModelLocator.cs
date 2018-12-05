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
            Container.Default.Register<ITimersViewModel>((vm) => new TimersViewModel(), true);
            Container.Default.Register<ITimerDetailViewModel>((vm) => new TimerDetailViewModel(), true);
        }

        public ITimerDetailViewModel Page1ViewModel => Container.Default.Get<ITimerDetailViewModel>();
    }
}
