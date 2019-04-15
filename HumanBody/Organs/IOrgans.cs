using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBody.Organs
{
    interface IOrgans
    {
        int Idx { get; set; }
        string Name { get; set; }
        string Type { get; set; }
    }
}
