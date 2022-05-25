// using ModelGundam;


// namespace ModelDL
// {
//     public class SQLCustomerRepository : IRepository<Model>
//     {
//         private string _connectionstring = "Server=tcp:restondbdemo220245.cvtq9j4axrge.us-east-1.rds.amazonaws.com;Initial Catalog=Daniel Pagan;Persist Security Info=False;User ID=DP;Password=5^Z<uM;MultipleActiveResultSets=False;Encrypt=TrueServerCertificate=True;Connection Timeout 30;";
//         public void Add(Model m_resource)
//         {
//             throw new NotImplementedException();
//         }

//         public List<Model> GetAll()
//         {
//             string SQLQuery = @"select * from Model";

//             List<Model> listOFModel = new List<Model>();

//             using (SqlConnection con = new SqlConnection(_connectionstring))
//             {
                
//             }
//         }

//         public void Update(Model m_resource)
//         {
//             throw new NotImplementedException();
//         }
//     }
// }