using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Models;

namespace StudentSys.DAL
{
    public class ClassTeacherHasClassService : BaseService<Models.ClassTeacherHasClass>
    {
        public ClassTeacherHasClassService() : base(new StudentContext())
        {
        }
    }
}
