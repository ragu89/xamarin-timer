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
            var contextService = Container.Default.Get<IContextService>();

            RegisterViewModels(navigationService, contextService);
        }

        void RegisterViewModels(INavigationService navigationService, IContextService contextService)
        {
            Container.Default.Register<ITimersViewModel>((vm) => new TimersViewModel(navigationService), true);
            Container.Default.Register<ITimerDetailViewModel>((vm) => new TimerDetailViewModel(contextService), true);
        }

        public ITimersViewModel TimersViewModel => Container.Default.Get<ITimersViewModel>();
        public ITimerDetailViewModel TimerDetailViewModel => Container.Default.Get<ITimerDetailViewModel>();
    }
}
