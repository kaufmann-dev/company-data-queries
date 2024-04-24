using System;
using System.Collections.Generic;
using System.Linq;
using Company.model;
using Microsoft.EntityFrameworkCore;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyContextFactory = new CompanyContextFactory();
            
            // CREATE NEW OBJECTS IN DATABASE
            using (var context = companyContextFactory.CreateDbContext(args))
            {
                // define variables with data
                var company = new model.Company
                {
                    Name = "Digitalizo"
                };

                var employeeList = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "David",
                        LastName = "Kaufmann"
                    },
                    new Employee()
                    {
                        FirstName = "Florian",
                        LastName = "Rauchberger"
                    },
                    new Employee()
                    {
                        FirstName = "Florian",
                        LastName = "Pernikl"
                    }
                };
                
                var productList = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Gun X83",
                        Description = "Kill them.",
                        License = ELicense.AllRightsReserved
                    },
                    new Product()
                    {
                        Name = "Mango Shampoo",
                        Description = "Shampoo that smells like mango.",
                        License = ELicense.AllRightsReserved
                    },
                    new Product()
                    {
                        Name = "CSS Framework Sanity",
                        Description = "Modern CSS framwork.",
                        License = ELicense.MIT
                    }
                };
                
                // print data
                Console.WriteLine("► " + company.ToString());
                
                foreach (var x in employeeList)
                {
                    Console.WriteLine("► " + x.ToString());
                }
                
                foreach (var x in productList)
                {
                    Console.WriteLine("► " + x);
                }
                
                // update context with data
                context.Add(company);
                context.AddRange(employeeList);
                context.AddRange(productList);
                
                // save changes to context
                // context.SaveChanges();
            }
            
            // EXECUTE RAW SQL
            using (var context = companyContextFactory.CreateDbContext(args))
            {
                context.Database.ExecuteSqlRaw("SELECT * FROM COMPANY");
            }

            // QUERY WITH LINQ METHOD SYNTAX
            using (var context = companyContextFactory.CreateDbContext(args))
            {
                // define variables with query results
                var query1 = context
                    .Employees
                    .Where(e => e.FirstName == "Florian");
                
                var query2 = context
                    .Products
                    .FirstOrDefault();
                
                // print queries
                 // with foreach
                foreach (var x in query1)
                {
                    Console.WriteLine("► " + x);
                }
                
                 // with FirstOrDefault
                Console.WriteLine("► " + query2);
            }
            
            // QUERY WITH LINQ QUERY SYNTAX
            using (var context = companyContextFactory.CreateDbContext(args))
            {
                var query1 =
                    from e
                        in context.Employees
                    where e.FirstName == "David"
                    select e;

                var david = query1.FirstOrDefault();
                
                // print queries
                 // with foreach
                 foreach (var x in query1)
                 {
                     Console.WriteLine("► " + x);
                 }
                 
                 // with FirstOrDefault
                Console.WriteLine("► " + david);
            }
        }
    }
}