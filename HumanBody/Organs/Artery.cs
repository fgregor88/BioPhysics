using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBody.Organs
{
    public class Artery : IOrgans
    {
        public int Idx { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Radius { get; set; }
        public double Length { get; set; }
        public double Surface { get; set; }


        Artery(int Idx, string Name, double Radius, double Length)
        {
            this.Idx = Idx;
            this.Name = Name;
            this.Type = "Artery";
            this.Radius = Radius;
            this.Length = Length;
            this.Surface = 2 * Math.PI * (Radius/100) * (Length/100);
        }

        private static double[] ArteryLengths = {0, 4.0, 2.0, 3.4, 8.9, 3.9, 3.4, 15.0, 6.8, 14.8, 8.9, 5.2, 8.9, 14.8, 6.8, 15.0, 5.0, 6.1, 10.0, 5.0, 3.1,
                                          5.2, 8.9, 5.0, 10.0, 6.1, 5.0, 3.0, 5.6, 5.0, 8.0, 5.9, 11.8, 4.0, 5.2, 4.0, 11.8, 5.9, 8.0, 5.0, 5.6,
                                          3.0, 6.3, 3.0, 5.9, 4.0, 3.0, 5.9, 3.0, 1.0, 5.3, 3.0, 5.9, 3.0, 4.0, 5.9, 3.0, 6.3, 15.0, 6.3, 5.9,
                                          7.1, 6.3, 6.6, 3.2, 5.3, 5.9, 3.2, 5.9, 6.3, 15.0, 6.3, 5.0, 4.0, 5.0, 5.3, 5.0, 4.0, 5.0, 6.3, 5.0,
                                          4.6, 5.8, 5.0, 5.8, 4.6, 5.0, 6.7, 11.7, 8.3, 5.0, 5.0, 8.3, 11.7, 6.7, 8.5, 7.9, 11.7, 6.1, 6.1, 11.7,
                                          7.9, 8.5, 8.5, 12.7, 12.6, 12.6, 12.7, 8.5, 12.7, 12.7, 9.4, 9.4, 9.4, 9.4, 2.5, 16.1, 16.1, 2.5, 15.0, 15.9,
                                          16.1, 16.1, 15.9, 15.0, 15.0, 15.9, 15.9, 15.0}; //Length of an artery[cm]

        private static double[] ArteryRadia = {0, 1.45, 1.12, 0.42, 0.37, 1.07, 0.62, 0.1, 0.4, 0.19, 0.37, 1.0, 0.37, 0.19, 0.4, 0.1, 0.1, 0.36, 0.2, 0.1, 0.37,
                                        0.95, 0.37, 0.1, 0.2, 0.36, 0.1, 0.15, 0.31, 0.1, 0.15, 0.18, 0.15, 0.07, 0.95, 0.07, 0.15, 0.18, 0.15, 0.1, 0.31,
                                        0.15, 0.28, 0.1, 0.13, 0.1, 0.06, 0.08, 0.07, 0.39, 0.87, 0.07, 0.08, 0.06, 0.1, 0.13, 0.1, 0.28, 0.15, 0.26, 0.08,
                                        0.18, 0.28, 0.22, 0.26, 0.57, 0.43, 0.26, 0.08, 0.26, 0.15, 0.25, 0.07, 0.06, 0.07, 0.57, 5.0, 0.06, 0.07, 0.25, 0.06,
                                        0.24, 0.52, 0.16, 0.52, 0.24, 0.06, 0.21, 0.16, 0.29, 0.20, 0.20, 0.29, 0.16, 0.21, 0.19, 0.09, 0.16, 0.27, 0.27, 0.16,
                                        0.09, 0.19, 0.19, 0.24, 0.23, 0.23, 0.24, 0.19, 0.24, 0.24, 0.2, 0.2, 0.2, 0.2, 0.13, 0.18, 0.18, 0.13, 0.1, 0.13,
                                        0.18, 0.18, 0.13, 0.1, 0.1, 0.13, 0.13, 0.1}; //Radius of an artery[cm] (Avolio 1980)

        public static List<Artery> GetArteries(int[] IdxArteryArray)
        {
            List<Artery> ArteryList = new List<Artery> { };

            foreach(int idx in IdxArteryArray)
            {
                ArteryList.Add(new Artery(idx, "", ArteryRadia[idx], ArteryLengths[idx]));
            }


            return ArteryList;
        }



    }
}
