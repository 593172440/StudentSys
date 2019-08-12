using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 亲属表
    /// </summary>
    public class StudentRelative:BaseEntity
    {
        [ForeignKey(nameof(Student))]
        public int Student_Id { get; set; }
        public Student Student { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public string TypeName { get; set; }
        public string Phone { get; set; }
    }
}
