﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBankasi
{
    internal class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine(" Veritabanına loglandı.");
        }
    }

}
