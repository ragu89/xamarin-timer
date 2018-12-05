using System;
using System.ComponentModel;
using ServiceContracts.Model;

namespace VIewModels.Interfaces
{
    public interface ITimerDetailViewModel : INotifyPropertyChanged
    {
        void ReloadContext();
        MyTimer CurrentTimer { get; }
    }
}
