using HumanBody.Organs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBody.BodyParts
{
    public class Pelvis : BodyPart
    {
        static int[] listOfArteryIndexies = { 0, 34, 49, 50, 61, 62, 63, 64, 65, 66, 67, 75, 82, 83, 84, 89, 90, 91, 92, 98, 99 };


        public Pelvis()
        {
            Arteryes = Artery.GetArteries(listOfArteryIndexies);
        }
    }
}
