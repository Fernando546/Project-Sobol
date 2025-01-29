using System;
using System.Collections.Generic;

namespace CRM.Helpers.DataBaseInteraction
{
    internal static class DataBaseGetter
    {
        internal static List<DatabaseObjects.Employees> GetEmployees()
        {
            throw new NotImplementedException();
        }

        internal static List<DatabaseObjects.Clients> GetClients()
        {
            throw new NotImplementedException();
        }

        internal static List<DatabaseObjects.Contracts> GetAllContracts()
        {
            throw new NotImplementedException();
        }

        internal static List<DatabaseObjects.Contracts> GetContractsByClient(int clientId)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        internal static List<DatabaseObjects.Products> GetProductsByContract(int clientID)
        {
            throw new NotImplementedException();
        }
    }
}
