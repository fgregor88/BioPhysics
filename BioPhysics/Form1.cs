using HumanBody.BodyParts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioPhysics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Head head = new Head();
            Chest chest = new Chest();
            Pelvis pelvis = new Pelvis();

            LeftUpperArm leftupperarm = new LeftUpperArm();

            Console.WriteLine($"Head: {head.GetTotalSurfaceOfArteries()}");
            Console.WriteLine($"Chest: {chest.GetTotalSurfaceOfArteries()}");
            Console.WriteLine($"Pelvis: {pelvis.GetTotalSurfaceOfArteries()}");
            Console.WriteLine($"LefUpperArm: {leftupperarm.GetTotalSurfaceOfArteries()}");
        }
    }
}
