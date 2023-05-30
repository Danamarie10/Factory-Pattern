namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vehicle = VehicleFactory.GetTire(18);

            vehicle.Drive();
        }
    }
}
