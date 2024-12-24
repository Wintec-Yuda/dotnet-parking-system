namespace ParkingSystem
{
    public class Vehicle
    {
        public string RegistrationNo { get; }
        public string Type { get; }
        public string Colour { get; }

        public Vehicle(string registrationNo, string type, string colour)
        {
            RegistrationNo = registrationNo;
            Type = type;
            Colour = colour;
        }
    }
}
