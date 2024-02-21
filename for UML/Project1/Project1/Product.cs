using System;
using System.Collections.Generic;
using System.Runtime;
namespace project1
{

    public class Product
    {
        private List<Part> parts = new List<Part>();

        public void AddPart(Part part)
        {
            parts.Add(part);
        }

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public void ToString()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            Console.WriteLine("\nComputer contains: ");
            foreach (var part in parts)
            {
                Console.WriteLine(part.Type);
            }
        }
    }
}