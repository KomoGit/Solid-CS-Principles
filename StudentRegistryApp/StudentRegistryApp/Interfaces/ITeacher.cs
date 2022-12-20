using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistryApp.Interfaces
{
    interface ITeacher : IPerson
    {
        bool isTeacher { get; set; }
        string email { get; set; }
    }
}
