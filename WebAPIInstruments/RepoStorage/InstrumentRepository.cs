using Microsoft.Azure;
using Microsoft.Azure.CosmosDB.Table;
using Microsoft.Azure.Storage;
using System.Collections.Generic;
using System.Linq;
using WebAPIInstruments.Interface;
using WebAPIInstruments.Models;

namespace WebAPIInstruments.RepoStorage
{
    public class InstrumentRepository : IInstrumentRepo
    {
        CloudStorageAccount storageAccount;
        CloudTableClient tableClient;
        CloudTable table;
        
       public List<InstrumentsModel> GetAllInstruments()
        {
            TableQuery<InstrumentsModel> query = new TableQuery<InstrumentsModel>();
            return table.ExecuteQuery(query).ToList();
        }
    }
}