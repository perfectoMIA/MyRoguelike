using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    public class Sword : Item
    {
        public int damage { get; set; }
        public char symbol = '|';
        public Sword( int price, int damage) : base(price)
        {
            this.damage = damage;
        }
        public override void Print ()
        {
            Console.WriteLine($"меч имеет урон = {damage} и стоимость = {price}");
        }
    }
}
