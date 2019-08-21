using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.BLL
{
    public class StudentManager
    {
        /// <summary>
        /// 创建班级
        /// </summary>
        /// <param name="clsName"></param>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        public static async Task CreateClass(string clsName, int gradeId)
        {
            using (var clsSvc = new DAL.ClassService())
            {
                await clsSvc.CreateAsync(new Models.Class()
                {
                    Grade_Id = gradeId,
                    Name = clsName
                });
            }
        }
        /// <summary>
        /// 修改班级
        /// </summary>
        /// <param name="clsId"></param>
        /// <param name="clsName"></param>
        /// <returns></returns>
        public static async Task ChangeClassName(int clsId, string clsName)
        {
            using (var clsSvc = new DAL.ClassService())
            {
                await clsSvc.ChangeName(clsId, clsName);
            }
        }
        /// <summary>
        /// 升学
        /// </summary>
        /// <param name="clsId"></param>
        /// <returns></returns>
        public static async Task LevelUpClass(int clsId)
        {
            using (var clsSvc = new DAL.ClassService())
            {
                var cls = await clsSvc.GetOne(clsId);
                using (var gradeSvc = new DAL.GradeService())
                {
                    var grade = await gradeSvc.GetAll(m => m.Order > cls.Grade.Order).FirstOrDefaultAsync();
                    if (grade == null)
                    {
                        throw new Exception("没有年级可以升级了");
                    }
                }
                int gradeid = cls.Grade.Order;
                await clsSvc.ChangeGrade(clsId, gradeid);
            }
        }
    }
}
