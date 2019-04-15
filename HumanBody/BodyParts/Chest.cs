using HumanBody.Organs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBody.BodyParts
{
    public class Chest : BodyPart
    {
        static int[] listOfArteryIndexies = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 23, 24, 25, 26, 27, 28, 29, 30, 34, 38, 39, 40, 42, 57 };

        public Chest()
        {
            Arteryes = Artery.GetArteries(listOfArteryIndexies);
        }
    }
}
