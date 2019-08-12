using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 上机完成率
    /// </summary>
    public class StudentLabComplete:BaseEntity
    {
        [ForeignKey(nameof(Student))]
        public int Student_Id { get; set; }
        public Student Student { get; set; }
        [ForeignKey(nameof(Class))]
        public int Class_Id { get; set; }
        public DateTime Time { get; set; }
        /// <summary>
        /// 完成百分比
        /// </summary>
        public int CompletePercent { get; set; }
    }
}
