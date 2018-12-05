using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CZ_DA.Repository
{
    using SqlSugar;
    using CZ_DA.IRepository;

    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        public SqlSugarClient _DBContext = null;
        public BaseRepository()
        {
            _DBContext = CZ_DA.DBContext.Orm.SqlSugarBase.SqlSugarDB;
        }

        #region Add
        public bool AddRange(List<T> list)
        {
            bool response = false;
            if (list != null && list.Count() > 0)
                if (_DBContext != null)
                    response = _DBContext.Insertable(list).ExecuteCommand() > 0;
            return response;
        }
        public bool Add(T model)
        {
            return AddRange(new List<T>() { model });
        }
        #endregion

        #region Remove
        public bool RemoveRange(List<T> list)
        {
            bool response = false;
            if (list != null && list.Count() > 0)
                if (_DBContext != null)
                    response = _DBContext.Deleteable(list).ExecuteCommand() > 0;
            return response;
        }
        public bool Remove(T model)
        {
            return RemoveRange(new List<T>() { model });
        }
        public virtual bool RemoveById(string Id)
        {
            return false;
        }
        public virtual bool RemoveRangeByIds(IEnumerable<string> IdList)
        {
            bool response = false;
            if (IdList != null && IdList.Count() > 0)
            {
                string Ids = string.Join(",", IdList);
            }
            return response;
        }
        #endregion

        #region Modify
        public bool ModifyRange(List<T> list)
        {
            bool response = false;
            if (list != null && list.Count() > 0)
                if (_DBContext != null)
                    response = _DBContext.Updateable(list).ExecuteCommand() > 0;
            return response;
        }
        public bool Modify(T model)
        {
            return ModifyRange(new List<T>() { model });
        }
        #endregion

        #region Get
        public T Get(long Id)
        {
            T model = null;
            if (Id > 0 &&
                _DBContext != null)
                model = _DBContext.GetSimpleClient().GetById<T>(Id);
            return model;
        }
        public IEnumerable<T> GetList(Expression<Func<T, bool>> predicateBuilder)
        {
            IEnumerable<T> list = null;
            if (_DBContext != null)
            {
                if (predicateBuilder == null)
                    list = _DBContext.Queryable<T>().ToList();
                else
                    list = _DBContext.Queryable<T>(predicateBuilder).ToList();
            }
            return list;
        }
        public IEnumerable<T> GetListByPage()
        {
            IEnumerable<T> list = null;
            return list;
        }
        #endregion
    }
}
