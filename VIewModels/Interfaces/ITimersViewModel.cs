using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using ServiceContracts.Model;

namespace VIewModels.Interfaces
{
    public interface ITimersViewModel : INotifyPropertyChanged
    {
        ICommand SelectTimerCommand { get; }
        List<MyTimer> Timers { get; }
    }
}
