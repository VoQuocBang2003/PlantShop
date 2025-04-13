using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Winform.Database
{
    internal class  DatabaseConnection
       
    {
        public static DatabaseConnection Instance { get; private set; }
        public string  ConnectionString { get; private set; }
            
    }
}
