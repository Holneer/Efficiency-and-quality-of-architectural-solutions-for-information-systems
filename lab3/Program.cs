using lab3;

IQueryBuilder postgreSQLBuilder = new PostgreSQLQueryBuilder();
QueryDirector postgreSQLDirector = new QueryDirector(postgreSQLBuilder);
string postgreSQLQuery = postgreSQLDirector.BuildSampleQuery();
Console.WriteLine($"Згенерований SQL для PostgreSQL: {postgreSQLQuery}");

Console.WriteLine();

IQueryBuilder mySQLBuilder = new MySQLQueryBuilder();
QueryDirector mySQLDirector = new QueryDirector(mySQLBuilder);
string mySQLQuery = mySQLDirector.BuildSampleQuery();
Console.WriteLine($"Згенерований SQL для MySQL: {mySQLQuery}");