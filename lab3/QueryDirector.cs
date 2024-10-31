using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3
{
    public class QueryDirector
    {
        private IQueryBuilder _queryBuilder;

        public QueryDirector(IQueryBuilder queryBuilder)
        {
            _queryBuilder = queryBuilder;
        }

        public string BuildSampleQuery()
        {
            return _queryBuilder
                .Select("users", "id", "name", "email")
                .Where("age > 18")
                .Limit(10)
                .GetSQL();
        }
    }
}