﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Domain.Interfaces
{
    public interface IRepository<T>
        : IGenericRepository<T>
        where T : IAggregateRoot
    {

    }
}
