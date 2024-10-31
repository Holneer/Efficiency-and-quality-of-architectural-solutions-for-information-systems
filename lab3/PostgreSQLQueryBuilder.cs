using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3
{
    public class PostgreSQLQueryBuilder : IQueryBuilder
    {
        private string _query;

        public IQueryBuilder Select(string tableName, params string[] columns)
        {
            _query = $"SELECT {string.Join(", ", columns)} FROM {tableName}";
            Console.WriteLine($"[PostgreSQL] Формування запиту: {_query}");
            return this;
        }

        public IQueryBuilder Where(string condition)
        {
            _query += $" WHERE {condition}";
            Console.WriteLine($"[PostgreSQL] Додавання умови: {condition}");
            return this;
        }

        public IQueryBuilder Limit(int limit)
        {
            _query += $" LIMIT {limit}";
            Console.WriteLine($"[PostgreSQL] Додавання ліміту: {limit}");
            return this;
        }

        public string GetSQL()
        {
            Console.WriteLine($"[PostgreSQL] Повернення згенерованого SQL: {_query}");
            return _query;
        }
    }
}