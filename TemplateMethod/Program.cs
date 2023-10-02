namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CookingTemplate pasta = new PastaCooking();
            CookingTemplate steak = new SteakCooking();

            pasta.Cook();
            steak.Cook();
        }
    }
}