using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckForSepik.Data
{
    /// <summary>
    /// Pixel class
    /// </summary>
    public class Pixel
    {
        /// <summary>
        /// R value field
        /// </summary>
        private double r;

		/// <summary>
		/// G value field
		/// </summary>
		private double g;

        /// <summary>
        /// B value field
        /// </summary>
        private double b;

		/// <summary>
		/// R channel property
		/// </summary>
		public double R
		{
			get { return this.r; }
			set
			{
				if (value > 1)
				{
					this.r = 1;
				}
				else
				{
					this.r = value;
				}
			}
		}

		/// <summary>
		/// G channel property
		/// </summary>
		public double G
		{
			get { return this.g; }
			set
			{
				if (value > 1)
				{
					this.g = 1;
				}
				else
				{
					this.g = value;
				}
			}
		}

		/// <summary>
		/// B channel property
		/// </summary>
		public double B
		{
			get { return this.b; }
			set
			{
				if (value > 1)
				{
					this.b = 1;
				}
				else
				{
					this.b = value;
				}
			}
		}
	}
}
