﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Models;

namespace StudentSys.DAL
{
    public class ClassService : BaseService<Models.Class>
    {
        public ClassService() : base(new StudentContext())
        {
        }
    }
}
