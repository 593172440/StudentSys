using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 学生谈话提醒表
    /// </summary>
    public class StudentTalked:BaseEntity
    {
        [ForeignKey(nameof(Student))]
        public int Student_Id { get; set; }
        public Student Student { get; set; }
        [ForeignKey(nameof(Class))]
        public int Class_Id { get; set; }
        public Class Class { get; set; }
        public string Content { get; set; }
        /// <summary>
        /// 是否完成
        /// </summary>
        public bool isDone { get; set; }
        public string Result { get; set; }
    }
}
