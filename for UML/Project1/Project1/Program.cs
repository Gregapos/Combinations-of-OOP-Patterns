using System.Collections.Generic;

namespace project1
{

    class Program
    {
        static void Main()
        {
            ComputerBuilder builder = new ComputerBuilder();
            Director director = new Director(builder);
            director.Make("gaming");
            List<Product> p = new List<Product>();
            // p.Add(b.GetResult());

            // d.Make("standard");
            // p.Add(b.GetResult());

            // foreach (var item in p)
            // {
            //     item.ToString();
            // }
            builder.GetResult().ToString();
        }

    }
}

