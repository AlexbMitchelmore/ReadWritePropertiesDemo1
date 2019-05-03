using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Alex Mitchelmore
// Date: 2019-04-25
// Demo: BallonDemo

namespace FormFrontEnd
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
        }

        private Ballon myFirstBallon;

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                myFirstBallon = new Ballon()
                {
                    BallonName = "Happy the Ballon",
                    Colour = txtColor.Text.Trim(),
                    Height = Convert.ToDecimal(txtHeight.Text),
                    Diameter = Convert.ToDecimal(txtDiameter.Text)
                };

                //myFirstBallon.Colour = txtColor.Text.Trim();
                //myFirstBallon.Height = Convert.ToDecimal(txtHeight.Text);
                //myFirstBallon.Diameter = Convert.ToDecimal(txtDiameter.Text);
            }

            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch(DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }       
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                lblOutput.Text = $"{myFirstBallon.BallonName} specs: \n Colour: {myFirstBallon.Colour} \n Height: {myFirstBallon.Height} \n Diameter: {myFirstBallon.Diameter}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
