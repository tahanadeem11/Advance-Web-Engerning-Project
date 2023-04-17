using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    [Table("employe")]
    public class Employee
    {
        [Key]
        public int empID { get; set; }
        public string empName { get; set; }
        public char Gender { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }

}