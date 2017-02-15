using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pc_internship.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        [Display(Name = "Darbuotojo vardas")]
        public string EmployeeName { get; set; }
        [Required]
        [Display(Name = "Darbuotojo pavardė")]
        public string EmployeeLastName { get; set; }
        [Required]
        [Display(Name = "Darbuotojo atlyginimas \"į rankas\"")]
        public double EmployeeNetSalary { get; set; }
        [Display(Name ="Darbuotojo nuotrauka")]
        public string ImgPath { get; set; }
    }
}