using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CSharp.Repoistory
{
    public class ArticleRepository
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True";

        public void Svae(Article article)//发布
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"insert Article(Title) values(N'{article.Title}')";
                command.ExecuteNonQuery();
            }
        }


        public Article GetById(int id)//单页呈现
        {
            Article article = new Article();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select [Userame],Id from Article where Id={id} ";
                IDataReader reader = command.ExecuteReader();
                reader.Read();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine(reader[i]+" ");
                    }
                    Console.WriteLine();
                }

            }

            return article;
        }
    }
}
