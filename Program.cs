using System;

namespace ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = null;
            ParkingService parkingService = null;

            while (true)
            {
                var command = Console.ReadLine().Trim();

                if (command.StartsWith("create_parking_lot"))
                {
                    var parts = command.Split(' ');
                    int lotSize = int.Parse(parts[1]);
                    parkingLot = new ParkingLot(lotSize);
                    parkingService = new ParkingService(parkingLot);
                    parkingService.CreateParkingLot(lotSize);
                }
                else if (command.StartsWith("park"))
                {
                    var parts = command.Split(' ');
                    var registrationNo = parts[1];
                    var colour = parts[2];
                    var type = parts[3];

                    parkingService?.Park(registrationNo, type, colour);
                }
                else if (command.StartsWith("leave"))
                {
                    var parts = command.Split(' ');
                    int slotNumber = int.Parse(parts[1]);
                    parkingService?.Leave(slotNumber);
                }
                else if (command == "status")
                {
                    parkingService?.ShowStatus();
                }
                else if (command.StartsWith("type_of_vehicles"))
                {
                    var parts = command.Split(' ');
                    var type = parts[1];
                    parkingService?.ReportByType(type);
                }
                else if (command.StartsWith("registration_numbers_for_vehicles_with"))
                {
                    var parts = command.Split(' ');
                    var prefix = parts[1];
                    parkingService?.ReportByRegistrationPrefix(prefix);
                }
                else if (command.StartsWith("registration_numbers_for_vehicles_with_colour"))
                {
                    var parts = command.Split(' ');
                    var colour = parts[1];
                    parkingService?.ReportByColour(colour);
                }
                else if (command.StartsWith("slot_numbers_for_vehicles_with_colour"))
                {
                    var parts = command.Split(' ');
                    var colour = parts[1];
                    parkingService?.ReportSlotForRegistration(colour);
                }
                else if (command.StartsWith("slot_number_for_registration_number"))
                {
                    var parts = command.Split(' ');
                    var registrationNo = parts[1];
                    parkingService?.ReportSlotForRegistration(registrationNo);
                }
                else if (command == "exit")
                {
                    break;
                }
            }
        }
    }
}
