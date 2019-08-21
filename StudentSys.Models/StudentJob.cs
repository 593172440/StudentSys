using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 作业提交表
    /// </summary>
    public class StudentJob:BaseEntity
    {
        [ForeignKey(nameof(Student))]
        public int Student_Id { get; set; }
        public Student Student { get; set; }

        [ForeignKey(nameof(Class))]
        public int Class_Id { get; set; }
        public Class Class { get; set; }
        public DateTime Time { get; set; }

        /// <summary>
        /// 完成情况
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 评价
        /// </summary>
        public string Achievement { get; set; }
    }
}
