using System;
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
        /// <summary>
        /// 根据id和班级名称修改相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clsName"></param>
        /// <returns></returns>
        public async Task ChangeName(int id,string clsName)
        {
            var cls = new Models.Class() { Id = id };
            _db.Entry(cls).State = System.Data.Entity.EntityState.Unchanged;
            cls.Name = clsName;
            await SaveAsync();
        }
        public async Task ChangeGrade(int id,int gradeId)
        {
            var cls = new Models.Class() { Id = id };
            _db.Entry(cls).State = System.Data.Entity.EntityState.Unchanged;
            cls.Grade_Id = gradeId;
            await SaveAsync();
        }
    }
}
