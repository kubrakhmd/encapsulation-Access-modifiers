namespace Access_modifiers_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Apple", "iPhone13", 999m, 800m, 10);
            product.GetInfo();
            product.Sale(6);
            product.GetInfo();
            Phone phone = new Phone("Samsung", "GalaxyS21", 1500m, 600m, 8);
            phone.GetInfo();
            phone.Pay(50m);
            phone.Call(20);
            Console.WriteLine($"Zengden sonra balans {phone.Balance}");
            Notebook notebook = new Notebook("Dell", "XPS13", 1200m, 900m, "Windows 10", "Intel i7");
            notebook.GetInfo();
        }
    }
}
