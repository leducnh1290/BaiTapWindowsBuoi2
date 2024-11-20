using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public Student()
        {
            this.Id = 0;
            this.Age = 0;
            this.Name = "Duc Anh";
        }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Student [MaSv: {Id}, TenSv: {Name}, TuoiSv: {Age}]";
        }
    }
}
