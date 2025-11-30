using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame.Word
{
    internal class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public char gender { get; set; }
        public string fatherName { get; set; }
        public double weight { get; set; }
        public double height { get; set; }
        public DateTime birthdate { get; set; }

    
     public string GetfullName()
        {
           return $"{firstName}+{lastName}";
        }

    }
}