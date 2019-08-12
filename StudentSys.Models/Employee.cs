using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 员工表
    /// </summary>
    public class Employee:BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        [ForeignKey(nameof(EmployeeType))]
        public int EmployeeType_Id { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
