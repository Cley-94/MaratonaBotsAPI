using System.Collections.Generic;
using WebAPIInstruments.Models;

namespace WebAPIInstruments.Interface
{
    public interface IServiceInstrument
    {
        List<InstrumentsModel> GetAllInstruments();
    }
}
