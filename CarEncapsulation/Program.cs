using Encapsulation;

public class Program
{
    public static void Main()
    {
        Car car1 = new Car("Hyundai", "I20", "Siyah", 4);
        car1.CarInformation();

        Car car2 = new Car("Citroen", "C3", "Beyaz", 3);
        car2.CarInformation();
    }
}