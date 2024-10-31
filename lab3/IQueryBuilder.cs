using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3
{
    public interface IQueryBuilder
    {
        IQueryBuilder Select(string tableName, params string[] columns);
        IQueryBuilder Where(string condition);
        IQueryBuilder Limit(int limit);
        string GetSQL();
    }
}