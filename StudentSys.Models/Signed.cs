using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 签到表
    /// </summary>
    public class Signed:BaseEntity
    {
        [ForeignKey(nameof(Student))]
        public int Student_Id { get; set; }
        public Student Student { get; set; }
        [ForeignKey(nameof(Class))]
        public int Class_Id { get; set; }
        public Class Class { get; set; }
        /// <summary>
        /// 签到时间
        /// </summary>
        public DateTime? InTime { get; set; }
        /// <summary>
        /// 签退时间
        /// </summary>
        public DateTime? OutTime { get; set; }
        /// <summary>
        /// 签到类型
        /// </summary>
        public string SignedType { get; set; }
    }
}
