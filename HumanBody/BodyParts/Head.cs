using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanBody.Organs;

namespace HumanBody.BodyParts
{
    public class Head : BodyPart
    {
        static int[] listOfArteryIndexies = { 0, 4, 10, 12, 20, 22, 31, 32, 33, 35, 36, 37, 43, 44, 45, 46, 47, 48, 51, 52, 53, 54, 55, 60, 68, 73, 74, 76, 77 };


        public Head()
        {
            Arteryes = Artery.GetArteries(listOfArteryIndexies);
        }

    
    }

}