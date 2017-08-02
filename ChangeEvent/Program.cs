namespace ChangeEvent
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            product.PropertyChange += (sender, data) => 
            {
                if (data.PropertyName == "Name")
                {
                    Console.WriteLine($"New value: {data.NewValue}, Old value: {data.OldValue}");
                }
            };
            product.Name = "Product 1";
            product.Name = "Product 2";
            product.Name = "Product 3";
            Console.ReadLine();
        }
    }
}
