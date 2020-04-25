using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**Author:Qifeng Fang
 * Create Date: 01/04/2020
 * Update Date: 25/04/2020
 * Brackets follow the guidelines.
 * 
**/
namespace WIS.Models
{

    //WIS student entity 
    public class WisStudent : IStudent{
    
        public string sayHello(string name, GENDER gender){ 
        
            return $"I am {gender},My name is {name}";
        }
       
    }
}