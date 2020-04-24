using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**Author:Qifeng Fang
 * Create Date: 01/04/2020
 * Update Date: 18/04/2020
 * Brackets follow the guidelines.
 *
**/
namespace WIS.Models
{
    //student interface 
    interface IStudent{   
    
        string sayHello(string name,GENDER gender); 
    }
}