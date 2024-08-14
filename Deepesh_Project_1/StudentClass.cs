using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepesh_Project_1
{
   
    internal class StudentClass

    {
        public string Firstname {  get; set; }
        public string MiddleName { get; set; }
        public string LastName {  get; set; }  
        public long Age {  get; set; }  
        public Classes  Class {  get; set; } 
        public Classes TopperClass { get; set; }    
        public long  RollNo {  get; set; }
        public string Address { get; set; }
        public List<string> Hobby { get; set; }   
        public Dictionary<string,int>Subject { get; set; }
    }
    public enum Classes
    {
        First = 1,
        second = 2,
        Third = 3,
        Fourth = 4,
        Fifth = 5,
        Sixth = 6,
        Seventh = 7,
        Eight = 8,
        Nineth = 9,
        Tenth = 10,
        Eleventh = 11,
        Tweleveth = 12
    }
}
