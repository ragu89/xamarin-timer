using System;
using System.ComponentModel;
using System.Windows.Input;

namespace VIewModels.Interfaces
{
    public interface ITimersViewModel : INotifyPropertyChanged
    {
        ICommand SelectTimerCommand { get; }
    }
}
