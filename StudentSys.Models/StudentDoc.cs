using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 档案表
    /// </summary>
    public class StudentDoc:BaseEntity
    {
        [ForeignKey(nameof(Student))]
        public int Student_Id { get; set; }
        public Student Student { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
    }
}
