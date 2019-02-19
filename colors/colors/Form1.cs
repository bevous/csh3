using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colors
{
    using System.Diagnostics.CodeAnalysis;
    

    /// <summary>
    /// The colors form.
    /// </summary>
    public partial class colorsForm : Form
    {
        #region colorConstants

        private const int highestValue = 255;

        private const int lowestValue = 0;

        #endregion

        #region tempRange1

        // first temp range
        private const int firstRangeLow = 0;

        private const int firstRangeHigh = 25;  // (0, 0, 255) and (0, 255, 255)

        
        private Color firstLowestColor = Color.FromArgb(highestValue, lowestValue, lowestValue, highestValue);;
        private Color firstHighestColor = Color.FromArgb(highestValue, lowestValue, highestValue, highestValue);;

        #endregion

        #region tempRange2

        // second temp range
        private const int secondRangeLow = 25;

        private const int secondRangeHigh = 50; // (0, 255, 255) and (0, 255, 0)

        private Color secondLowestColor = Color.FromArgb(highestValue, lowestValue, highestValue, highestValue);
        private Color secondHighestColor = Color.FromArgb(highestValue, lowestValue, highestValue, lowestValue);

        #endregion

        #region tempRange3

        // third temp range
        private const int thirdRangeLow = 50;

        private const int thirdRangeHigh = 75; // (0, 255, 0) and (255, 255, 0)

        private Color thirdLowestColor = Color.FromArgb(highestValue, lowestValue, highestValue, lowestValue);
        private Color thirdHighestColor = Color.FromArgb(highestValue, highestValue, highestValue, lowestValue);

        #endregion

        #region tempRange4

        // fourth temp range
        private const int fourthRangeLow = 75;

        private const int fourthRangeHigh = 100; // (255, 255, 0) and (255, 0, 0)

        private Color fourthLowestColor = Color.FromArgb(highestValue, highestValue, highestValue, lowestValue);
        private Color fourthHighestColor = Color.FromArgb(highestValue, highestValue, lowestValue, lowestValue);


        #endregion

        

        /// <summary>
        /// The calculate color.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private int CalculateColor(int tempature,out Color newTempatureColor)
        {
            
            var tempColor =new Color();
            if (tempature >= firstRangeLow && tempature < firstRangeHigh)
            {
                int highRed = this.firstHighestColor.R;
                int highGreen = this.firstHighestColor.G;
                int highBlue = this.firstHighestColor.B;

                int lowRed = this.firstLowestColor.R;
                int lowGreen = this.firstLowestColor.G;
                int lowBlue = this.firstLowestColor.B;

                //red
                var z = ((tempature - firstRangeLow) / (firstRangeHigh - firstRangeLow));
                var tempRed = lowRed * z + highRed * (1 - z);
                //green
                z = ((tempature - firstRangeLow) / (firstRangeHigh - firstRangeLow));
                var tempGreen = lowGreen * z + highGreen * (1 - z);
                //blue
                z = ((tempature - firstRangeLow) / (firstRangeHigh - firstRangeLow));
                var tempBlue = lowBlue * z + highBlue * (1 - z);
            }
            else if (tempature >= secondRangeLow && tempature < secondRangeHigh)
            {
            }
            else if (tempature >= thirdRangeLow && tempature < thirdRangeHigh)
            {
            }
            else if (tempature >= fourthRangeLow && tempature < fourthRangeHigh)
            {
            }

            // else, tempature is out of range doNothing();
            return 1;
        }

        /// <summary>
        /// The default temp.
        /// </summary>
        private const int DefaultTemp = 70;

        /// <summary>
        /// Initializes a new instance of the <see cref="colorsForm"/> class.
        /// </summary>
        public colorsForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The tempature numeric up down_ value changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TempatureNumericUpDownValueChanged(object sender, EventArgs e)
        {
            int.TryParse(this.tempatureNumericUpDown.Text, out var temperature);
            if (temperature >= 0 && temperature < 25)
            {

            }
            else if (temperature >= 25 && temperature < 50)
            {

            }
            else if (temperature >= 50 && temperature < 75)
            {

            }
            else
            {
                if (temperature < 0 || temperature > 100)
                {
                    this.tempatureNumericUpDown.Text = DefaultTemp.ToString();
                }
 // else no action needed DoNothing();
            }
            
        }
    }
}
