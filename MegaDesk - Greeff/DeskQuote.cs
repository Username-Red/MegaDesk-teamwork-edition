using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk___Greeff
{
    internal class DeskQuote
    {
        //Attributes
        public Desk _desk;
        public int _rushDays;
        public string _customerName;
        public DateTime _quoteDate;

        // Constructors
        public DeskQuote(Desk desk, int rushDays, string customerName, DateTime quoteDate) {
            _desk = desk;
            _rushDays = rushDays;
            _customerName = customerName;
            _quoteDate = quoteDate;
        }

        // Methods
        public int CalculateRushOrderCost() {
            string contents = Properties.Resources.cse325_document_rushOrderPrices;
            string[] priceStrings = contents.Split('\n');
            int[][] prices = new int[3][];

            for (int group = 0; group < 3; group++) {
                int[] priceGroup = { 0, 0, 0 };
                prices[group] = priceGroup;

                for (int i = 0; i < 3; i++) {
                    int priceStringsIndex = group * 3 + i;
                    prices[group][i] = Convert.ToInt32(priceStrings[priceStringsIndex]);
                }
            }
            int rushCost = 0;

            double area = _desk.CalculateDeskArea();
            if (_rushDays == 3)
            {
                if (area <= 1000)
                {
                    rushCost = prices[2][0];
                }

                else if (area > 1000 && area < 2000)
                {
                    rushCost = prices[2][1];
                }

                else if (area > 2000) 
                {
                    rushCost = prices[2][2];
                }
                
            }

            else if (_rushDays == 5)
            {
                if (area <= 1000)
                {
                    rushCost = prices[1][0];
                }

                else if (area > 1000 && area < 2000)
                {
                    rushCost = prices[1][1];
                }

                else if (area > 2000)
                {
                    rushCost = prices[1][2];
                }
            }

            else if (_rushDays == 7)
            {
                if (area <= 1000)
                {
                    rushCost = prices[0][0];
                }

                else if (area > 1000 && area < 2000)
                {
                    rushCost = prices[0][1];
                }

                else if (area > 2000)
                {
                    rushCost = prices[0][2];
                }
            }

            else
            {
                rushCost = 0;
            }
            return rushCost;
        }

        public double CalculateTotal()
        {
            double total = 0;
            double area = _desk.CalculateDeskArea();
            double materialCost = _desk.CalcMaterialCost();
            int rushCost = CalculateRushOrderCost();
            total = area + materialCost + _desk._drawerCount * 50 + rushCost + 200;

            return total;
        }

        
    }
}
