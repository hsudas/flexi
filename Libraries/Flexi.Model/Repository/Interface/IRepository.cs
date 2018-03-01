using System;
using System.Collections.Generic;

namespace Flexi.Model.Repository.Interface
{
    public interface IRepository<T>
    {
        List<T> GetList();
        List<T> GetList(Object whereConditions);
        int GetRecordCount(Object whereConditions);
        int GetRecordCount(string whereConditions);
        List<T> GetWhere(string whereSql);
        int Add(T entity);
        int Update(T entity);
        void Remove(int id);
        void Remove(T entity);
        T GetById(int id);
        T Get(Object whereConditions);
        List<T> Execute(string sql);
        List<T> ExecuteQuery<T>(string sql);
    }
}
