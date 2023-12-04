// Абстрактний клас "Транспортний засіб"
abstract class Vehicle
{
    public double Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}
// Спадкоємці від класу Vehicle
class Car : Vehicle
{
    public Car()
    {
        Speed = 60;  // швидкість в км/год
        Capacity = 4;  // кількість місць
    }

    public override void Move()
    {
        Console.WriteLine("Car is driving...");
    }
}

class Bus : Vehicle
{
    public Bus()
    {
        Speed = 40;
        Capacity = 30;
    }

    public override void Move()
    {
        Console.WriteLine("Bus is moving...");
    }
}

class Train : Vehicle
{
    public Train()
    {
        Speed = 80;
        Capacity = 200;
    }

    public override void Move()
    {
        Console.WriteLine("Train is traveling on rails...");
    }
}
