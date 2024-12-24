using System.Collections.Generic;
using System.Linq;

namespace ParkingSystem
{
    public class ParkingLot
    {
        private readonly int _totalSlots;
        private readonly List<Vehicle> _slots;

        public ParkingLot(int totalSlots)
        {
            _totalSlots = totalSlots;
            _slots = new List<Vehicle>(new Vehicle[totalSlots]);
        }

        public bool IsFull() => _slots.All(slot => slot != null);

        public bool ParkVehicle(Vehicle vehicle)
        {
            if (IsFull()) return false;

            for (int i = 0; i < _totalSlots; i++)
            {
                if (_slots[i] == null)
                {
                    _slots[i] = vehicle;
                    return true;
                }
            }
            return false;
        }

        public bool LeaveVehicle(int slot)
        {
            if (_slots[slot - 1] != null)
            {
                _slots[slot - 1] = null;
                return true;
            }
            return false;
        }

        public List<Vehicle> GetOccupiedSlots() => _slots.Where(v => v != null).ToList();

        public List<Vehicle> GetVehiclesByType(string type) => _slots.Where(v => v != null && v.Type.Equals(type)).ToList();

        public List<Vehicle> GetVehiclesByColour(string colour) => _slots.Where(v => v != null && v.Colour.Equals(colour)).ToList();

        public int GetSlotForRegistration(string registrationNo) =>
            _slots.FindIndex(v => v != null && v.RegistrationNo.Equals(registrationNo)) + 1;

        public int GetAvailableSlots() => _slots.Count(s => s == null);

        public int GetOccupiedSlotsCount() => _slots.Count(s => s != null);
    }
}
