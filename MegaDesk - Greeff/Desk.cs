using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk___Greeff
{
    internal class Desk
    {
        //Attributes
        public double _width;
        public double _depth;
        public int _drawerCount;
        public string _material;

        // Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        // Constructors
        public Desk(double width, double depth, int drawerCount, string material) {
        _width = width;
        _depth = depth;
        _drawerCount = drawerCount;
        _material = material;
        
        }

        // Methods
        public double CalcMaterialCost()
        {

            double materialCost = 0;

            if (_material == "Oak") {
                materialCost = Convert.ToDouble(DesktopMaterial.Oak);
            }

            else if (_material == "Vaneer")
            {
                materialCost = Convert.ToDouble(DesktopMaterial.Vaneer);
            }

            else if (_material == "Rosewood")
            {
                materialCost = Convert.ToDouble(DesktopMaterial.Rosewood);
            }

            else if (_material == "Laminate")
            {
                materialCost = Convert.ToDouble(DesktopMaterial.Laminate);
            }

            else if (_material == "Pine")
            {
                materialCost = Convert.ToDouble(DesktopMaterial.Pine);
            }


            double total = (_width * _depth) + (_drawerCount * 50) + materialCost;

            return total;
        }

        public double CalculateDeskArea()
        {
            double area = 0;
            area = _width * _depth;
            return area;
        }
    }

    public enum DesktopMaterial : int
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Vaneer = 125,

    }

    //List<DesktopMaterial> materialList = new List<DesktopMaterial>();
    //materialList.All(DesktopMaterial.Oak);


    





}
