using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 班级表
    /// </summary>
    public class Class:BaseEntity
    {
        /// <summary>
        /// 班级名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否毕业
        /// </summary>
        public string IsGraduation { get; set; }

        [ForeignKey(nameof(Grade))]
        public int Grade_Id { get; set; }
        public Grade Grade { get; set; }
    }
}
