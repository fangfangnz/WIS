using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WIS.Models
{
    //WIS student entity
    public class WisStudent : IStudent
    {
        public string sayHello(string name, GENDER gender)
        {

            return $"I am {gender},My name is {name}";
        }
       
    }
}