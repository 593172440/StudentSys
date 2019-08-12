using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    /// <summary>
    /// 课目表
    /// </summary>
    public class Subject:BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey(nameof(Grade))]
        public int Grade_Id { get; set; }
        public Grade Grade { get; set; }
    }
}
