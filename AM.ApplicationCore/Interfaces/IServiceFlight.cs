using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight{

        //public List<DateTime> GetFlightDates(string _Destination);

        public IEnumerable<DateTime> GetFlightDates(string _Destination);

        public void GetFlights(string _FilterType, string _FilterValue);
    }
}
