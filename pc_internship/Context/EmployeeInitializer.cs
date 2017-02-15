using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using pc_internship.Models;

namespace pc_internship.Context
{
    public class EmployeeInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Random random = new Random();



            var employees = new List<EmployeeModel>
            {
                new EmployeeModel { EmployeeName = "Auksinis", EmployeeLastName = "Kardas", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis1", EmployeeLastName = "Kardas1", EmployeeNetSalary=(random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis2", EmployeeLastName = "Kardas2", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis3", EmployeeLastName = "Kardas3", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis4", EmployeeLastName = "Kardas4", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis5", EmployeeLastName = "Kardas5", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis6", EmployeeLastName = "Kardas6", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis7", EmployeeLastName = "Kardas7", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis8", EmployeeLastName = "Kardas8", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis9", EmployeeLastName = "Kardas9", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis10", EmployeeLastName = "Kardas10", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis11", EmployeeLastName = "Kardas11", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis12", EmployeeLastName = "Kardas12", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis13", EmployeeLastName = "Kardas14", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis15", EmployeeLastName = "Kardas16", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis17", EmployeeLastName = "Kardas17", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis18", EmployeeLastName = "Kardas18", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis19", EmployeeLastName = "Kardas19", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis20", EmployeeLastName = "Kardas20", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis21", EmployeeLastName = "Kardas21", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis22", EmployeeLastName = "Kardas22", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },
                new EmployeeModel { EmployeeName = "Auksinis23", EmployeeLastName = "Kardas23", EmployeeNetSalary = (random.NextDouble() * (1000 - 400) + 400) },

            };

            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();

        }
    }
}