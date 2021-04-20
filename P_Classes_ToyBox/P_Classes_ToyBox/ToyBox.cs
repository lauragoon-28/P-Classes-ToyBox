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

        public string GetRandomToy() 
        {
            Random rand = new Random();
            int newToy = 0;
            for (int i = 0; i < Toys.Count; i++)
            {
                newToy = rand.Next(0, Toys.Count);
            }
            
            return;


        }








    }
}
