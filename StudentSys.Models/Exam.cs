using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 考试表
    /// </summary>
    public class Exam:BaseEntity
    {
        [ForeignKey(nameof(Class))]
        public int Class_Id { get; set; }
        public Class Class { get; set; }
        public DateTime ExamTime { get; set; }
        [ForeignKey(nameof(Subject))]
        public int Subject_Id { get; set; }
        public Subject Subject { get; set; }
    }
}
