using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace UnitTest_Moq.Model
{
    public class Employee
    {
        [Key]
        // [BindNever]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desgination { get; set; }

    }
}
