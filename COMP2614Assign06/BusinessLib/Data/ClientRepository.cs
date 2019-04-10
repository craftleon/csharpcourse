using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BusinessLib.Common;

namespace BusinessLib.Data
{
    public class ClientRepository
    {
        private static readonly string connString = @"Server=tcp:skeena.database.windows.net,1433; 
                                     Initial Catalog=comp2614;
                                     User ID=student;
                                     Password=93nu5_zZ5b;
                                     Encrypt=True;
                                     TrustServerCertificate=False;
                                     Connection Timeout=30;";

        private static readonly string tableName = "Client160545";

        public static ClientCollection GetClients()
        {
            ClientCollection clients = new ClientCollection();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query;

                query = $@"SELECT ClientCode, CompanyName, Address1, Address2,
                          City, Province, PostalCode, YTDSales, CreditHold, Notes
                          FROM {tableName} ORDER BY ClientCode";

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
                            // none nullable data
                            string code, comp, addr1, prov;
                            decimal sales;
                            bool hold;

                            code = reader["ClientCode"] as string;
                            comp = reader["CompanyName"] as string;
                            addr1 = reader["Address1"] as string;
                            prov = reader["Province"] as string;
                            sales = (decimal)reader["YTDSales"];
                            hold = (bool)reader["CreditHold"];

                            // nullable data
                            string addr2;
                            string city;
                            string post;
                            string note;

                            if (!reader.IsDBNull(3))
                            {
                                addr2 = reader["Address2"] as string;
                            }
                            else
                            {
                                addr2 = null;
                            }

                            if (!reader.IsDBNull(4))
                            {
                                city = reader["City"] as string;
                            }
                            else
                            {
                                city = null;
                            }

                            if (!reader.IsDBNull(6))
                            {
                                post = reader["PostalCode"] as string;
                            }
                            else
                            {
                                post = null;
                            }

                            if (!reader.IsDBNull(9))
                            {
                                note = reader["Notes"] as string;
                            }
                            else
                            {
                                note = null;
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

        private static int executeClientDbCommand(string query, Client client)
        {
            int rowsAffected = 0;   // returning 0 means DB error

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    // non nullable data
                    cmd.Parameters.AddWithValue("@code", client.ClientCode);
                    cmd.Parameters.AddWithValue("@comp", client.CompanyName);
                    cmd.Parameters.AddWithValue("@addr1", client.Address1);
                    cmd.Parameters.AddWithValue("@prov", client.Province);
                    cmd.Parameters.AddWithValue("@sales", client.YTDSales);
                    cmd.Parameters.AddWithValue("@hold", client.CreditHold);

                    // nullable data
                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@addr2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@addr2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@post", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@post", DBNull.Value);
                    }

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@note", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@note", DBNull.Value);
                    }

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        public static int AddClient(Client client)
        {
            string query = $@"INSERT INTO {tableName}
                              (ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes)
                              VALUES (@code, @comp, @addr1, @addr2, @city, @prov, @post, @sales, @hold, @note)";

            return executeClientDbCommand(query, client);
        }

        public static int UpdateClient(Client client)
        {
            string query = $@"UPDATE {tableName}
                              SET ClientCode = @code,
                                  CompanyName = @comp,
                                  Address1 = @addr1,
                                  Address2 = @addr2,
                                  City = @city,
                                  Province = @prov,
                                  PostalCode = @post,
                                  YTDSales = @sales,
                                  CreditHold = @hold,
                                  Notes = @note
                              WHERE ClientCode = @code";

            return executeClientDbCommand(query, client);
        }

        public static int DeleteClient(Client client)
        {
            string query = $@"DELETE {tableName}
                              WHERE ClientCode = @code";

            return executeClientDbCommand(query, client);
        }

        public static List<string> GetProvinceList()
        {
            List<string> provinces = new List<string>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query;

                query = $@"SELECT DISTINCT Sort, Abbreviation
                          FROM Province ORDER BY Sort";

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
                            // none nullable data
                            string prov = reader["Abbreviation"] as string;
                            provinces.Add(prov);
                        }
                    }
                }
            }

            return provinces;
        }
    }
}
