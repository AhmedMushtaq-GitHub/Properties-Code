using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private string name;
        private string description;
        
        //Long type Property
        public string Name
        {
            get 
            { 
                return name; 
            }

            set 
            {
                name = value;
            }
                
        }
        //Auto type Property
        public string Description
        {
            get;
            set;
        }
    }
}
