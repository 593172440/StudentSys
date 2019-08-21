using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 年级表
    /// </summary>
    public class Grade:BaseEntity
    {
        /// <summary>
        /// 年级名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int Order { get; set; }
    }
}
