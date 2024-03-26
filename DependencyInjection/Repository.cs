﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Repository : IRepository
    {
        public void GetData()
        {
            Console.WriteLine("Data retrived");
        }
    }
}
