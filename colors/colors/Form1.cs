namespace colors
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

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

        
        private Color firstLowestColor = Color.FromArgb(highestValue, lowestValue, lowestValue, highestValue);
        private Color firstHighestColor = Color.FromArgb(highestValue, lowestValue, highestValue, highestValue);

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
        /// The default temp.
        /// </summary>
        private const int DefaultTemp = 70;


        /// <summary>
        /// The calculate colors RGB values and the colors number.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private int CalculateColor(int temperature, out Color newTemperatureColor)
        {
            if (temperature >= firstRangeLow && temperature < firstRangeHigh)
            {
                int highRed = this.firstHighestColor.R;
                int highGreen = this.firstHighestColor.G;
                int highBlue = this.firstHighestColor.B;

                int lowRed = this.firstLowestColor.R;
                int lowGreen = this.firstLowestColor.G;
                int lowBlue = this.firstLowestColor.B;

                // red
                var z = (double)((temperature - firstRangeLow) / (firstRangeHigh - firstRangeLow));
                var tempRed = (int)Math.Floor(highRed * z + lowRed * (1 - z));

                // green
                z = (double)(temperature - firstRangeLow) / (firstRangeHigh - firstRangeLow);
                var tempGreen = (int)Math.Floor(highGreen * z + lowGreen * (1 - z));

                // blue
                z = (double)(temperature - firstRangeLow) / (firstRangeHigh - firstRangeLow);
                var tempBlue = (int)Math.Floor(highBlue * z + lowBlue * (1 - z));

                newTemperatureColor = Color.FromArgb(tempRed, tempGreen, tempBlue);

               
                var colorNumber = -65536 * tempRed + 256 * tempGreen + tempBlue;
                return colorNumber;
            }

            if (temperature >= secondRangeLow && temperature < secondRangeHigh)
            {
                int highRed = this.secondHighestColor.R;
                int highGreen = this.secondHighestColor.G;
                int highBlue = this.secondHighestColor.B;

                int lowRed = this.secondLowestColor.R;
                int lowGreen = this.secondLowestColor.G;
                int lowBlue = this.secondLowestColor.B;

                // red
                var z = (double)((temperature - secondRangeLow) / (secondRangeHigh - secondRangeLow));
                var tempRed = (int)Math.Floor(highRed * z + lowRed * (1 - z));

                // green
                z = (double)(temperature - secondRangeLow) / (secondRangeHigh - secondRangeLow);
                var tempGreen = (int)Math.Floor(highGreen * z + lowGreen * (1 - z));

                // blue
                z = (double)(temperature - secondRangeLow) / (secondRangeHigh - secondRangeLow);
                var tempBlue = (int)Math.Floor(highBlue * z + lowBlue * (1 - z));

                newTemperatureColor = Color.FromArgb(tempRed, tempGreen, tempBlue);

                
                var colorNumber = -65536 * tempRed + 256 * tempGreen + tempBlue;
                return colorNumber;
            }

            if (temperature >= thirdRangeLow && temperature < thirdRangeHigh)
            {
                int highRed = this.thirdHighestColor.R;
                int highGreen = this.thirdHighestColor.G;
                int highBlue = this.thirdHighestColor.B;

                int lowRed = this.thirdLowestColor.R;
                int lowGreen = this.thirdLowestColor.G;
                int lowBlue = this.thirdLowestColor.B;

                // red
                var z = (double)(temperature - thirdRangeLow) / (thirdRangeHigh - thirdRangeLow);
                var tempRed = (int)Math.Floor(highRed * z + lowRed * (1 - z));

                // green
                z = (double)(temperature - thirdRangeLow) / (thirdRangeHigh - thirdRangeLow);
                var tempGreen = (int)Math.Floor(highGreen * z + lowGreen * (1 - z));

                // blue
                z = (double)(temperature - thirdRangeLow) / (thirdRangeHigh - thirdRangeLow);
                var tempBlue = (int)Math.Floor(highBlue * z + lowBlue * (1 - z));

                newTemperatureColor = Color.FromArgb(tempRed, tempGreen, tempBlue);

               
                var colorNumber = -65536 * tempRed + 256 * tempGreen + tempBlue;
                return colorNumber;
            }

            if (temperature >= fourthRangeLow && temperature <= fourthRangeHigh)
            {
                int highRed = this.fourthHighestColor.R;
                int highGreen = this.fourthHighestColor.G;
                int highBlue = this.fourthHighestColor.B;

                int lowRed = this.fourthLowestColor.R;
                int lowGreen = this.fourthLowestColor.G;
                int lowBlue = this.fourthLowestColor.B;

                // red
                var z = (double)(temperature - fourthRangeLow) / (fourthRangeHigh - fourthRangeLow);
                var tempRed = (int)Math.Floor(highRed * z + lowRed * (1 - z));

                // green
                z = (double)(temperature - fourthRangeLow) / (fourthRangeHigh - fourthRangeLow);
                var tempGreen = (int)Math.Floor(highGreen * z + lowGreen * (1 - z));

                // blue
                z = (double)(temperature - fourthRangeLow) / (fourthRangeHigh - fourthRangeLow);
                var tempBlue = (int)Math.Floor(highBlue * z + lowBlue * (1 - z));

                newTemperatureColor = Color.FromArgb(tempRed, tempGreen, tempBlue);

                
                var colorNumber = -65536 * tempRed + 256 * tempGreen + tempBlue;
                return colorNumber;
            }

            // else, temperature is out of range doNothing();
            newTemperatureColor = Color.White;
            return 1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="colorsForm"/> class.
        /// </summary>
        public colorsForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The temperature numeric up down_ value changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TemperatureNumericUpDownValueChanged(object sender, EventArgs e)
        {
            int.TryParse(this.tempatureNumericUpDown.Text, out var temperature);
            if (temperature >= 0 && temperature <= 100)
            {
                var newFormColorNumber = this.CalculateColor(temperature, out var newFormColor);
                this.colorNumberTextBox.Text = newFormColorNumber.ToString();
                this.BackColor = newFormColor;
                this.hexValueRichTextBox.Text = $"#{newFormColor.R:X2}{newFormColor.G:X2}{newFormColor.B:X2} {Environment.NewLine}{newFormColor}";
            }
            else
            {
                this.tempatureNumericUpDown.Text = DefaultTemp.ToString();
            }
        }
    }
}
