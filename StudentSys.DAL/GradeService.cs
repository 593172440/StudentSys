using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Models;

namespace StudentSys.DAL
{
    public class GradeService : BaseService<Models.Grade>
    {
        public GradeService() : base(new StudentContext())
        {
        }
    }
}
