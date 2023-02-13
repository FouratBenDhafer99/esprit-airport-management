using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

namespace  AM.UI.Console{
    internal class Program{
        static void Main(string[] args){
            
            /*
            Passenger passenger= new Passenger();
            Staff staff= new Staff();
            Traveller traveller= new Traveller();

            System.Console.WriteLine(passenger.GetPassengerType());
            System.Console.WriteLine(staff.GetStaffType());
            System.Console.WriteLine(traveller.GetTravellerType());
            */

            ServiceFlight serviceFlight = new ServiceFlight();

            serviceFlight.Flights= TestData.Flights;

            List<Flight> flights = TestData.Flights;
            System.Console.WriteLine(flights.Count);

            System.Console.WriteLine(serviceFlight.DurationAverage("Paris"));
            //System.Console.WriteLine();
            //serviceFlight.DestinationGroupedFlights();

        }
    } 
}