﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        int GetAll();
    }
}
