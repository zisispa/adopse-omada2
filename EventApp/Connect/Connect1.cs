﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    public class Connect1
    {
        private string connectString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ζήσης\Desktop\Σχολή\ΑΟΠΣΕ - ΕΡΓΑΣΙΑ\GitHub\version pc\EventApp\Database.accdb";

        public string ConnectString { get => connectString; set => connectString = value; }
    }
}
