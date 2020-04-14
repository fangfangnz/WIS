using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WIS.Models
{
    //student interface
    interface IStudent
    {
        string sayHello(string name,GENDER gender);
    }
}