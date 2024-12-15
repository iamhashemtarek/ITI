using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    [Flags]
    internal enum Privilage: byte
    {
        guest= 1 ,
        developer = 2,
        secretary = 4,
        DBA = 8,
    }
}
