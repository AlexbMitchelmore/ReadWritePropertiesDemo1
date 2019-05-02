using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Alex Mitchelmore
// Date: 2019-04-25
// Demo: BallonDemo

namespace FormFrontEnd
{
    class Ballon
    {
        private string colour;
        private decimal height;
        private decimal diameter;

        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                if (value.ToUpper() == "RED" || value.ToUpper() == "BLUE")
                {
                    colour = value;
                }
                else
                {
                    throw new DataException("Colour must be red or blue");
                }
                
            }
        }

        public decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public decimal Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

    }


}
