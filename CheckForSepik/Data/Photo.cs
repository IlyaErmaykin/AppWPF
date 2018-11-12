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
		/// <summary>
		/// Width value field
		/// </summary>
		public readonly int width;

		/// <summary>
		/// Height value field
		/// </summary>
		public readonly int height;

		/// <summary>
		/// Data value field
		/// </summary>
		private readonly Pixel[,] data;

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
		/// Pixel indexer
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public Pixel this[int x, int y]
		{
			get { return data[x, y]; }
			set { data[x, y] = value; }
		}

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
		}
	}
}


