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

                 .OrderByDescending(p => p.Age)
                            .Select(x => (EmpName: x.Name, EmpAge: x.Age, EmpID: x.ID, EmpGender: x.Gender, EmpSalary: x.Salary));





                foreach (var item in emp)
                {

                    Console.WriteLine($"    Name:{item.EmpName}:   Age: {item.EmpAge}years  Gender :{item.EmpGender} ID: {item.EmpID} Salary : {item.EmpSalary} Naira  ");
                }

               
                Console.WriteLine("\n*********************************************************************************\n");

                var emp2 = employee.Where(p => p.Gender == 'F')
                      .Select(x => (EmpName: x.Name, EmpAge: x.Age, EmpID: x.ID, EmpGender: x.Gender, EmpSalary: x.Salary));
                foreach (var gender in emp2)
                {
                   
                    Console.WriteLine($"    Name:{gender.EmpName}:   Age: {gender.EmpAge}years  Gender :{gender.EmpGender} ID: {gender.EmpID} Salary : {gender.EmpSalary} Naira  ");



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
                var emp4 = employee.Where(p => p.ID <= 8)
              .Select(x => (EmpName: x.Name, EmpAge: x.Age, EmpID: x.ID, EmpGender: x.Gender, EmpSalary: x.Salary));
                foreach(var a in emp4)
                {
                    Console.WriteLine($"    Name:{a.EmpName}:   Age: {a.EmpAge}years  Gender :{a.EmpGender} ID: {a.EmpID} Salary : {a.EmpSalary} Naira  ");
                }
            }
        }
    }
}