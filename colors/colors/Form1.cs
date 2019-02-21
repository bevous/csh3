// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="">
//   
// </copyright>
// <summary>
//   The colors form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace colors
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    ///     The colors form.
    /// </summary>
    public partial class ColorsForm : Form
    {
        /// <summary>
        ///     The default temp.
        /// </summary>
        private const int DefaultTemp = 70;

        /// <summary>
        /// The first range high.
        /// </summary>
        private const int FirstRangeHigh = 25; // (0, 0, 255) and (0, 255, 255)

        /// <summary>
        /// The first range low.
        /// </summary>
        private const int FirstRangeLow = 0;

        /// <summary>
        ///     The first constant value in the formula for color number.
        /// </summary>
        private const int FormulaNumberOne = -65536;

        /// <summary>
        ///     The first constant value in the formula for color number.
        /// </summary>
        private const int FormulaNumberTwo = 256;

        /// <summary>
        /// The fourth range high.
        /// </summary>
        private const int FourthRangeHigh = 100; // (255, 255, 0) and (255, 0, 0)

        /// <summary>
        /// The fourth range low.
        /// </summary>
        private const int FourthRangeLow = 75;

        /// <summary>
        /// The highest value.
        /// </summary>
        private const int HighestValue = 255;

        /// <summary>
        /// The lowest value.
        /// </summary>
        private const int LowestValue = 0;

        /// <summary>
        ///     needed to calculate the new color values.
        /// </summary>
        private const int One = 1;

        /// <summary>
        ///     The second range high.
        /// </summary>
        private const int SecondRangeHigh = 50; // (0, 255, 255) and (0, 255, 0)

        /// <summary>
        ///     The second range low.
        /// </summary>
        private const int SecondRangeLow = 25;

        /// <summary>
        ///     The third range high.
        /// </summary>
        private const int ThirdRangeHigh = 75; // (0, 255, 0) and (255, 255, 0)

        /// <summary>
        ///     The third range low.
        /// </summary>
        private const int ThirdRangeLow = 50;

        /// <summary>
        ///     The first highest color.
        /// </summary>
        private readonly Color firstHighestColor = Color.FromArgb(
            HighestValue,
            LowestValue,
            HighestValue,
            HighestValue);

        /// <summary>
        ///     The first lowest color.
        /// </summary>
        private readonly Color firstLowestColor = Color.FromArgb(HighestValue, LowestValue, LowestValue, HighestValue);

        /// <summary>
        ///     The fourth highest color.
        /// </summary>
        private readonly Color fourthHighestColor = Color.FromArgb(
            HighestValue,
            HighestValue,
            LowestValue,
            LowestValue);

        /// <summary>
        ///     The fourth lowest color.
        /// </summary>
        private readonly Color fourthLowestColor = Color.FromArgb(
            HighestValue,
            HighestValue,
            HighestValue,
            LowestValue);

        /// <summary>
        ///     The second highest color.
        /// </summary>
        private readonly Color secondHighestColor = Color.FromArgb(
            HighestValue,
            LowestValue,
            HighestValue,
            LowestValue);

        /// <summary>
        ///     The second lowest color.
        /// </summary>
        private readonly Color secondLowestColor = Color.FromArgb(
            HighestValue,
            LowestValue,
            HighestValue,
            HighestValue);

        /// <summary>
        ///     The third highest color.
        /// </summary>
        private readonly Color thirdHighestColor = Color.FromArgb(
            HighestValue,
            HighestValue,
            HighestValue,
            LowestValue);

        /// <summary>
        ///     The third lowest color.
        /// </summary>
        private readonly Color thirdLowestColor = Color.FromArgb(HighestValue, LowestValue, HighestValue, LowestValue);

        /// <summary>
        ///     Initializes a new instance of the <see cref="ColorsForm" /> class.
        /// </summary>
        public ColorsForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The calculate colors RGB values and the colors number.
        /// </summary>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        /// <param name="newTemperatureColor">
        /// The new Temperature Color.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1407:ArithmeticExpressionsMustDeclarePrecedence", Justification = "Reviewed. Suppression is OK here.")]
        private int CalculateColor(int temperature, out Color newTemperatureColor)
        {
            if (temperature >= FirstRangeLow && temperature < FirstRangeHigh)
            {
                int highRed = this.firstHighestColor.R;
                int highGreen = this.firstHighestColor.G;
                int highBlue = this.firstHighestColor.B;

                int lowRed = this.firstLowestColor.R;
                int lowGreen = this.firstLowestColor.G;
                int lowBlue = this.firstLowestColor.B;

                // red
                var z = (double)(temperature - FirstRangeLow) / (FirstRangeHigh - FirstRangeLow);
                var tempRed = (int)Math.Floor(highRed * z + lowRed * (One - z));

                // green
                z = (double)(temperature - FirstRangeLow) / (FirstRangeHigh - FirstRangeLow);
                var tempGreen = (int)Math.Floor(highGreen * z + lowGreen * (One - z));

                // blue
                z = (double)(temperature - FirstRangeLow) / (FirstRangeHigh - FirstRangeLow);
                var tempBlue = (int)Math.Floor(highBlue * z + lowBlue * (One - z));

                newTemperatureColor = Color.FromArgb(tempRed, tempGreen, tempBlue);

                var colorNumber = FormulaNumberOne * tempRed + FormulaNumberTwo * tempGreen + tempBlue;
                return colorNumber;
            }

            if (temperature >= SecondRangeLow && temperature < SecondRangeHigh)
            {
                int highRed = this.secondHighestColor.R;
                int highGreen = this.secondHighestColor.G;
                int highBlue = this.secondHighestColor.B;

                int lowRed = this.secondLowestColor.R;
                int lowGreen = this.secondLowestColor.G;
                int lowBlue = this.secondLowestColor.B;

                // red
                var z = (double)(temperature - SecondRangeLow) / (SecondRangeHigh - SecondRangeLow);
                var tempRed = (int)Math.Floor(highRed * z + lowRed * (One - z));

                // green
                z = (double)(temperature - SecondRangeLow) / (SecondRangeHigh - SecondRangeLow);
                var tempGreen = (int)Math.Floor(highGreen * z + lowGreen * (One - z));

                // blue
                z = (double)(temperature - SecondRangeLow) / (SecondRangeHigh - SecondRangeLow);
                var tempBlue = (int)Math.Floor(highBlue * z + lowBlue * (One - z));

                newTemperatureColor = Color.FromArgb(tempRed, tempGreen, tempBlue);

                var colorNumber = FormulaNumberOne * tempRed + FormulaNumberTwo * tempGreen + tempBlue;
                return colorNumber;
            }

            if (temperature >= ThirdRangeLow && temperature < ThirdRangeHigh)
            {
                int highRed = this.thirdHighestColor.R;
                int highGreen = this.thirdHighestColor.G;
                int highBlue = this.thirdHighestColor.B;

                int lowRed = this.thirdLowestColor.R;
                int lowGreen = this.thirdLowestColor.G;
                int lowBlue = this.thirdLowestColor.B;

                // red
                var z = (double)(temperature - ThirdRangeLow) / (ThirdRangeHigh - ThirdRangeLow);
                var tempRed = (int)Math.Floor(highRed * z + lowRed * (One - z));

                // green
                z = (double)(temperature - ThirdRangeLow) / (ThirdRangeHigh - ThirdRangeLow);
                var tempGreen = (int)Math.Floor(highGreen * z + lowGreen * (One - z));

                // blue
                z = (double)(temperature - ThirdRangeLow) / (ThirdRangeHigh - ThirdRangeLow);
                var tempBlue = (int)Math.Floor(highBlue * z + lowBlue * (One - z));

                newTemperatureColor = Color.FromArgb(tempRed, tempGreen, tempBlue);

                var colorNumber = FormulaNumberOne * tempRed + FormulaNumberTwo * tempGreen + tempBlue;
                return colorNumber;
            }

            if (temperature >= FourthRangeLow && temperature <= FourthRangeHigh)
            {
                int highRed = this.fourthHighestColor.R;
                int highGreen = this.fourthHighestColor.G;
                int highBlue = this.fourthHighestColor.B;

                int lowRed = this.fourthLowestColor.R;
                int lowGreen = this.fourthLowestColor.G;
                int lowBlue = this.fourthLowestColor.B;

                // red
                var z = (double)(temperature - FourthRangeLow) / (FourthRangeHigh - FourthRangeLow);
                var tempRed = (int)Math.Floor(highRed * z + lowRed * (One - z));

                // green
                z = (double)(temperature - FourthRangeLow) / (FourthRangeHigh - FourthRangeLow);
                var tempGreen = (int)Math.Floor(highGreen * z + lowGreen * (One - z));

                // blue
                z = (double)(temperature - FourthRangeLow) / (FourthRangeHigh - FourthRangeLow);
                var tempBlue = (int)Math.Floor(highBlue * z + lowBlue * (One - z));

                newTemperatureColor = Color.FromArgb(tempRed, tempGreen, tempBlue);

                var colorNumber = FormulaNumberOne * tempRed + FormulaNumberTwo * tempGreen + tempBlue;
                return colorNumber;
            }

            // else, temperature is out of range doNothing();
            newTemperatureColor = Color.White;
            return One;
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
                this.hexValueRichTextBox.Text =
                    $@"#{newFormColor.R:X2}{newFormColor.G:X2}{newFormColor.B:X2} {Environment.NewLine}{newFormColor}";
            }
            else
            {
                this.tempatureNumericUpDown.Text = DefaultTemp.ToString();
            }
        }
    }
}