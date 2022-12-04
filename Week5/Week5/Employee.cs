using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Week5
{
    internal class Employee
    {
        public static void EmployeeDetails(string Name)
        {
            List<EmployeeModel> employees = new List<EmployeeModel>()
            {
                new EmployeeModel() { Name = "John", Address = "123 Main St", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "Manager", HireDate = new DateOnly(2021, 1, 1) },
                new EmployeeModel() { Name = "Ben", Address = "Islington", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "Clerk", HireDate = new DateOnly(2022, 11, 1) },
                new EmployeeModel() { Name = "Haryy", Address = "New york", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "Frontend Dev", HireDate = new DateOnly(2019, 10, 1) },
                new EmployeeModel() { Name = "Troy", Address = "St. Louis", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "Backend Dev", HireDate = new DateOnly(2018, 2, 1) },
                new EmployeeModel() { Name = "Wankie", Address = "Arkansa", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "UI Dev", HireDate = new DateOnly(2017, 3, 1) },
                new EmployeeModel() { Name = "Dejan", Address = "Seattle", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "UX Dev", HireDate = new DateOnly(2020, 5, 1) },
                new EmployeeModel() { Name = "Guts", Address = "Long Beach", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "Backend Dev", HireDate = new DateOnly(2016, 8, 1) },
                new EmployeeModel() { Name = "Willow", Address = "Los Angelos", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "Backend Dev", HireDate = new DateOnly(2015, 1, 1) },
                new EmployeeModel() { Name = "Renley", Address = "Glasgow", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "Frontend Dev", HireDate = new DateOnly(2014, 2, 1) },
                new EmployeeModel() { Name = "Wichita", Address = "Edinburgh", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "Frontend Dev", HireDate = new DateOnly(2013, 3, 1) },
                new EmployeeModel() { Name = "Henry", Address = "Amsterdam", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "Frontend Devr", HireDate = new DateOnly(2012, 4, 1) },
                new EmployeeModel() { Name = "Simon", Address = "Sydney", Email = "abc@gmail.com", Phone = "123-456-7890", Position = "Frontend Dev", HireDate = new DateOnly(2021, 7, 1) }
                
               
            };
            //Search
            Console.WriteLine("Searching");
            List<EmployeeModel> search = employees.Where(x => x.Name == Name).ToList();
            foreach (var item in search)
            {
                Console.WriteLine($"Name: {item.Name}\nAddress: {item.Address}\nEmail: {item.Email}\nPhone: {item.Phone}\nPosition: {item.Position}\nHireDate: {item.HireDate.ToString("MMMM,dd,yyyy")}\n");
            }
            //Sort

            Console.WriteLine("Sorting");
            List<EmployeeModel> sort = employees.OrderBy(x => x.HireDate).ToList();
            List<EmployeeModel> sort2 = employees.OrderByDescending(x => x.HireDate).ToList();
            Console.WriteLine("Ascending:");
            foreach (var item in sort)
            {
                Console.WriteLine($"Name: {item.Name}  Address: {item.Address}  Email: {item.Email}  Phone: {item.Phone}  Position: {item.Position}  HireDate: {item.HireDate.ToString("MMMM,dd,yyyy")}");
            }

            Console.WriteLine("Descending:");
            foreach (var item in sort2)
            {
                Console.WriteLine($"Name: {item.Name}  Address: {item.Address}  Email: {item.Email}  Phone: {item.Phone}  Position: {item.Position}  HireDate: {item.HireDate.ToString("MMMM,dd,yyyy")}");
            }
        }
        
        
    }
}
