using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class BaseService<T> : IDisposable where T : Models.BaseEntity, new()
    {
        protected readonly Models.StudentContext _db;//只有继承baseEntity才能用_db
        public BaseService(Models.StudentContext db)
        {
            _db = db;
        }
        public void Dispose()
        {
            _db.Dispose();
        }
        public async Task CreateAsync(T t, bool saved = true)
        {
            _db.Set<T>().Add(t);
            if (saved)
            {
                await SaveAsync();
            }
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync()
        {
            _db.Configuration.ValidateOnSaveEnabled = false;
            await _db.SaveChangesAsync();
            _db.Configuration.ValidateOnSaveEnabled = true;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="t"></param>
        /// <param name="saved"></param>
        /// <returns></returns>
        public async Task EditAsync(T t, bool saved = true)
        {
            _db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            if (saved)
            {
                await SaveAsync();
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <returns></returns>
        public async Task RemoveAsync(int id, bool saved = true)
        {
            T t = new T() { Id = id };
            _db.Entry(t).State = System.Data.Entity.EntityState.Unchanged;
            t.IsRemoved = true;
            if (saved)
            {
                await SaveAsync();
            }
        }
        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return _db.Set<T>().AsNoTracking().Where(m => !m.IsRemoved);
        }
        /// <summary>
        /// 根据id获取相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetOne(int id)
        {
            return await GetAll().FirstAsync(m => m.Id == id);
        }
        /// <summary>
        /// 自定义条件查询
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }
        /// <summary>
        /// 查询的所有数据并进行排序
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="asc">true:升序;flase:降序</param>
        /// <returns></returns>
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate, bool asc)
        {
            var data = GetAll(predicate);
            if (asc)
            {
                return data.OrderBy(m => m.CreateTime);
            }
            else
            {
                return data.OrderByDescending(m => m.CreateTime);
            }
        }
        /// <summary>
        /// 分页排序
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="asc"></param>
        /// <param name="pageSize">每页有多少条数据,默认:每页10条数据</param>
        /// <param name="pageIndex">一共有多少页</param>
        /// <returns></returns>
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate, bool asc,int pageIndex,int pageSize=10)
        {
            return GetAll(predicate,asc).Skip(pageSize*pageIndex).Take(pageSize);
        }
    }
}
