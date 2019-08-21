using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentSys.BLL
{
    /// <summary>
    /// 员工
    /// </summary>
    public class EmployeeManager
    {
        //分配和登录两个功能
        /// <summary>
        /// 根据用户名和密码来登录,并返回用户名的id
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="pwd"></param>
        /// <param name="userId"></param>
        /// <returns>成功为true,失败为false,并且userId=-1</returns>
        public static bool Login(string mail,string pwd,out int userId)
        {
            using (var empSvc = new DAL.EmployeeService())
            {
                var emp=empSvc.GetAll(m => m.Email == mail && m.Password == pwd).FirstOrDefaultAsync();
                emp.Wait();
                if(emp.Result==null)
                {
                    userId = -1;
                    return false;
                }
                else
                {
                    userId = emp.Result.Id;
                    return true;
                }
            }
        }
        /// <summary>
        /// 分配账号/创建职工
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pwd"></param>
        /// <param name="typeid"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static async Task CreateEmployee(string email,string pwd,int typeid,string phone=null)
        {
            using (var empSvc = new DAL.EmployeeService())
            {
                await empSvc.CreateAsync(new Models.Employee()
                {
                    Email = email,
                    Password = pwd,
                    EmployeeType_Id = typeid,
                    Phone = phone
                });
            }
        }
    }
}
