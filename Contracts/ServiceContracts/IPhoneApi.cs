﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    [ServiceContract]
    public interface IPhoneApi
    {
        [OperationContract]
        void DoWork();


    }
}
