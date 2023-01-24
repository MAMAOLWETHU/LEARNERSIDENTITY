using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNERSIDENTITY
{
    internal class Learners
    {
        public string firstname;
        public string lastname;
        public string gender;
        public int age;
        public char initial;

        public Learners(string firstname, string lastname, string gender, char initial, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.age = age;
            this.initial = initial;
        }
    }


    }
