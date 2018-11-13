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
	public struct Pixel
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
				this.r = CheckValue(value);
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
				this.g = CheckValue(value);
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
				this.b = CheckValue(value);
			}
		}

		/// <summary>
		/// Trim function
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static double Trim(double value)
		{
			if (value < 0) return 0;
			if (value > 1) return 1;
			return value;
		}

		/// <summary>
		/// Check value function
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private double CheckValue(double value)
		{
			if (value < 0 || value > 1)
			{
				throw new ArgumentException();
			}
			return value;
		}

		/// <summary>
		/// default constructor with 
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		public Pixel(double r, double g, double b)
		{
			this.r = this.g = this.b = 0;
			this.R = r;
			this.G = g;
			this.B = b;
		}

		public static Pixel operator *(Pixel p, double v)
		{
			return new Pixel(
					Pixel.Trim(p.R * v),
					Pixel.Trim(p.G * v),
					Pixel.Trim(p.B * v)
					);
		}

		public static Pixel operator *(double v, Pixel p)
		{
			return new Pixel(
					Pixel.Trim(p.R * v),
					Pixel.Trim(p.G * v),
					Pixel.Trim(p.B * v)
					);
		}
	}
}