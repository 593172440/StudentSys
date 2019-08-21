using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 毕业信息表
    /// </summary>
    public class StudentGraduteInfo:BaseEntity
    {
        [ForeignKey(nameof(Student))]
        public int Studnet_Id { get; set; }
        public Student Student { get; set; }
        /// <summary>
        /// 公司名
        /// </summary>
        public string CopyName { get; set; }
        /// <summary>
        /// 薪资
        /// </summary>
        public decimal Salary { get; set; }
        /// <summary>
        /// 毕业时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string Position { get; set; }
        public string Address { get; set; }
    }
}
