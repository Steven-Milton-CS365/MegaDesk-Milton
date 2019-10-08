using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    class DeskQuote
    {
        private int quoteNo;
        private String fullName;
        private double basePrice;
        private double addlArea;
        private double drawersCost;
        private int rush;
        private double materialCost;
        private double deskCost;
        private DateTime quoteDate;
        public desk inDesk;

        const double DRAWER_COST = 50;
        const double BASE_DESK = 200;
        const double AREA_COST = 1;


        public DeskQuote()
        {
            this.quoteNo = GetNextQuoteNo();
            this.basePrice = BASE_DESK;
            this.quoteDate = DateTime.Now;
        }

        public DeskQuote(desk desk1, String fullName, int rush)
        {
            this.quoteNo = GetNextQuoteNo();
            this.basePrice = BASE_DESK;
            this.quoteDate = DateTime.Now;
            this.inDesk = desk1;
            this.fullName = fullName;
            this.rush = rush;
            this.deskCost = TotalCost(desk1, rush);
        }

        public void setQuoteNo(int quoteNo)
        {
            this.quoteNo = quoteNo;
        }

        public int getQuoteNo()
        {
            return this.quoteNo;
        }

        public void setName(String fullName)
        {
            this.fullName = fullName;
        }

        public String getName()
        {
            return this.fullName;
        }

        public int getRush()
        {
            return this.rush;
        }

        public void setRush(int rush)
        {
            this.rush = rush;
        }

        public DateTime getDate()
        {
            return this.quoteDate;
        }

        public double TotalCost(desk desk, int rush)
        {
            return BASE_DESK + DrawerCost(desk.getDrawers()) + AreaCost(desk.getWidth(), desk.getDepth())
                       + SurfaceCost(desk.getMaterial()) + RushRate(rush, desk.getWidth(), desk.getDepth());
        }

        private double DrawerCost(int drawers)
        {
            return drawers * DRAWER_COST;
        }

        private double AreaCost(double width, double depth)
        {
            if ((width * depth) < 1000)
                return 0;
            else
                return (width * depth - 1000) * AREA_COST;
        }

        private double SurfaceCost(int material)
        {
            switch (material)
            {
                case 0:
                    return 100;
                    break;
                case 1:
                    return 200;
                    break;
                case 2:
                    return 50;
                    break;
                case 3:
                    return 300;
                    break;
                case 4:
                    return 125;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        private double RushRate(int days, double width, double depth)
        {
            if (days == 0)
            {
                return 0;
            }
            else
            {
                days--;
                int[,] rushRates = new int[3, 3]
                {
                    {60, 70, 80},
                    {40, 50, 60},
                    {30, 35, 40}
                };
                double addlArea = depth * width - 1000;
                if (addlArea < 0)
                    addlArea = 0;
                int areaBreak = (int)addlArea / 1000;
                if (areaBreak > 2)
                    areaBreak = 2;
                return rushRates[days, areaBreak];
            }
        }

        private int GetNextQuoteNo()
        {
            String curFile = "quotes.txt";
            if (File.Exists(curFile))
            {
                StreamReader quoteFile = new StreamReader("quotes.txt");
                int quoteNo = 0;
                while (quoteFile.EndOfStream == false)
                {
                    string line = quoteFile.ReadLine();
                    quoteNo = Int32.Parse(line.Substring(0, line.IndexOf('|')));
                }

                quoteFile.Close();
                return ++quoteNo;
            }
            else
                return 1;
        }
    }
}

