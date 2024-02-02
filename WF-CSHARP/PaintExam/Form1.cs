using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace Paint
{
	public partial class Form1 : Form
	{
		Bitmap bitmap;
		Graphics graphics;
		Point pointX, pointY;
		Color selectedColor = Color.Black;
		Pen pen = new Pen(Color.Black, 1);
		Pen erasePen = new Pen(Color.White, 20);
		int x, y, startX, startY, endX, endY;
		int toolIndex;
		bool isPaint;

		public Form1()
		{
			InitializeComponent();
			bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
			graphics = Graphics.FromImage(bitmap);
			pictureBox.Image = bitmap;
		}

		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			isPaint = true;
			pointY = e.Location;

			startX = e.X;
			startY = e.Y;
		}

		private void pictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			isPaint = false;

			endX = x - startX;
			endY = y - startY;

			switch (toolIndex)
			{
				case 3:
					graphics.FillEllipse(new SolidBrush(selectedColor), startX, startY, endX, endY);
					break;
				case 4:
					graphics.FillRectangle(new SolidBrush(selectedColor), startX, startY, endX, endY);
					break;
				case 5:
					graphics.DrawLine(pen, startX, startY, x, y);
					break;
				default:
					break;
			}
		}

		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (isPaint)
			{
				switch (toolIndex)
				{
					case 1:
						pointX = e.Location;
						graphics.DrawLine(pen, pointX, pointY);
						pointY = pointX;
						break;
					case 2:
						pointX = e.Location;
						graphics.DrawLine(erasePen, pointX, pointY);
						pointY = pointX;
						break;
					default:
						break;
				}
			}
			pictureBox.Refresh();

			x = e.X;
			y = e.Y;
			endX = e.X - startX;
			endY = e.Y - startY;
		}

		private void changeColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				selectedColor = dialog.Color;
				pen = new Pen(selectedColor, trackBar1.Value);
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			pen = new Pen(selectedColor, trackBar1.Value);
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			graphics.Clear(Color.White);
			pictureBox.Refresh();
		}

		private void penButton_Click(object sender, EventArgs e) => toolIndex = 1;

		private void eraserButton_Click(object sender, EventArgs e) => toolIndex = 2;

		private void ellipseButton_Click(object sender, EventArgs e) => toolIndex = 3;

		private void rectangleButton_Click(object sender, EventArgs e) => toolIndex = 4;

		private void lineButton_Click(object sender, EventArgs e) => toolIndex = 5;

		private void pictureBox_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			if (isPaint)
			{
				switch (toolIndex)
				{
					case 3:
						graphics.FillEllipse(new SolidBrush(selectedColor), startX, startY, endX, endY);
						break;
					case 4:
						graphics.FillRectangle(new SolidBrush(selectedColor), startX, startY, endX, endY);
						break;
					case 5:
						graphics.DrawLine(pen, startX, startY, x, y);
						break;
					default:
						break;
				}
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new();
			dialog.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Bitmap bm = bitmap.Clone(new Rectangle(0, 0, pictureBox.Width, pictureBox.Height), bitmap.PixelFormat);
				bm.Save(dialog.FileName, ImageFormat.Jpeg);
			}
		}
	}
}