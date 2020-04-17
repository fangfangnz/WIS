using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Author:Qifeng Fang 
//Date: 18/04/2020
namespace WIS.Models
{
    //student class
    public class Student 
    {

        public int id { get; set; } 


        public string stuName { get; set; } 

        public GENDER gender { get; set; }

    }


    //gender enum
    public enum GENDER
    {
        M=0,
        F=1
    }


  
}