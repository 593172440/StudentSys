using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Models;

namespace StudentSys.DAL
{
    public class StudentTalkedService : BaseService<Models.StudentTalked>
    {
        public StudentTalkedService() : base(new StudentContext())
        {
        }
    }
}
