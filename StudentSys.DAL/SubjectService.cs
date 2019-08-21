using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Models;

namespace StudentSys.DAL
{
    public class SubjectService : BaseService<Models.Subject>
    {
        public SubjectService() : base(new StudentContext())
        {
        }
    }
}
