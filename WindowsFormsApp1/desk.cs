using System;

namespace WindowsFormsApp1
{
    public enum DeskMaterial
    {
        laminate,
        oak,
        pine,
        rosewood,
        veneer
    }

    class desk
    {
        private double width;
        private double depth;
        private int numDrawers;
        private int material;
        public static int deskCtr;
        
        public const double MIN_WIDTH = 24;
        public const double MAX_WIDTH = 96;
        public const double MIN_DEPTH = 12;
        public const double MAX_DEPTH = 48;

        public desk()
        {
            deskCtr++;
            Console.Write("Creating Desk Object #" + deskCtr);
        }

        public void setWidth(double width)
        {
            this.width = width;
        }

        public double getWidth()
        {
            return this.width;
        }

        public void setDepth(double depth)
        {
            this.depth = depth;
        }

        public double getDepth()
        {
            return this.depth;
        }

        public void setDrawers(int drawers)
        {
            this.numDrawers = drawers;
        }

        public int getDrawers()
        {
            return this.numDrawers;
        }

        public void setMaterial(int material)
        {
            this.material = material;
        }

        public int getMaterial()
        {
            return this.material;
        }

    }
}
