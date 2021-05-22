namespace Server
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.cld = new System.Windows.Forms.ColorDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.doubleBuf1 = new Server.DoubleBuf();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "line1Button.JPG");
			this.imageList1.Images.SetKeyName(1, "line2Button.JPG");
			this.imageList1.Images.SetKeyName(2, "line3Button.JPG");
			this.imageList1.Images.SetKeyName(3, "line4Button.JPG");
			this.imageList1.Images.SetKeyName(4, "line5Button.JPG");
			this.imageList1.Images.SetKeyName(5, "꽉찬 사각형.jpg");
			this.imageList1.Images.SetKeyName(6, "꽉찬 원.jpg");
			this.imageList1.Images.SetKeyName(7, "사각형.jpg");
			this.imageList1.Images.SetKeyName(8, "연필.jpg");
			this.imageList1.Images.SetKeyName(9, "원.jpg");
			this.imageList1.Images.SetKeyName(10, "직선.jpg");
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.doubleBuf1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(631, 395);
			this.panel1.TabIndex = 0;
			// 
			// doubleBuf1
			// 
			this.doubleBuf1.Location = new System.Drawing.Point(0, 0);
			this.doubleBuf1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.doubleBuf1.Name = "doubleBuf1";
			this.doubleBuf1.Size = new System.Drawing.Size(628, 393);
			this.doubleBuf1.TabIndex = 0;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 392);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form2";
			this.Text = "Form2";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ColorDialog cld;
		private System.Windows.Forms.Panel panel1;
		public DoubleBuf doubleBuf1;
	}
}