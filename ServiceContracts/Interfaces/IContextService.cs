using System;
using ServiceContracts.Model;

namespace ServiceContracts.Interfaces
{
    public interface IContextService
    {
        MyTimer TimerSelected { get; set; }
    }
}
