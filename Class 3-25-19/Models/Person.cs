using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Class_3_25_19.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int id { get; set; }
    }

    public class PersonManager
    {
        private string _connectionString;

        public PersonManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddPerson(List<Person> p)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            SqlCommand cmd = conn.CreateCommand();
           
            foreach (Person person in p)
            {
                cmd.CommandText = "insert into People values (@firstname,@lastname,@age)";
                cmd.Parameters.AddWithValue("@firstname", person.FirstName);
                cmd.Parameters.AddWithValue("@lastname", person.LastName);
                cmd.Parameters.AddWithValue("@age", person.Age);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
          
            conn.Close();
            conn.Dispose();
        }

        public IEnumerable<Person> GetPeople()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM People";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Person> ppl = new List<Person>();
            while (reader.Read())
            {
                ppl.Add(new Person
                {
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    Age = (int)reader["Age"],
                    id = (int)reader["id"]
                });
            }
            return ppl;
        }
    }
}