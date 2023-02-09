using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class TestData{
        public static List<Plane> Planes { 
            get{
                return new List<Plane>()
                {
                    new Plane(){
                        MyPlaneType= PlaneType.Boing,
                        Capacity= 150,
                        ManufactureDate= new DateTime(2015, 02, 03)
                    },
                    new Plane(){
                        MyPlaneType= PlaneType.Airbus,
                        Capacity= 250,
                        ManufactureDate= new DateTime(2020, 11, 11)
                    }
                };
            } 
        }

        public static List<Staff> Staff{
            get{
                return new List<Staff>(){
                    new Staff(){
                        FirstName="Captain",
                        LastName="Captain",
                        EmailAdress= "Captain.captain@gmail.com",
                        BirthDate = new DateTime(1965,01,01),
                        EmploymentDate = new DateTime(1999,01,01),
                        Salary=99999
                    },
                    new Staff(){
                        FirstName="Hostess1",
                        LastName="Hostess1",
                        EmailAdress= "hostess1.hostess1@gmail.com",
                        BirthDate = new DateTime(1995,01,01),
                        EmploymentDate = new DateTime(2020,01,01),
                        Salary=999
                    },
                    new Staff(){
                        FirstName="Hostess2",
                        LastName="Hostess2",
                        EmailAdress= "hostess2.hostess2@gmail.com",
                        BirthDate = new DateTime(1996,01,01),
                        EmploymentDate = new DateTime(2020,01,01),
                        Salary=999
                    }
                };
            }
        }

        public static List<Traveller> Travellers{
            get{
                return new List<Traveller>(){
                    new Traveller(){
                        FirstName="Traveller1",
                        LastName="Traveller1",
                        EmailAdress="Traveller1.Traveller1@gmail.com",
                        BirthDate= new DateTime(1980,01,01),
                        HealthInformation="No Troubles",
                        Nationality="American"
                    },
                    new Traveller(){
                        FirstName="Traveller2",
                        LastName="Traveller2",
                        EmailAdress="Traveller2.Traveller2@gmail.com",
                        BirthDate= new DateTime(1981,01,01),
                        HealthInformation="Some Troubles",
                        Nationality="French"
                    },
                    new Traveller(){
                        FirstName="Traveller3",
                        LastName="Traveller3",
                        EmailAdress="Traveller3.Traveller3@gmail.com",
                        BirthDate= new DateTime(1982,01,01),
                        HealthInformation="No Troubles",
                        Nationality="Tunisian"
                    },
                    new Traveller(){
                        FirstName="Traveller4",
                        LastName="Traveller4",
                        EmailAdress="Traveller4.Traveller4@gmail.com",
                        BirthDate= new DateTime(1983,01,01),
                        HealthInformation="Some Troubles",
                        Nationality="American"
                    },
                    new Traveller(){
                        FirstName="Traveller4",
                        LastName="Traveller4",
                        EmailAdress="Traveller5.Traveller5@gmail.com",
                        BirthDate= new DateTime(1984,01,01),
                        HealthInformation="Some Troubles",
                        Nationality="American"
                    }
                };
            }
        }

        public static List<Flight> Flights{
            get{
                return new List<Flight>() {
                    new Flight(){
                        FlightDate= new DateTime(2022,01,01,15,10,10),
                        Destination= "Paris",
                        EffectiveArrival= new DateTime(2022,01,01,17,10,10),
                        Plane = Planes[1],
                        EstimatedDuration= 110,
                        Passengers = new List<Passenger> (Travellers)
                    },

                };
            }
        }
    }
}
