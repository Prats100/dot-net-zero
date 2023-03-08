using Abp.Dependency;
using Abp.Threading.BackgroundWorkers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDemo
{
    public interface IMakeInactiveUsersPassiveWorker 
    {
          void DoWork1();
    }
}
