# Parking System

A simple parking system built with .NET Core 5.0 that simulates the management of parking slots for vehicles such as cars and motorcycles. This system allows users to park, leave, and view the status of parking slots.

## Features

- **Create Parking Lot**: Create a parking lot with a specific number of slots.
- **Park Vehicle**: Park a car or motorcycle in the first available slot.
- **Leave Parking Lot**: Free up a parking slot when a vehicle leaves.
- **Status Report**: Display the current status of all parking slots.
- **Reports**: Generate various reports based on vehicle type, color, or registration number.

## Installation

### Prerequisites
- .NET SDK 5.0 or later
- A text editor like Visual Studio Code (VS Code) or Visual Studio

### Steps to Install

1. Clone the repository to your local machine:
    ```bash
    git clone https://github.com/your-username/parking-system.git
    ```

2. Navigate to the project folder:
    ```bash
    cd parking-system
    ```

3. Restore the required NuGet packages:
    ```bash
    dotnet restore
    ```

4. Build the project:
    ```bash
    dotnet build
    ```

5. Run the application:
    ```bash
    dotnet run
    ```

## Usage

### Commands

- **`create_parking_lot <number of slots>`**: Create a parking lot with the specified number of slots.
    - Example: `create_parking_lot 6`

- **`park <registration number> <color> <vehicle type>`**: Park a vehicle in the first available slot.
    - Example: `park B-1234-XYZ Putih Mobil`

- **`leave <slot number>`**: Free up a parking slot when a vehicle leaves.
    - Example: `leave 4`

- **`status`**: View the current status of all parking slots.
    - Example:
      ```bash
      Slot No. | Type  | Registration No. | Colour
      1        | Mobil | B-1234-XYZ       | Putih
      2        | Motor | B-9999-XYZ       | Putih
      ```

- **`type_of_vehicles <vehicle type>`**: Get the count of vehicles based on their type (Mobil/Motor).
    - Example: `type_of_vehicles Motor`

- **`registration_numbers_for_vehicles_with_colour <color>`**: Get the registration numbers of vehicles with the specified color.
    - Example: `registration_numbers_for_vehicles_with_colour Putih`

- **`slot_numbers_for_vehicles_with_colour <color>`**: Get the slot numbers for vehicles with the specified color.
    - Example: `slot_numbers_for_vehicles_with_colour Putih`

- **`slot_number_for_registration_number <registration number>`**: Get the slot number for a specific vehicle's registration number.
    - Example: `slot_number_for_registration_number B-3141-ZZZ`

- **`exit`**: Exit the program.

### Example Usage

```bash
$ create_parking_lot 6
Created a parking lot with 6 slots

$ park B-1234-XYZ Putih Mobil
Allocated slot number: 1

$ park B-9999-XYZ Putih Motor
Allocated slot number: 2

$ park D-0001-HIJ Hitam Mobil
Allocated slot number: 3

$ leave 2
Slot number 2 is free

$ status
Slot No. | Type  | Registration No. | Colour
1        | Mobil | B-1234-XYZ       | Putih
3        | Mobil | D-0001-HIJ       | Hitam

```

# Parking System

A simple parking system built with .NET Core 5.0 that simulates the management of parking slots for vehicles such as cars and motorcycles. This system allows users to park, leave, and view the status of parking slots.

## Features

- **Create Parking Lot**: Create a parking lot with a specific number of slots.
- **Park Vehicle**: Park a car or motorcycle in the first available slot.
- **Leave Parking Lot**: Free up a parking slot when a vehicle leaves.
- **Status Report**: Display the current status of all parking slots.
- **Reports**: Generate various reports based on vehicle type, color, or registration number.

## Installation

### Prerequisites
- .NET SDK 5.0 or later
- A text editor like Visual Studio Code (VS Code) or Visual Studio

### Steps to Install

1. Clone the repository to your local machine:
    ```bash
    git clone https://github.com/your-username/parking-system.git
    ```

2. Navigate to the project folder:
    ```bash
    cd parking-system
    ```

3. Restore the required NuGet packages:
    ```bash
    dotnet restore
    ```

4. Build the project:
    ```bash
    dotnet build
    ```

5. Run the application:
    ```bash
    dotnet run
    ```

## Usage

### Commands

- **`create_parking_lot <number of slots>`**: Create a parking lot with the specified number of slots.
    - Example: `create_parking_lot 6`

- **`park <registration number> <color> <vehicle type>`**: Park a vehicle in the first available slot.
    - Example: `park B-1234-XYZ Putih Mobil`

- **`leave <slot number>`**: Free up a parking slot when a vehicle leaves.
    - Example: `leave 4`

- **`status`**: View the current status of all parking slots.
    - Example:
      ```bash
      Slot No. | Type  | Registration No. | Colour
      1        | Mobil | B-1234-XYZ       | Putih
      2        | Motor | B-9999-XYZ       | Putih
      ```

- **`type_of_vehicles <vehicle type>`**: Get the count of vehicles based on their type (Mobil/Motor).
    - Example: `type_of_vehicles Motor`

- **`registration_numbers_for_vehicles_with_colour <color>`**: Get the registration numbers of vehicles with the specified color.
    - Example: `registration_numbers_for_vehicles_with_colour Putih`

- **`slot_numbers_for_vehicles_with_colour <color>`**: Get the slot numbers for vehicles with the specified color.
    - Example: `slot_numbers_for_vehicles_with_colour Putih`

- **`slot_number_for_registration_number <registration number>`**: Get the slot number for a specific vehicle's registration number.
    - Example: `slot_number_for_registration_number B-3141-ZZZ`

- **`exit`**: Exit the program.

### Example Usage

```bash
$ create_parking_lot 6
Created a parking lot with 6 slots

$ park B-1234-XYZ Putih Mobil
Allocated slot number: 1

$ park B-9999-XYZ Putih Motor
Allocated slot number: 2

$ park D-0001-HIJ Hitam Mobil
Allocated slot number: 3

$ leave 2
Slot number 2 is free

$ status
Slot No. | Type  | Registration No. | Colour
1        | Mobil | B-1234-XYZ       | Putih
3        | Mobil | D-0001-HIJ       | Hitam
```

## Tests
Unit tests for the parking lot and parking service are implemented in the ParkingSystem.Tests folder.

To run the tests, use the following command:

```bash
dotnet test
```

## Contributing
If you want to contribute to this project, feel free to fork the repository and submit pull requests. Please ensure that you write unit tests for any new features or bug fixes.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

### Perbaikan:
- Menghapus duplikasi bagian `Parking System` yang ada dua kali.
- Memastikan bahwa seluruh instruksi dan penggunaan konsisten tanpa pengulangan.

Sekarang, `README.md` Anda siap digunakan tanpa masalah duplikasi.