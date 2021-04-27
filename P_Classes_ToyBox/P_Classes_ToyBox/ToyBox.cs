using System;
using System.Collections.Generic;
using System.Text;

namespace P_Classes_ToyBox
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public string Owner { get; set; }

        public string Location { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = "";
            Location = "";
        }

        public Toy GetRandomToy() 
        {
            Random rand = new Random();
            int newToyIndex = rand.Next(0, Toys.Count - 1);

            //Toy rToy = Toys[ran.Next(0, Toys.Count)];
            
            return Toys[newToyIndex];
        }

    }
}
