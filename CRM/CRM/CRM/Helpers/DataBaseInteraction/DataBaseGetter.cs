using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CRM.Helpers.DataBaseInteraction
{
    internal static class DataBaseGetter
    {
        internal static List<DatabaseObjects.Employees> GetEmployees()
        {
            List<DatabaseObjects.Employees> employees = new List<DatabaseObjects.Employees>();
            string query = "SELECT Id, Admin, Username, Password FROM Employees";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new DatabaseObjects.Employees
                        {
                            ID = reader.GetInt64(0),
                            Admin = reader.GetBoolean(1),
                            Username = reader.GetString(2),
                            Password = reader.GetString(3)
                        });
                    }
                }
            }

            return employees;
        }

        internal static List<DatabaseObjects.Clients> GetClients()
        {
            List<DatabaseObjects.Clients> clients = new List<DatabaseObjects.Clients>();
            string query = "SELECT Id, Name, LastContact, Phone, Email FROM Clients";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new DatabaseObjects.Clients
                        {
                            ID = reader.GetInt64(0),
                            Name = reader.GetString(1),
                            LastContact = (System.Data.SqlTypes.SqlDateTime)(reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2)),
                            Phone = reader.GetString(3),
                            EMail = reader.GetString(4)
                        });
                    }
                }
            }

            return clients;
        }

        internal static List<DatabaseObjects.Contracts> GetAllContracts()
        {
            List<DatabaseObjects.Contracts> contracts = new List<DatabaseObjects.Contracts>();
            string query = "SELECT Id, EmployeeID, ClientID, Type, Name, Cost, Profit, FinalProfit, SignDate, ExpireDate FROM Contracts";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contracts.Add(new DatabaseObjects.Contracts
                        {
                            ID = reader.GetInt64(0),
                            EmployeeID = reader.GetInt64(1),
                            ClientID = reader.GetInt64(2),
                            Type = reader.GetString(3),
                            Name = reader.GetString(4),
                            Cost = reader.GetDecimal(5),
                            Profit = reader.GetDecimal(6),
                            FinalProfit = reader.GetDecimal(7),
                            SignDate = (System.Data.SqlTypes.SqlDateTime)(reader.IsDBNull(8) ? (DateTime?)null : reader.GetDateTime(8)),
                            ExpireDate = (System.Data.SqlTypes.SqlDateTime)(reader.IsDBNull(9) ? (DateTime?)null : reader.GetDateTime(9))
                        });
                    }
                }
            }

            return contracts;
        }

        internal static List<DatabaseObjects.Contracts> GetContractsByClient(long clientId)
        {
            List<DatabaseObjects.Contracts> contracts = new List<DatabaseObjects.Contracts>();
            string query = "SELECT Id, EmployeeID, ClientID, Type, Name, Cost, Profit, FinalProfit, SignDate, ExpireDate FROM Contracts WHERE ClientID = @ClientId";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ClientId", clientId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contracts.Add(new DatabaseObjects.Contracts
                        {
                            ID = reader.GetInt64(0),
                            EmployeeID = reader.GetInt64(1),
                            ClientID = reader.GetInt64(2),
                            Type = reader.GetString(3),
                            Name = reader.GetString(4),
                            Cost = reader.GetDecimal(5),
                            Profit = reader.GetDecimal(6),
                            FinalProfit = reader.GetDecimal(7),
                            SignDate = (System.Data.SqlTypes.SqlDateTime)(reader.IsDBNull(8) ? (DateTime?)null : reader.GetDateTime(8)),
                            ExpireDate = (System.Data.SqlTypes.SqlDateTime)(reader.IsDBNull(9) ? (DateTime?)null : reader.GetDateTime(9))
                        });
                    }
                }
            }

            return contracts;
        }

        internal static List<DatabaseObjects.Contracts> GetContractsByUser(int userID)
        {
            throw new NotImplementedException();
        }

        internal static List<DatabaseObjects.Contracts> GetContractsByUserAndClient(int userID, int clientID)
        {
            throw new NotImplementedException();
        }

        internal static List<DatabaseObjects.Events> GetEvents()
        {
            List<DatabaseObjects.Events> events = new List<DatabaseObjects.Events>();
            string query = "SELECT Id, ClientID, EmployeeID, Date, Type, Description FROM Events";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        events.Add(new DatabaseObjects.Events
                        {
                            ID = reader.GetInt64(0),
                            ClientID = reader.GetInt64(1),
                            EmployeeID = reader.GetInt64(2),
                            Date = (System.Data.SqlTypes.SqlDateTime)(reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3)),
                            Type = reader.GetChar(4),
                            Description = reader.GetString(5)
                        });
                    }
                }
            }

            return events;
        }

        internal static List<DatabaseObjects.Events> GetEventsByClient(int clientID)
        {
            throw new NotImplementedException();
        }

        internal static List<DatabaseObjects.Events> GetEventsByUser(int userID)
        {
            throw new NotImplementedException();
        }

        internal static List<DatabaseObjects.Events> GetEventsByUserAndClient(int userID, int clientID)
        {
            throw new NotImplementedException();
        }

        internal static List<DatabaseObjects.Products> GetProducts()
        {
            List<DatabaseObjects.Products> products = new List<DatabaseObjects.Products>();
            string query = "SELECT Id, ContractID, Name, Cost, Type, Amount FROM Products";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new DatabaseObjects.Products
                        {
                            ID = reader.GetInt64(0),
                            ContractID = reader.GetInt64(1),
                            Name = reader.GetString(2),
                            Cost = reader.GetDecimal(3),
                            Type = reader.GetBoolean(4),
                            Amount = reader.GetInt64(5)
                        });
                    }
                }
            }

            return products;
        }

        internal static List<DatabaseObjects.Products> GetProductsByContract(int clientID)
        {
            throw new NotImplementedException();
        }
    }
}
