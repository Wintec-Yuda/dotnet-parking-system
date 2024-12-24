using System;
using System.Linq;

namespace ParkingSystem
{
    public class ParkingService
    {
        private readonly ParkingLot _parkingLot;

        public ParkingService(ParkingLot parkingLot)
        {
            _parkingLot = parkingLot;
        }

        public void CreateParkingLot(int totalSlots)
        {
            Console.WriteLine($"Created a parking lot with {totalSlots} slots");
        }

        public void Park(string registrationNo, string type, string colour)
        {
            if (type != "Mobil" && type != "Motor")
            {
                Console.WriteLine("Only Mobil and Motor are allowed");
                return;
            }

            var vehicle = new Vehicle(registrationNo, type, colour);

            if (_parkingLot.ParkVehicle(vehicle))
            {
                var allocatedSlot = _parkingLot.GetOccupiedSlots().Last();
                Console.WriteLine($"Allocated slot number: {_parkingLot.GetSlotForRegistration(registrationNo)}");
            }
            else
            {
                Console.WriteLine("Sorry, parking lot is full");
            }
        }

        public void Leave(int slot)
        {
            if (_parkingLot.LeaveVehicle(slot))
            {
                Console.WriteLine($"Slot number {slot} is free");
            }
            else
            {
                Console.WriteLine($"Slot number {slot} is already empty");
            }
        }

        public void ShowStatus()
        {
            var occupiedSlots = _parkingLot.GetOccupiedSlots();
            Console.WriteLine("Slot No. Type Registration No Colour");
            foreach (var vehicle in occupiedSlots)
            {
                var slotNo = _parkingLot.GetSlotForRegistration(vehicle.RegistrationNo);
                Console.WriteLine($"{slotNo} {vehicle.Type} {vehicle.RegistrationNo} {vehicle.Colour}");
            }
        }

        public void ReportByType(string type)
        {
            var vehicles = _parkingLot.GetVehiclesByType(type);
            Console.WriteLine(vehicles.Count);
        }

        public void ReportByRegistrationPrefix(string prefix)
        {
            var vehicles = _parkingLot.GetOccupiedSlots()
                .Where(v => v.RegistrationNo.StartsWith(prefix))
                .Select(v => v.RegistrationNo)
                .ToList();

            Console.WriteLine(string.Join(", ", vehicles));
        }

        public void ReportByColour(string colour)
        {
            var vehicles = _parkingLot.GetVehiclesByColour(colour)
                .Select(v => v.RegistrationNo)
                .ToList();

            Console.WriteLine(string.Join(", ", vehicles));
        }

        public void ReportSlotForRegistration(string registrationNo)
        {
            var slot = _parkingLot.GetSlotForRegistration(registrationNo);
            if (slot != 0)
            {
                Console.WriteLine(slot);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void GetAvailableSlots() => Console.WriteLine(_parkingLot.GetAvailableSlots());

        public void GetOccupiedSlotsCount() => Console.WriteLine(_parkingLot.GetOccupiedSlotsCount());
    }
}
