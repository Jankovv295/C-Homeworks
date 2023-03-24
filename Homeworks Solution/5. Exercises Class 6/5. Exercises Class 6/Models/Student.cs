using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }
        public Student() { }
        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }
        public string StudentInfo()
        {
            return $"{Name} was found. The student is part of the academy {Academy} in group {Group}";
        }
    }
}

