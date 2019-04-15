using HumanBody.Organs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBody.BodyParts
{
    public abstract class BodyPart
    {
        public List<Artery> Arteryes { get; set; }

        public double GetTotalSurfaceOfArteries()
        {
            double TotalArterySurface = 0;
            foreach (Artery Artery in Arteryes)
            {
                TotalArterySurface += Artery.Surface;
            }

            return TotalArterySurface;
        }
    }
}
