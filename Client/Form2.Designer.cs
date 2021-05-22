namespace Client
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
			this.doubleBuf1 = new Client.DoubleBuf();
			this.cld = new System.Windows.Forms.ColorDialog();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.PencilItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LineItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CirItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RectItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.line1 = new System.Windows.Forms.ToolStripMenuItem();
			this.line2 = new System.Windows.Forms.ToolStripMenuItem();
			this.line3 = new System.Windows.Forms.ToolStripMenuItem();
			this.line4 = new System.Windows.Forms.ToolStripMenuItem();
			this.line5 = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_fill = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
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
			// doubleBuf1
			// 
			this.doubleBuf1.BackColor = System.Drawing.Color.White;
			this.doubleBuf1.Location = new System.Drawing.Point(0, 29);
			this.doubleBuf1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.doubleBuf1.Name = "doubleBuf1";
			this.doubleBuf1.Size = new System.Drawing.Size(640, 341);
			this.doubleBuf1.TabIndex = 0;
			this.doubleBuf1.Paint += new System.Windows.Forms.PaintEventHandler(this.doubleBuf1_Paint);
			this.doubleBuf1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.doubleBuf1_MouseDown);
			this.doubleBuf1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.doubleBuf1_MouseMove);
			this.doubleBuf1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.doubleBuf1_MouseUp);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PencilItem,
            this.LineItem,
            this.CirItem,
            this.RectItem});
			this.toolStripDropDownButton1.Image = global::Client.Properties.Resources.연필;
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 24);
			this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			// 
			// PencilItem
			// 
			this.PencilItem.Image = global::Client.Properties.Resources.연필;
			this.PencilItem.Name = "PencilItem";
			this.PencilItem.Size = new System.Drawing.Size(106, 22);
			this.PencilItem.Text = "Pencil";
			this.PencilItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// LineItem
			// 
			this.LineItem.Image = global::Client.Properties.Resources.직선;
			this.LineItem.Name = "LineItem";
			this.LineItem.Size = new System.Drawing.Size(106, 22);
			this.LineItem.Text = "Line";
			this.LineItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// CirItem
			// 
			this.CirItem.Image = global::Client.Properties.Resources.원;
			this.CirItem.Name = "CirItem";
			this.CirItem.Size = new System.Drawing.Size(106, 22);
			this.CirItem.Text = "Circle";
			this.CirItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// RectItem
			// 
			this.RectItem.Image = global::Client.Properties.Resources.사각형;
			this.RectItem.Name = "RectItem";
			this.RectItem.Size = new System.Drawing.Size(106, 22);
			this.RectItem.Text = "Rect";
			this.RectItem.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.line5});
			this.toolStripDropDownButton2.Image = global::Client.Properties.Resources.line1Button;
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(33, 24);
			this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
			// 
			// line1
			// 
			this.line1.Image = global::Client.Properties.Resources.line1Button;
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(100, 22);
			this.line1.Text = "line1";
			this.line1.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
			// 
			// line2
			// 
			this.line2.Image = global::Client.Properties.Resources.line2Button;
			this.line2.Name = "line2";
			this.line2.Size = new System.Drawing.Size(100, 22);
			this.line2.Text = "line2";
			this.line2.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
			// 
			// line3
			// 
			this.line3.Image = global::Client.Properties.Resources.line3Button;
			this.line3.Name = "line3";
			this.line3.Size = new System.Drawing.Size(100, 22);
			this.line3.Text = "line3";
			this.line3.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
			// 
			// line4
			// 
			this.line4.Image = global::Client.Properties.Resources.line4Button;
			this.line4.Name = "line4";
			this.line4.Size = new System.Drawing.Size(100, 22);
			this.line4.Text = "line4";
			this.line4.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
			// 
			// line5
			// 
			this.line5.Image = global::Client.Properties.Resources.line5Button;
			this.line5.Name = "line5";
			this.line5.Size = new System.Drawing.Size(100, 22);
			this.line5.Text = "line5";
			this.line5.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
			// 
			// btn_fill
			// 
			this.btn_fill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_fill.ForeColor = System.Drawing.Color.Red;
			this.btn_fill.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_fill.Name = "btn_fill";
			this.btn_fill.Size = new System.Drawing.Size(47, 24);
			this.btn_fill.Text = "채우기";
			this.btn_fill.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(47, 24);
			this.toolStripButton2.Text = "초기화";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.BackColor = System.Drawing.SystemColors.ControlText;
			this.toolStripButton3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolStripButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 24);
			this.toolStripButton3.Text = "선";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 24);
			this.toolStripButton4.Text = "면";
			this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_1);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.btn_fill,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(640, 27);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolStripButton5.ForeColor = System.Drawing.SystemColors.InfoText;
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 24);
			this.toolStripButton5.Text = "면";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 369);
			this.Controls.Add(this.doubleBuf1);
			this.Controls.Add(this.toolStrip1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form2";
			this.Text = "Form2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColorDialog cld;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem PencilItem;
        private System.Windows.Forms.ToolStripMenuItem LineItem;
        private System.Windows.Forms.ToolStripMenuItem CirItem;
        private System.Windows.Forms.ToolStripMenuItem RectItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem line1;
        private System.Windows.Forms.ToolStripMenuItem line2;
        private System.Windows.Forms.ToolStripMenuItem line3;
        private System.Windows.Forms.ToolStripMenuItem line4;
        private System.Windows.Forms.ToolStripMenuItem line5;
        private System.Windows.Forms.ToolStripButton btn_fill;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
		public DoubleBuf doubleBuf1;
	}
}