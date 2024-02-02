namespace MusicShopExam
{
	partial class ShopFormAdmin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			postponePlateButton = new Button();
			setPromotionButton = new Button();
			deletePlateButton = new Button();
			addPlateButton = new Button();
			itemsListBox = new ListBox();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(postponePlateButton);
			panel1.Controls.Add(setPromotionButton);
			panel1.Controls.Add(deletePlateButton);
			panel1.Controls.Add(addPlateButton);
			panel1.Location = new Point(0, 1);
			panel1.Name = "panel1";
			panel1.Size = new Size(267, 672);
			panel1.TabIndex = 1;
			// 
			// postponePlateButton
			// 
			postponePlateButton.BackColor = Color.FromArgb(46, 213, 115);
			postponePlateButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			postponePlateButton.ForeColor = Color.White;
			postponePlateButton.Location = new Point(38, 301);
			postponePlateButton.Name = "postponePlateButton";
			postponePlateButton.Size = new Size(187, 59);
			postponePlateButton.TabIndex = 4;
			postponePlateButton.Text = "POSTPONE";
			postponePlateButton.UseVisualStyleBackColor = false;
			// 
			// setPromotionButton
			// 
			setPromotionButton.BackColor = Color.FromArgb(46, 213, 115);
			setPromotionButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			setPromotionButton.ForeColor = Color.White;
			setPromotionButton.Location = new Point(38, 219);
			setPromotionButton.Name = "setPromotionButton";
			setPromotionButton.Size = new Size(187, 59);
			setPromotionButton.TabIndex = 3;
			setPromotionButton.Text = "PROMOTION";
			setPromotionButton.UseVisualStyleBackColor = false;
			// 
			// deletePlateButton
			// 
			deletePlateButton.BackColor = Color.FromArgb(46, 213, 115);
			deletePlateButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			deletePlateButton.ForeColor = Color.White;
			deletePlateButton.Location = new Point(38, 134);
			deletePlateButton.Name = "deletePlateButton";
			deletePlateButton.Size = new Size(187, 59);
			deletePlateButton.TabIndex = 1;
			deletePlateButton.Text = "DELETE";
			deletePlateButton.UseVisualStyleBackColor = false;
			deletePlateButton.Click += deletePlateButton_Click;
			// 
			// addPlateButton
			// 
			addPlateButton.BackColor = Color.FromArgb(46, 213, 115);
			addPlateButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			addPlateButton.ForeColor = Color.White;
			addPlateButton.Location = new Point(38, 49);
			addPlateButton.Name = "addPlateButton";
			addPlateButton.Size = new Size(187, 59);
			addPlateButton.TabIndex = 0;
			addPlateButton.Text = "ADD";
			addPlateButton.UseVisualStyleBackColor = false;
			addPlateButton.Click += addPlateButton_Click;
			// 
			// itemsListBox
			// 
			itemsListBox.BackColor = Color.FromArgb(54, 54, 54);
			itemsListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			itemsListBox.ForeColor = Color.White;
			itemsListBox.FormattingEnabled = true;
			itemsListBox.ItemHeight = 30;
			itemsListBox.Location = new Point(307, 50);
			itemsListBox.Name = "itemsListBox";
			itemsListBox.Size = new Size(763, 604);
			itemsListBox.TabIndex = 2;
			// 
			// ShopFormAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(38, 38, 38);
			ClientSize = new Size(1095, 668);
			Controls.Add(itemsListBox);
			Controls.Add(panel1);
			Name = "ShopFormAdmin";
			Text = "ShopFormAdmin";
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button addPlateButton;
		private Button deletePlateButton;
		private Button setPromotionButton;
		private Button postponePlateButton;
		private ListBox itemsListBox;
	}
}