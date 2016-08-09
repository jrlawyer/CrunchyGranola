using CrunchyGranola.Models;
using System;
using System.Collections.Generic;

namespace CrunchyGranola.DAL
{
    public class CrunchyGranolaInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<CrunchyGranolaContext>
    {
        protected override void Seed(CrunchyGranolaContext context)
        {
            var customers = new List<Customer>
            {
                new Customer { FirstName = "James", LastName = "Alexander", DateOfLastPurchase = DateTime.Parse("2016-08-01")},
                new Customer { FirstName = "Jennifer", LastName = "Lawyer", DateOfLastPurchase = DateTime.Parse("2016-07-01")},
                new Customer { FirstName = "Stephanie", LastName = "Lawyer", DateOfLastPurchase = DateTime.Parse("2016-06-01")},
                new Customer { FirstName = "Anthony", LastName = "Gage", DateOfLastPurchase = DateTime.Parse("2016-05-01")}

            };

            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();

            var departments = new List<Department>

            {
                new Department {DepartmentID = 123, DepartmentName = "Produce", Budget = 5000 },
                new Department {DepartmentID = 124, DepartmentName = "Seafood", Budget = 3000 },
                new Department {DepartmentID = 125, DepartmentName = "Health", Budget = 4500 },
                new Department {DepartmentID = 126, DepartmentName = "Apparel", Budget = 2000 }
            };

            departments.ForEach(d => context.Departments.Add(d));
            context.SaveChanges();

            var purchases = new List<Purchase>
            {
                new Purchase { CustomerID = 1, DepartmentID = 123, Description = "Apples", Price = 1.5m, UpcCode = 1234567, LeadTimes = "1 week", Quantity = 50},
                new Purchase { CustomerID = 1, DepartmentID = 124, Description = "Salmon", Price = 7.0m, UpcCode = 1234568, LeadTimes = "2 weeks", Quantity = 10},
                new Purchase { CustomerID = 2, DepartmentID = 124, Description = "Swordfish", Price = 9.0m, UpcCode = 1234569, LeadTimes = "2 weeks", Quantity = 5},
                new Purchase { CustomerID = 3, DepartmentID = 125, Description = "Vitamin D", Price = 50m, UpcCode = 1234570, LeadTimes = "3 weeks", Quantity = 20},
                new Purchase { CustomerID = 4, DepartmentID = 126, Description = "Funky Hat", Price = 10.0m, UpcCode = 1234571, LeadTimes = "2 months", Quantity = 3},
            };

            purchases.ForEach(p => context.Purchases.Add(p));
            context.SaveChanges();

        }
    }
}