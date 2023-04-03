using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Roguelike
{
    public class Armor : Item
    {
        public int armor { get; set; }
        public char symbol = 'A';
        public Armor(int price, int armor) : base(price)
        {
            this.armor = armor;
        }
        public override void Print()
        {
            Console.WriteLine($"броня имеет защиту = {armor} и стоимость = {price}");
        }

    }
}
