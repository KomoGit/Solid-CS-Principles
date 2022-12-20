using StudentRegistryApp.Interfaces;
using System;

namespace StudentRegistryApp.Models
{

    class StudentModel : IStudent
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool isStudent { get; set; } = true;

        public StudentModel(string name,string surname) 
        {
            Name = name;
            Surname = surname;
        }
    }
}
