namespace TEST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int empId { get; set; }

        [Required]
        [StringLength(50)]
        public string empName { get; set; }

        public int Salary { get; set; }

        [Required]
        [StringLength(50)]
        public string DeptName { get; set; }

        [Required]
        [StringLength(50)]
        public string Designation { get; set; }
    }
}
