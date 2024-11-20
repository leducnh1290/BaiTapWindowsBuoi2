using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<Student> students = new List<Student>();  
            students.Add(new Student(1,"Anh",17));
            students.Add(new Student(2,"Hue",20));
            students.Add(new Student(3,"Bao",50));
            students.Add(new Student(4,"Duong",40));
            students.Add(new Student(5,"Ly",70));
            Console.WriteLine("a. Danh sach toan bo sv:");
            foreach (var student in students)
            {
                Console.WriteLine($"Ten: {student.Name}, Tuoi: {student.Age}");
            }

           
            Console.WriteLine("\nb. SV co tuoi tu 15 den 18");
            var ageRange = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            foreach (var student in ageRange)
            {
                Console.WriteLine($"Ten: {student.Name}, Tuoi: {student.Age}");
            }

           
            Console.WriteLine("\nc. Sv co ten bat dau bang 'A':");
            var nameStartsWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
            foreach (var student in nameStartsWithA)
            {
                Console.WriteLine($"Ten: {student.Name}, Tuoi: {student.Age}");
            }

          
            Console.WriteLine("\nd. Tong tat ca tuoi cua toan bo sv:");
            var totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"Tong tuoi: {totalAge}");

         
            Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            if (oldestStudent != null)
            {
                Console.WriteLine($"Ten: {oldestStudent.Name}, Tuoi: {oldestStudent.Age}");
            }

            
            Console.WriteLine("\nf. Sap xep sv theo tuoi tang dan:");
            students.OrderBy(s => s.Age).ToList().ForEach(x=>Console.WriteLine(x));

        }
    }

}
