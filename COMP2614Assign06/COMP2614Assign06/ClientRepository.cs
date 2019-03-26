using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace COMP2614Assign06
{
    public class ClientRepository
    {
        static string connString = @"Server=tcp:skeena.database.windows.net,1433; 
                                     Initial Catalog=comp2614;
                                     User ID=student;
                                     Password=93nu5_zZ5b;
                                     Encrypt=True;
                                     TrustServerCertificate=False;
                                     Connection Timeout=30;";

        public static ClientCollection GetCustomerData()
        {
            ClientCollection clients = new ClientCollection();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query;

                query = @"SELECT ClientCode, CompanyName, Address1, Address2,
                          City, Province, PostalCode, YTDSales, CreditHold, Notes
                          FROM dbo.Client ORDER BY CompanyName";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // none null data
                            string code, comp, addr1, prov;
                            decimal sales;
                            bool hold;

                            code = (string)reader["ClientCode"];
                            comp = (string)reader["CompanyName"];
                            addr1 = (string)reader["Address1"];
                            prov = (string)reader["Province"];
                            sales = (decimal)reader["YTDSales"];
                            hold = (bool)reader["CreditHold"];

                            // potential null data
                            string addr2 = "";
                            string city = "";
                            string post = "";
                            string note = "";

                            if (!reader.IsDBNull(3))
                            {
                                addr2 = (string)reader["Address2"];
                            }

                            if (!reader.IsDBNull(4))
                            {
                                city = (string)reader["City"];
                            }

                            if (!reader.IsDBNull(6))
                            {
                                post = (string)reader["PostalCode"];
                            }

                            if (!reader.IsDBNull(9))
                            {
                                note = (string)reader["Notes"];
                            }

                            clients.Add(new Client
                            {
                                ClientCode = code,
                                CompanyName = comp,
                                Address1 = addr1,
                                Address2 = addr2,
                                City = city,
                                Province = prov,
                                PostalCode = post,
                                YTDSales = sales,
                                CreditHold = hold,
                                Notes = note
                            });
                        }
                    }
                }
            }
            return clients;
        }
    }
}
