using System;
using ServiceContracts.Interfaces;
using ServiceContracts.Model;

namespace ServiceContracts.Service
{
    public class ContextService : IContextService
    {
        public MyTimer TimerSelected { get; set; }
    }
}
