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

        public int CalculateColor()
        {
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
                } // else no action needed DoNothing();
            }
            
        }
    }
}
