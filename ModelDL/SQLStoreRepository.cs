using Microsoft.Data.SqlClient;
using ModelGundam;

namespace ModelDL
{
    public class SQLStoreRepository : IRepository<Store>
    {
        private string _connectionString;
        public SQLStoreRepository(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }

        public void Add(Store m_resource)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetAll()
        {
            string SqlQery = @"select * from Store";
            List<Store> listOfCurrentStore = new List<Store>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SqlQery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfCurrentStore.Add(new Store(){
                        sId = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Gundams = GetGundamsFromAStore(reader.GetInt32(0))
                    });
                }
            }
            return listOfCurrentStore;
        }
        private List<Gundam> GetGundamsFromAStore(int p_sId)
        {
            string SqlQery = @"Select s.sName, i.Quantity, g.gId, g.gName from Store s
                                inner join Inventory i on s.sId = i.sId
                                inner join Gundam g on i.gId = g.gId
                                where s.sId = @storeId";
            
            List<Gundam> listOfCurrentGundam = new List<Gundam>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SqlQery, con);

                command.Parameters.AddWithValue("@storeId", p_sId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfCurrentGundam.Add(new Gundam(){
                        gId = reader.GetInt32(2),
                        Name = reader.GetString(3),
                        Quantity = reader.GetInt32(1),
                    });
                }
            }
            return listOfCurrentGundam;
        }

        public void Update(Store m_resource)
        {
            throw new NotImplementedException();
        }
    }
}