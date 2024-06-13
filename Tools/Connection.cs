using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Ngupy_NgulakKopy.Tools
{
    internal class Connection
    {
        public static string connect = $"Server=localhost;Username=postgres;Password=moluka;Database=ngupy;Port=5432;Pooling=True;";
    }
}
