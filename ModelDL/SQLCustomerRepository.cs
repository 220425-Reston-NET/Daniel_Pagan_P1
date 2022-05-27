using Microsoft.Data.SqlClient;
using ModelDL;
using ModelGundam;

public class SQLCustomerRepository : IRepository<Customer>
{
    private string _connectionString;
    public SQLCustomerRepository(string m_connectionString)
    {
        this._connectionString = m_connectionString;
    }
    public void Add(Customer m_resource)
    {
        string SQLQuery = @"insert into Customer 
                            values (@customerName, @customerAddress, @customerPhone, @customerEmail)";

        using (SqlConnection con = new SqlConnection(_connectionString))
        {
            con.Open();

            SqlCommand command = new SqlCommand(SQLQuery, con);

            command.Parameters.AddWithValue("@customerName", m_resource.Name);
            command.Parameters.AddWithValue("@customerAddress", m_resource.Address);
            command.Parameters.AddWithValue("@customerPhone", m_resource.Phone);
            command.Parameters.AddWithValue("@customerEmail", m_resource.Email);

            command.ExecuteNonQuery();
        }
    }

    public List<Customer> GetAll()
    {
        string SQLQuery = @"select * from Customer";
        List<Customer> listOfCustomer = new List<Customer>();

        using (SqlConnection con = new SqlConnection(_connectionString))
        {
            con.Open();

            SqlCommand command = new SqlCommand(SQLQuery, con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listOfCustomer.Add(new Customer()
                {
                    customerID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Address = reader.GetString(2),
                    Phone = (double)reader.GetDecimal(3),
                    Email = reader.GetString(4)
                });
            }
            return listOfCustomer;
        }
    }

    public void Update(Customer m_resource)
    {
        throw new NotImplementedException();
    }
}