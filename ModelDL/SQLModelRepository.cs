using Microsoft.Data.SqlClient;
using ModelGundam;

namespace ModelDL
{
    public class SQLModelRepository : IRepository<Model>
    {
        private string _connectionString;
        public SQLModelRepository(string m_connectionString)
        {
            this._connectionString = m_connectionString;
        }

        public void Add(Model m_resource)
        {
            string SQLQuery = @"insert into Model
                                values (@modelName, @modelType, @modelArmor)";
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@modelName", m_resource.Name);
                command.Parameters.AddWithValue("@modelType", m_resource.Type);
                command.Parameters.AddWithValue("@modelArmor", m_resource.Armor);

                command.ExecuteNonQuery();
            }
        }

        public List<Model> GetAll()
        {
            string SQLQuery = @"select * from Model";
            List<Model> listOfModel = new List<Model>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfModel.Add(new Model(){
                        ModelID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Type = reader.GetString(2),
                        Armor = reader.GetInt32(3),
                        Abilities = GiveAbilityToModel(reader.GetInt32(0))
                    });
                }

                return listOfModel;
            }

        }

        private List<Ability> GiveAbilityToModel(int m_modelID)
        {
            string SQLQuery = @"select m.modelName, a.abilityName, a.Ammo, a.Armor, a.abilityID from Model m
                            inner join models_abilities ma on m.modelID = ma.modelID
                            inner join Ability a on a.abilityID = ma.abilityID
                            where m.modelID = @modelID";
            
            List<Ability> listOfAbility = new List<Ability>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@modelID", m_modelID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfAbility.Add(new Ability(){
                        ID = reader.GetInt32(4),
                        Name = reader.GetString(1),
                        Ammo = reader.GetInt32(3),
                        Armor = reader.GetInt32(2),
                    });
                }
            }

            return listOfAbility;

        }
        public void Update(Model m_resource)
        {
            throw new NotImplementedException();
        }
    }
}