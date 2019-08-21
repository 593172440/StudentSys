using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 系统设置表
    /// </summary>
    public class SysSetting:BaseEntity
    {
        /// <summary>
        /// 作业分值
        /// </summary>
        public int JobScore { get; set; }
        /// <summary>
        /// 作业完成率
        /// </summary>
        public int CompleteScore { get; set; }
        /// <summary>
        /// 检测分值
        /// </summary>
        public int ExamScore { get; set; }
        /// <summary>
        /// 触发分值
        /// </summary>
        public int TriggerScore { get; set; }
    }
}
