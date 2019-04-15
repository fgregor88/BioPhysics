using HumanBody.Organs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBody.BodyParts
{
    public class RightUpperArm : BodyPart
    {
        static int[] listOfArteryIndexies = { 0, 42, 57, 58, 59, 71, 72, 80, 82, 85 };

        public RightUpperArm()
        {
            Arteryes = Artery.GetArteries(listOfArteryIndexies);
        }
    }
}
