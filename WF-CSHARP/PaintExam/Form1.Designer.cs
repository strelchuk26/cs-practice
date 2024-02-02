namespace Paint
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pictureBox = new PictureBox();
			trackBar1 = new TrackBar();
			changeColorButton = new Button();
			penButton = new Button();
			eraserButton = new Button();
			clearButton = new Button();
			panel1 = new Panel();
			saveButton = new Button();
			lineButton = new Button();
			rectangleButton = new Button();
			ellipseButton = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox
			// 
			pictureBox.BackColor = Color.White;
			pictureBox.Dock = DockStyle.Right;
			pictureBox.Location = new Point(89, 0);
			pictureBox.Margin = new Padding(2, 1, 2, 1);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(1175, 755);
			pictureBox.TabIndex = 1;
			pictureBox.TabStop = false;
			pictureBox.Paint += pictureBox_Paint;
			pictureBox.MouseDown += pictureBox_MouseDown;
			pictureBox.MouseMove += pictureBox_MouseMove;
			pictureBox.MouseUp += pictureBox_MouseUp;
			// 
			// trackBar1
			// 
			trackBar1.LargeChange = 1;
			trackBar1.Location = new Point(24, 579);
			trackBar1.Minimum = 1;
			trackBar1.Name = "trackBar1";
			trackBar1.Orientation = Orientation.Vertical;
			trackBar1.Size = new Size(45, 175);
			trackBar1.TabIndex = 2;
			trackBar1.Value = 1;
			trackBar1.Scroll += trackBar1_Scroll;
			// 
			// changeColorButton
			// 
			changeColorButton.BackgroundImageLayout = ImageLayout.Zoom;
			changeColorButton.Cursor = Cursors.Hand;
			changeColorButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			changeColorButton.Location = new Point(12, 12);
			changeColorButton.Name = "changeColorButton";
			changeColorButton.Size = new Size(65, 65);
			changeColorButton.TabIndex = 3;
			changeColorButton.Text = "COLOR";
			changeColorButton.UseVisualStyleBackColor = true;
			changeColorButton.Click += changeColorButton_Click;
			// 
			// penButton
			// 
			penButton.Cursor = Cursors.Hand;
			penButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			penButton.Location = new Point(12, 83);
			penButton.Name = "penButton";
			penButton.Size = new Size(65, 65);
			penButton.TabIndex = 4;
			penButton.Text = "PEN";
			penButton.UseVisualStyleBackColor = true;
			penButton.Click += penButton_Click;
			// 
			// eraserButton
			// 
			eraserButton.Cursor = Cursors.Hand;
			eraserButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			eraserButton.Location = new Point(14, 368);
			eraserButton.Name = "eraserButton";
			eraserButton.Size = new Size(65, 65);
			eraserButton.TabIndex = 5;
			eraserButton.Text = "ERASER";
			eraserButton.UseVisualStyleBackColor = true;
			eraserButton.Click += eraserButton_Click;
			// 
			// clearButton
			// 
			clearButton.Cursor = Cursors.Hand;
			clearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			clearButton.Location = new Point(14, 439);
			clearButton.Name = "clearButton";
			clearButton.Size = new Size(65, 65);
			clearButton.TabIndex = 6;
			clearButton.Text = "CLEAR";
			clearButton.UseVisualStyleBackColor = true;
			clearButton.Click += clearButton_Click;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlDarkDark;
			panel1.Controls.Add(saveButton);
			panel1.Controls.Add(lineButton);
			panel1.Controls.Add(rectangleButton);
			panel1.Controls.Add(ellipseButton);
			panel1.Controls.Add(trackBar1);
			panel1.Controls.Add(clearButton);
			panel1.Controls.Add(eraserButton);
			panel1.Location = new Point(-2, -1);
			panel1.Name = "panel1";
			panel1.Size = new Size(93, 755);
			panel1.TabIndex = 7;
			// 
			// saveButton
			// 
			saveButton.Cursor = Cursors.Hand;
			saveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			saveButton.Location = new Point(14, 510);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(65, 65);
			saveButton.TabIndex = 11;
			saveButton.Text = "SAVE";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// lineButton
			// 
			lineButton.Cursor = Cursors.Hand;
			lineButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			lineButton.Location = new Point(14, 297);
			lineButton.Name = "lineButton";
			lineButton.Size = new Size(65, 65);
			lineButton.TabIndex = 10;
			lineButton.Text = "LINE";
			lineButton.UseVisualStyleBackColor = true;
			lineButton.Click += lineButton_Click;
			// 
			// rectangleButton
			// 
			rectangleButton.Cursor = Cursors.Hand;
			rectangleButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			rectangleButton.Location = new Point(14, 226);
			rectangleButton.Name = "rectangleButton";
			rectangleButton.Size = new Size(65, 65);
			rectangleButton.TabIndex = 9;
			rectangleButton.Text = "RECT";
			rectangleButton.UseVisualStyleBackColor = true;
			rectangleButton.Click += rectangleButton_Click;
			// 
			// ellipseButton
			// 
			ellipseButton.Cursor = Cursors.Hand;
			ellipseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			ellipseButton.Location = new Point(14, 155);
			ellipseButton.Name = "ellipseButton";
			ellipseButton.Size = new Size(65, 65);
			ellipseButton.TabIndex = 8;
			ellipseButton.Text = "ELLIPSE";
			ellipseButton.UseVisualStyleBackColor = true;
			ellipseButton.Click += ellipseButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1264, 755);
			Controls.Add(penButton);
			Controls.Add(changeColorButton);
			Controls.Add(pictureBox);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(2, 1, 2, 1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Paint";
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private PictureBox pictureBox;
		private TrackBar trackBar1;
		private Button changeColorButton;
		private Button penButton;
		private Button eraserButton;
		private Button clearButton;
		private Panel panel1;
		private Button ellipseButton;
		private Button rectangleButton;
		private Button lineButton;
		private Button saveButton;
	}
}