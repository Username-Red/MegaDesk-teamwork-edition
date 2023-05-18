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
        public int CalculateRushOrderCost()
        {
            int rushCost = 0;

            double area = _desk.CalculateDeskArea();
            if (_rushDays == 3)
            {
                if (area <= 1000)
                {
                    rushCost = 30;
                }

                else if (area > 1000 && area < 2000)
                {
                    rushCost = 35;
                }

                else if (area > 2000) 
                {
                    rushCost = 40;
                }
                
            }

            else if (_rushDays == 5)
            {
                if (area <= 1000)
                {
                    rushCost = 40;
                }

                else if (area > 1000 && area < 2000)
                {
                    rushCost = 50;
                }

                else if (area > 2000)
                {
                    rushCost = 60;
                }
            }

            else if (_rushDays == 7)
            {
                if (area <= 1000)
                {
                    rushCost = 60;
                }

                else if (area > 1000 && area < 2000)
                {
                    rushCost = 70;
                }

                else if (area > 2000)
                {
                    rushCost = 80;
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
