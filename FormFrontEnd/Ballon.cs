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
        //private decimal height; This is now an autoproperty
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

        public string BallonName { get; set; }

        public decimal Height
        {
            get;
            set;
        }

        public decimal Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                if (Colour == string.Empty || Colour == null)
                {
                    throw new DataException("You must set the colour first.");
                }
                else if (Colour.ToUpper() == "RED" && value > 12)
                {
                    throw new ConstraintException("Ballon cannot be red and greater then 12 in diameter.");
                }
                else if (Colour.ToUpper() == "BLUE" && value < 5)
                {
                    throw new ConstraintException("Ballons cannot be blue and have less then 5 in diameter.");
                }
                else
                {
                    diameter = value;
                }
             
            }
        }

    }


}
