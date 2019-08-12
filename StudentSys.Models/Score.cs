using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 成绩表
    /// </summary>
    public class Score:BaseEntity
    {
        [ForeignKey(nameof(Subject))]
        public int Subject_Id { get; set; }
        public Subject Subject { get; set; }
        [ForeignKey(nameof(Student))]
        public int Student_Id { get; set; }
        public Student Student { get; set; }
        public int ExamScore { get; set; }
    }
}
