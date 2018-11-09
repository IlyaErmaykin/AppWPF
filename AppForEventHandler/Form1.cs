using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForEventРandler
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			//if (e.Button == MouseButtons.Left)
			//{
			//	MessageBox.Show("Left tButton");
			//	//do something
			//}
			//else if (e.Button == MouseButtons.Right)
			//{
			//	MessageBox.Show("Righ tButton");
			//	//do something
			//}
		}

		private void textBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				MessageBox.Show("Left tButton");
				//do something
			}
			else if (e.Button == MouseButtons.Right)
			{
				MessageBox.Show("Righ tButton");
				//do something
			}
		}

		private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				//MessageBox.Show("Left tButton");
			}
			else
			{
				ContextMenuStrip my_menu = new ContextMenuStrip();
				int position_xy_mouse_row = dataGridView1.HitTest(e.X, e.Y).RowIndex;

				//MessageBox.Show("Rigth tButton");
				//MessageBox.Show(position_xy_mouse_row.ToString());

				if (position_xy_mouse_row > -1)
				{
					//my_menu.Items.Add("Del").Name = "Del";
					contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
				}
			}
		}
	}
}
