using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight: IServiceFlight{

        public List<Flight> Flights { get; set; }= new List<Flight>();

        /*
        public List<DateTime> GetFlightDates(string _Destination){
            List<DateTime> result = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                Flight flight = Flights[i];
                if (flight.Destination == _Destination)
                {
                    result.Add(flight.FlightDate);
                }
            }
            return result;
        }
        */

        /*
        public IEnumerable<DateTime> GetFlightDates(string destination){
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    yield return flight.FlightDate;
                }
            }
        }
        */

        public IEnumerable<DateTime> GetFlightDates(string destination){
            return from flight in Flights
                   where flight.Destination == destination
                   select flight.FlightDate;
        }

        public void ShowFlightDetails(Plane plane){
            var query= from flight in Flights
                                         where flight.Plane.PlaneId == plane.PlaneId
                                         select new {flight.FlightDate, flight.Destination};
            foreach (var flight in query)
                System.Console.WriteLine("Date dep: "+flight.FlightDate+" | Destination: "+flight.Destination);
        }

        public int ProggramedFlightNumber(DateTime startDate) {
            return (from flight in Flights
                   where flight.FlightDate>= startDate && flight.FlightDate<= startDate.AddDays(7)
                   select flight).Count();
        }

        public double DurationAverage(string destination){
            return Flights.Where(flight => flight.Destination == destination).Select(flight=> flight.EstimatedDuration).Average();
        }

        public IEnumerable<Flight> OrderedDuration(){
            return Flights.OrderByDescending(flight => flight.EstimatedDuration);
        }

        public IEnumerable<Passenger> SeniorTraveller(Flight flight) {
            return flight.Passengers.OrderByDescending(p => p.BirthDate).Take(3) ;
        }

        public void DestinationGroupedFlights(){
            var res= Flights.GroupBy(f => f.Destination);
            foreach (var grp in res){
                System.Console.WriteLine(grp.Key);
                foreach (var item in grp){
                    System.Console.WriteLine("Decolage:"+ item);
                }
            }

        }
        public void GetFlights(string filterType, string filterValue){
            switch (filterType){
                case "Destination": { 
                        var result= Flights.Where(f => f.Destination == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "Departure":{
                        var result = Flights.Where(f => f.Departure == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightDate":{
                        var result = Flights.Where(f => f.FlightDate == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightId":{
                        var result = Flights.Where(f => f.FlightId == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EffectiveArrival":
                    {
                        var result = Flights.Where(f => f.EffectiveArrival == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    {
                        var result = Flights.Where(f => f.EstimatedDuration == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
            }
        }

        
    }
}
