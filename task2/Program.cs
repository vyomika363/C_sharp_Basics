using System;

class Vehicle
{
    protected int speed;
    protected int fuel;

    public Vehicle(int speed, int fuel)
    {
        this.speed = speed;
        this.fuel = fuel;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}");
    }

    public virtual void Drive()
    {
        fuel -= 5;
        Console.WriteLine("Vehicle is moving...");
    }

}

class Car : Vehicle // class Car derived from class Vehicle
{
    private int passengers; // protection type wasn't specified

    public Car(int speed, int fuel, int passengers)
        : base(speed, fuel)
    {
        this.passengers = passengers;
    }

    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine($"Car is moving with passenger");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Passengers: {passengers}");
    }
}

class Truck : Vehicle
{
    private int cargoWeight;

    public Truck(int speed, int fuel, int cargoWeight)
        : base(speed, fuel)
    {
        this.cargoWeight = cargoWeight;
    }

    public override void Drive()
    {
        fuel -= 15;
        Console.WriteLine($"Truck is moving with cargo");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Cargo Weight: {cargoWeight}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Vehicle details:\nSpeed - 50\nFuel - 100\n");
        Console.WriteLine($"Car details:\nSpeed - 90\nFuel - 50\nPassengers - 4\n");
        Console.WriteLine($"Truck details:\nSpeed - 40\nFuel - 200\nCargo - 5000\n");
        Vehicle v = new Vehicle(50, 100);
        Vehicle c = new Car(90, 50, 4);
        Vehicle t = new Truck(40, 200, 5000);

        Vehicle[] vehicles = { v, c, t };

        foreach (Vehicle vehicle in vehicles) // C# looping
        {
            vehicle.Drive();
            vehicle.ShowInfo();
            Console.WriteLine();
        }
    }
}
