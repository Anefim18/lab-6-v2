// Клас "Транспортна мережа"
class TransportNetwork
{
    private List<Vehicle> vehicles;

    public TransportNetwork()
    {
        vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void MoveAllVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }

    public void CalculateOptimalRoute(Route route, Vehicle vehicle)
    {
        // Додаткова логіка для розрахунку оптимального маршруту залежно від виду транспорту
        Console.WriteLine($"Calculating optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}...");
    }

    public void PassengerBoardingAndDisembarkation(Vehicle vehicle)
    {
        // Додаткова логіка для посадки та висадки пасажирів на кожному етапі руху транспорту
        Console.WriteLine($"Passengers boarding and disembarkation for {vehicle.GetType().Name}...");
    }
}
