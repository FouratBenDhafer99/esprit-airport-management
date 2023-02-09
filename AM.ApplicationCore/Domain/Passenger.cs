using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger{
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; } 
        public string EmailAdress{ get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public int TelNumber { get; set;}
        public ICollection<Flight> Flights { get; set; }

        public override string ToString(){
            return "Name: "+FirstName+" "+LastName+", Passport Number: "+PassportNumber
                +", Birth Date: "+ BirthDate + ", Email: "+ EmailAdress+
                ", Tel: "+TelNumber;
        }

        /*
        public bool CheckProfile(string _Name, string _LastName){
          return FirstName== _Name && LastName==_LastName;
        }

        public bool CheckProfile(string _Name, string _LastName, string _Email){
            return FirstName == _Name && LastName == _LastName && EmailAdress == _Email;
        }
        */

        public bool CheckProfile(string _Name, string _LastName, string? _Email)
        {
            return FirstName == _Name && LastName == _LastName && (_Email == null || EmailAdress == _Email);
        }

        public virtual string GetPassengerType() {
            return "I'm a passenger";
        }

    }
}
