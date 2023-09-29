using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    [Flags]
    internal enum Rights
    {
        NONE = 0,
        READABLE = 1,
        WRITABLE = 2,
        EXECUTABLE = 4,
        PRIVILEGED = 8
    }
}
