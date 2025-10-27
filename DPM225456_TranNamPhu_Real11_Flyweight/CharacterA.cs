using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Real11_Flyweight
{
    class CharacterA : Character
    {
        public CharacterA()
        {
            symbol = 'A';
            height = 100;
            width = 120;
            ascent = 70;
            descent = 0;
        }
        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(symbol +
                " (pointsize " + this.pointSize + ")");
        }
    }
}
