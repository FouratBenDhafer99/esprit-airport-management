using AM.ApplicationCore.Domain;

namespace  AM.UI.Console{
    internal class Program{
        static void Main(string[] args){
            Passenger passenger= new Passenger();
            Staff staff= new Staff();
            Traveller traveller= new Traveller();

            System.Console.WriteLine(passenger.GetPassengerType());
            System.Console.WriteLine(staff.GetStaffType());
            System.Console.WriteLine(traveller.GetTravellerType());
        }
    } 
}