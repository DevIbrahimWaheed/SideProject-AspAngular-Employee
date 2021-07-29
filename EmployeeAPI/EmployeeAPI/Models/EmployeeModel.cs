using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Models
{
    public class EmployeeModel
    {
   

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Key]
        public int Employee_No { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Department { get; set; }


        [Required]
        [Column(TypeName = "varchar(10)")]
        public string StartDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string Active { get; set; }
    }
}
