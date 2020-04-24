using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WIS.Models
{
    public class Person
    {
    }



    //Create a bird entity
     public  class Birds{

        private string _name;//bird name varaible 

        public string name {
            get{          
                return _name;
            }
           set{
                _name = value;
            }
        }
    }


     //create fly class
     public class Fly{ //base class
     public virtual string eat(){
            return "I can eat something";
        }
     }
     public class Bird:Fly{ //subclass
        public override string eat(){
            return "Bird can eat something";
        }
    }













}