using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp92
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employee = new List<Employee>();
            {
                employee.Add(new Employee { Name = " Sekoni olajumoke", Age = 22, ID = 001, Gender = 'F', Salary = 700000 });
                employee.Add(new Employee { Name = " Eletu Tifeoluwa", Age = 20, ID = 002, Gender = 'M', Salary = 900000 });
                employee.Add(new Employee { Name = " Ojo Odunayo    ", Age = 25, ID = 003, Gender = 'F', Salary = 900000 });
                employee.Add(new Employee { Name = " Luqman Temitope", Age = 35, ID = 004, Gender = 'M', Salary = 533.900000 });
                employee.Add(new Employee { Name = " Oladeji Faizah ", Age = 50, ID = 005, Gender = 'F', Salary = 600000 });
                employee.Add(new Employee { Name = " Abolaji Olawale", Age = 30, ID = 006, Gender = 'M', Salary = 19800000 });
                employee.Add(new Employee { Name = " Babatunde olasun", Age = 56, ID = 007, Gender = 'M', Salary = 100000 });
                employee.Add(new Employee { Name = " Francis Mary   ", Age = 37, ID = 008, Gender = 'F', Salary = 2700000 });
                employee.Add(new Employee { Name = " Chinenye Chiluv", Age = 48, ID = 009, Gender = 'F', Salary = 4500000 });
                employee.Add(new Employee { Name = " Mercy Johnson  ", Age = 25, ID = 010, Gender = 'F', Salary = 900000 });


                var emp = employee.Where(p => p.Age > 25)

                 .OrderByDescending(p => p.Age);





                foreach (var item in emp)
                {

                    Console.WriteLine($"    Name:{item.Name}:   Age: {item.Age}years  Gender :{item.Gender} ID: {item.ID} Salary : {item.Salary} Naira  ");
                }

               
                Console.WriteLine("\n*********************************************************************************\n");

                var emp2 = employee.Where(p => p.Gender == 'F');
                   
                      
                foreach (var gender in emp2)
                {
                   
                    Console.WriteLine($"    Name:{gender.Name}:   Age: {gender.ID}years  Gender :{gender.Age} ID: {gender.Gender} Salary : {gender.Salary} Naira  ");



                }
                Console.WriteLine("*********************************************************************************\n");

                var emp3 = employee.Where(p => p.Age == 20 || p.Age ==30 || p.Age == 35)

                        //.Where(p => p.Age == 35)
                       .Select(x => (EmpName: x.Name, EmpAge: x.Age, EmpID: x.ID, EmpGender: x.Gender, EmpSalary: x.Salary));
                foreach (var a in emp3)
                {
                    Console.WriteLine($"    Name:{a.EmpName}:   Age: {a.EmpAge}years  Gender :{a.EmpGender} ID: {a.EmpID} Salary : {a.EmpSalary} Naira  ");
                }
                Console.WriteLine("\n*********************************************************************************\n");
                var emp4 = employee.Where(x => x.Gender == 'F')
                    .Where(p => p.ID > 1 && p.ID < 8);
            
                foreach(var a in emp4)
                {
                    Console.WriteLine($"    Name:{a.Name}:   Age: {a.Age}years  Gender :{a.Gender} z ");
                }
           


            }
        }
    }
}