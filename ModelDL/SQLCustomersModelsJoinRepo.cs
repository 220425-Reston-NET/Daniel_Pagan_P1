using Microsoft.Data.SqlClient;
using ModelGundam;

namespace ModelDL
{
    public class SQLCustomersModelsJoinRepo : IRepository<CustomersModelsJoin>
    {
        
        private string _connectionString;
        public SQLCustomersModelsJoinRepo(string c_connectionString)
        {
            this._connectionString = c_connectionString;
        }

        public void Add(CustomersModelsJoin m_resource)
        {
            throw new NotImplementedException();
        }

        public List<CustomersModelsJoin> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(CustomersModelsJoin m_resource)
        {
            string SQLquery = @"update customers_models
                            where customerID = @customerID and @modelID";

           using (SqlConnection con = new SqlConnection(_connectionString))
           {
               con.Open();

               SqlCommand command = new SqlCommand(SQLquery, con);

            //    command.Parameters.AddWithValue("@customerID");
            //    command.Parameters.AddWithValue("@modelID");

               command.ExecuteNonQuery();
           }
        }
    }
}