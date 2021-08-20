using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Proj
{
    class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public string email { get; set; }

        public Teacher(int id ,string name, string subject, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.subject = subject;
        }
    }
}
