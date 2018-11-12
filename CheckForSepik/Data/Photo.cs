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
		public readonly int width;
		public readonly int height;
		public readonly Pixel[,] data;

		//public int Width
		//{
		//	get { return this.width; }
		//	set { this.width = value; }
		//}

		//public int Height
		//{
		//	get { return this.height; }
		//	set { this.height = value; }
		//}

		//public Photo()
		//{
		//	//this.Width = bmp.Width;
		//}

				/// <summary>
		/// Default constructor with parametrs
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		public Photo(int width, int height)
		{
			this.width = width;
			this.height = height;
			data = new Pixel[width, height];

			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < height; y++)
				{
					data[x, y] = new Pixel();
				}
			}
	}
	}
}


