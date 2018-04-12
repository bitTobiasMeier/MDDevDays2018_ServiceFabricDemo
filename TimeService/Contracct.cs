using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Remoting;

namespace TimeService
{
    public interface ITimeService : IService
    {
        Task<string> GetTimeAsync();
    }
}
