using CheckForSepik.Data;
using System;
using System.Drawing;

namespace MyPhotoshop
{
	/// <summary>
	/// Photo class
	/// </summary>
	public class Photo
	{
		private int width;
		private int height;
		private Pixel[,] data;

		public int Width
		{
			get { return this.width; }
			set { this.width = value; }
		}

		public int Height
		{
			get { return this.height; }
			set { this.height = value; }
		}

		public Photo()
		{
			this.Width = bmp.Width;
		}
	}
}

