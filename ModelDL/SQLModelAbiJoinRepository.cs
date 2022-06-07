using Microsoft.Data.SqlClient;
using ModelGundam;

namespace ModelDL
{
    public class SQLModelAbiJoinRepository : IRepository<ModelAbiJoin>
    {
       private string _connectionString;
       public SQLModelAbiJoinRepository(string c_connectionString)
       {
           this._connectionString = c_connectionString;
       }
        public void Add(ModelAbiJoin m_resource)
        {
            throw new NotImplementedException();
        }
        public void Update(ModelAbiJoin m_resource)
        {
            //need to correct the sql statement here
            string SQLquery = @"update models_abilities   
                            where modelID = @Ammo and @Armor";
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLquery, con);

                command.ExecuteNonQuery();
            }
        }

        List<ModelAbiJoin> IRepository<ModelAbiJoin>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}