using Microsoft.Azure.CosmosDB.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIInstruments.Models
{
    public class InstrumentsModel : TableEntity
    {
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public string Image { get; set; }
    }
}