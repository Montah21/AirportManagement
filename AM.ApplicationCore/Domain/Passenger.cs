using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {

        public int Id { get; set; }
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public int? TelNumber { get; set; }
        public string? EmailAddress { get; set; }

        public  IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth: " + BirthDate;
        }

        //poly par signature :
       
       public bool CheckProfile(string nom , string prenom)
        {

         return FirstName.Equals(nom) && LastName.Equals(prenom);

        }

        public bool CheckProfile (string nom , string prenom ,string email)
        {
            // return FirstName.Equals(nom) && LastName.Equals(prenom) && EmailAddress.Equals(email);
            return CheckProfile(nom, prenom) && EmailAddress.Equals(email);
        }

        public bool Login(string nom , string prenom , string email = null)
        {
            //if (email != null)
            //    return CheckProfile(nom, prenom, email);
            //return CheckProfile(nom, prenom);


            return (email != null) ? CheckProfile(nom, prenom, email) : CheckProfile(nom, prenom);


        }

        //poly par héritage 

        public virtual void PassengerType()
        {
            //cwl + 2 tab
            Console.WriteLine("I'am Passenger"  );
        }



       
    }
}
