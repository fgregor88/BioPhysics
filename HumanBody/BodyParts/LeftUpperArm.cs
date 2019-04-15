using HumanBody.Organs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBody.BodyParts
{
    public class LeftUpperArm : BodyPart
    {
        static int[] listOfArteryIndexies = { 0, 42, 57, 69, 70, 78, 79, 81, 85, 86 };

        public LeftUpperArm()
        {
            Arteryes = Artery.GetArteries(listOfArteryIndexies);
        }

    }
}
