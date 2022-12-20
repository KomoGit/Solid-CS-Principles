using StudentRegistryApp.Interfaces;
using System;

namespace StudentRegistryApp.Models
{
    class TeacherModel : ITeacher
    {
        public string email { get ; set ; }
        public int id { get ; set ; }
        public string Name { get ; set ; }
        public string Surname { get ; set ; }
        public bool isTeacher { get; set; } = true;

        public TeacherModel(string name,string surname) 
        { 
            Name= name;
            Surname= surname;
            email = $"{name + surname + "@yahoo.com"}";
        }
    }
}
