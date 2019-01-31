using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsЗCheck
{
    interface IClass
    {
        string Method1();
        string Method1(int number);
        int this[int index] { get; }
    }
}
