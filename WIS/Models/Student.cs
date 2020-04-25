using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**Author:Qifeng Fang
 * Create Date: 01/04/2020
 * Update Date: 25/04/2020 
 * Brackets follow the guidelines.
 * Varaible name has renamed.
 * 
**/
namespace WIS.Models
{
    //student entity class
    public class Student { //Brackets follow the guidelines.
   
        public int id { get; set; } 


        public string studentName { get; set; } //varaible name has renamed.

        public GENDER gender { get; set; }

    }


    //gender enum
    public enum GENDER{
    
        Male=0,
        Female=1
    }


  
}