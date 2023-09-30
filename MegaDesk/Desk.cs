using System;

namespace MegaDesk
{
    public class Desk
    {
        // Constant Fields
        public const int MINWIDTH = 24, MAXWIDTH = 96;
        public const int MINDEPTH = 12, MAXDEPTH = 48;
        public const int MINDRAWERCOUNT = 0, MAXDRAWERCOUNT = 7;

        // Properties
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public SurfaceMaterials SurfaceMaterial { get; set; }
        public decimal SurfaceArea { get => Width * Depth; }

        // Constructor
        public Desk(decimal width, decimal depth, int numberOfDrawers, string surfaceMaterial)
        {
            Width = width;
            Depth = depth;
            NumberOfDrawers = numberOfDrawers;
            if (Enum.TryParse(surfaceMaterial, true, out SurfaceMaterials result))
            {
                SurfaceMaterial = result;
            }
            else
            {
                Console.WriteLine("Invalid Material Input");
            }
        }
    }

    public enum SurfaceMaterials
    {
        LAMINATE = 100,
        OAK = 200,
        PINE = 50,
        ROSEWOOD = 300,
        VENEER = 125
    }
}
