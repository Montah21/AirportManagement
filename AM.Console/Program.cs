// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");

//constructeur par défaut
Plane plane = new Plane();
plane.Capacity = 300;
plane.ManufactureDate = DateTime.Now;
plane.PlaneType = PlaneType.Boing;
//Constructeur paramétré
Plane plane2 = new Plane
    (PlaneType.Boing,new DateTime(2018,2,12),200);

//initialiseur d'objet 
Plane plane3 = new Plane
{
   
    ManufactureDate = DateTime.Now,
    Capacity = 100,
    PlaneType = PlaneType.Boing,
    PlaneId = 2
};

Passenger P = new()
{
    FirstName = "Abir",
    LastName = "Abir",
    EmailAddress = "abir@gmail.com"
};
Staff s1 = new Staff
{
    FirstName = "Youssef"
};

Traveller T1 = new Traveller
{
    FirstName = "aziz"
};

Console.WriteLine(  "*******la methode PassengerType*****");
P.PassengerType();
T1.PassengerType();
s1.PassengerType();
Console.WriteLine("*******CheckProfile*****");
Console.WriteLine(P.CheckProfile("Emna", "Kalel") );

FlightMethods sf = new FlightMethods();
sf.Flights = TestData.listFlights;

Console.WriteLine(  "********GetFlightDates*******");
foreach (var item in sf.GetFlightDates("Paris"))
{
    Console.WriteLine(  item);
}

Console.WriteLine("********ShowFlightDetails****");
sf.ShowFlightDetails(TestData.Airbusplane);

Console.WriteLine("*******DestinationGroupedFlights****");
sf.DestinationGroupedFlights();
