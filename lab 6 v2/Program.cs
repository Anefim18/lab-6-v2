class Program
{
    static void Main()
    {
        TransportNetwork transportNetwork = new TransportNetwork();

        // Додавання різних видів транспорту
        transportNetwork.AddVehicle(new Car());
        transportNetwork.AddVehicle(new Bus());
        transportNetwork.AddVehicle(new Train());

        // Рух усіх транспортних засобів
        transportNetwork.MoveAllVehicles();

        // Розрахунок оптимального маршруту для автомобіля
        transportNetwork.CalculateOptimalRoute(new Route("City A", "City B"), new Car());

        // Посадка та висадка пасажирів для автобуса
        transportNetwork.PassengerBoardingAndDisembarkation(new Bus());
    }
}