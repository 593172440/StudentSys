using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 班主任表
    /// </summary>
    public class ClassTeacherHasClass:BaseEntity
    {
        [ForeignKey(nameof(EmployeeType))]
        public int EmployeeType_Id { get; set; }
        public EmployeeType EmployeeType { get; set; }
        [ForeignKey(nameof(Class))]
        public int Class_Id { get; set; }
        public Class Class { get; set; }

    }
}
