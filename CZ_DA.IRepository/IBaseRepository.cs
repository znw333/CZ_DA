using System;
using System.Collections.Generic;

namespace CZ_DA.IRepository
{
    using System.Linq.Expressions;
    public interface IBaseRepository<T>
    {
        #region Add
        bool Add(T model);
        bool AddRange(IEnumerable<T> list);
        #endregion

        #region Remove
        bool Remove(T model);
        bool RemoveRange(IEnumerable<T> list);
        bool RemoveById(string Id);
        bool RemoveRangeByIds(IEnumerable<string> IdList);
        #endregion

        #region Modify
        bool Modify(T model);
        bool ModifyRange(IEnumerable<T> list);
        #endregion

        #region Get
        T Get(string Id);
        IEnumerable<T> GetList(Expression<Func<T, bool>> predicateBuilder);
        IEnumerable<T> GetListByPage();
        #endregion
    }
}
