using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistryApp.Interfaces
{
    interface IStudent : IPerson
    {
        bool isStudent { get; set; }
    }
}
