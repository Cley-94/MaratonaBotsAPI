using WebAPIInstruments.Models;
using System.Collections.Generic;

namespace WebAPIInstruments.Interface
{
    public interface IInstrumentRepo
    {
        List<InstrumentsModel> GetAllInstruments();
    }
}
