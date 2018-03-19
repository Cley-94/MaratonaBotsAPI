using System.Collections.Generic;
using WebAPIInstruments.Interface;
using WebAPIInstruments.Models;
using WebAPIInstruments.RepoStorage;

namespace WebAPIInstruments.Service
{
    public class ServiceInstrument : IServiceInstrument
    {
        private IInstrumentRepo _repoInstrument;

        public ServiceInstrument()
        {
            _repoInstrument = new InstrumentRepository();
        }
        public List<InstrumentsModel> GetAllInstruments()
        {
            return _repoInstrument.GetAllInstruments();
        }
    }
}