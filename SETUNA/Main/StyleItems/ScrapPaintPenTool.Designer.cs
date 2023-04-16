namespace SETUNA.Main.StyleItems
{
	// Token: 0x020000A6 RID: 166
	partial class ScrapPaintPenTool
	{
		// Token: 0x0600055B RID: 1371 RVA: 0x00024B5B File Offset: 0x00022D5B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00024B7C File Offset: 0x00022D7C
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrapPaintPenTool));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPen = new System.Windows.Forms.Panel();
            this.numPenSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.penButton5 = new SETUNA.Main.StyleItems.PenButton();
            this.penButton4 = new SETUNA.Main.StyleItems.PenButton();
            this.penButton3 = new SETUNA.Main.StyleItems.PenButton();
            this.penButton2 = new SETUNA.Main.StyleItems.PenButton();
            this.penButton1 = new SETUNA.Main.StyleItems.PenButton();
            this.pnlOpacity = new System.Windows.Forms.Panel();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCap = new System.Windows.Forms.Panel();
            this.cmbStart = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlPen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPenSize)).BeginInit();
            this.pnlOpacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            this.pnlCap.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.pnlPen);
            this.flowLayoutPanel1.Controls.Add(this.pnlOpacity);
            this.flowLayoutPanel1.Controls.Add(this.pnlCap);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip1.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // pnlPen
            // 
            resources.ApplyResources(this.pnlPen, "pnlPen");
            this.pnlPen.Controls.Add(this.numPenSize);
            this.pnlPen.Controls.Add(this.label4);
            this.pnlPen.Controls.Add(this.label3);
            this.pnlPen.Controls.Add(this.penButton5);
            this.pnlPen.Controls.Add(this.penButton4);
            this.pnlPen.Controls.Add(this.penButton3);
            this.pnlPen.Controls.Add(this.penButton2);
            this.pnlPen.Controls.Add(this.penButton1);
            this.pnlPen.Name = "pnlPen";
            this.toolTip1.SetToolTip(this.pnlPen, resources.GetString("pnlPen.ToolTip"));
            // 
            // numPenSize
            // 
            resources.ApplyResources(this.numPenSize, "numPenSize");
            this.numPenSize.Name = "numPenSize";
            this.numPenSize.TabStop = false;
            this.toolTip1.SetToolTip(this.numPenSize, resources.GetString("numPenSize.ToolTip"));
            this.numPenSize.ValueChanged += new System.EventHandler(this.numPenSize_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // penButton5
            // 
            resources.ApplyResources(this.penButton5, "penButton5");
            this.penButton5.AutoCheck = false;
            this.penButton5.ButtonColor = System.Drawing.Color.Black;
            this.penButton5.Name = "penButton5";
            this.penButton5.PenSize = 20;
            this.toolTip1.SetToolTip(this.penButton5, resources.GetString("penButton5.ToolTip"));
            this.penButton5.UseVisualStyleBackColor = true;
            this.penButton5.Click += new System.EventHandler(this.penButton1_Click);
            // 
            // penButton4
            // 
            resources.ApplyResources(this.penButton4, "penButton4");
            this.penButton4.AutoCheck = false;
            this.penButton4.ButtonColor = System.Drawing.Color.Black;
            this.penButton4.Name = "penButton4";
            this.penButton4.PenSize = 15;
            this.toolTip1.SetToolTip(this.penButton4, resources.GetString("penButton4.ToolTip"));
            this.penButton4.UseVisualStyleBackColor = true;
            this.penButton4.Click += new System.EventHandler(this.penButton1_Click);
            // 
            // penButton3
            // 
            resources.ApplyResources(this.penButton3, "penButton3");
            this.penButton3.AutoCheck = false;
            this.penButton3.ButtonColor = System.Drawing.Color.Black;
            this.penButton3.Name = "penButton3";
            this.penButton3.PenSize = 10;
            this.toolTip1.SetToolTip(this.penButton3, resources.GetString("penButton3.ToolTip"));
            this.penButton3.UseVisualStyleBackColor = true;
            this.penButton3.Click += new System.EventHandler(this.penButton1_Click);
            // 
            // penButton2
            // 
            resources.ApplyResources(this.penButton2, "penButton2");
            this.penButton2.AutoCheck = false;
            this.penButton2.ButtonColor = System.Drawing.Color.Black;
            this.penButton2.Name = "penButton2";
            this.penButton2.PenSize = 5;
            this.toolTip1.SetToolTip(this.penButton2, resources.GetString("penButton2.ToolTip"));
            this.penButton2.UseVisualStyleBackColor = true;
            this.penButton2.Click += new System.EventHandler(this.penButton1_Click);
            // 
            // penButton1
            // 
            resources.ApplyResources(this.penButton1, "penButton1");
            this.penButton1.AutoCheck = false;
            this.penButton1.ButtonColor = System.Drawing.Color.Black;
            this.penButton1.Name = "penButton1";
            this.penButton1.PenSize = 1;
            this.toolTip1.SetToolTip(this.penButton1, resources.GetString("penButton1.ToolTip"));
            this.penButton1.UseVisualStyleBackColor = true;
            this.penButton1.Click += new System.EventHandler(this.penButton1_Click);
            // 
            // pnlOpacity
            // 
            resources.ApplyResources(this.pnlOpacity, "pnlOpacity");
            this.pnlOpacity.Controls.Add(this.numOpacity);
            this.pnlOpacity.Controls.Add(this.label1);
            this.pnlOpacity.Controls.Add(this.label2);
            this.pnlOpacity.Name = "pnlOpacity";
            this.toolTip1.SetToolTip(this.pnlOpacity, resources.GetString("pnlOpacity.ToolTip"));
            // 
            // numOpacity
            // 
            resources.ApplyResources(this.numOpacity, "numOpacity");
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.TabStop = false;
            this.toolTip1.SetToolTip(this.numOpacity, resources.GetString("numOpacity.ToolTip"));
            this.numOpacity.ValueChanged += new System.EventHandler(this.numOpacity_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // pnlCap
            // 
            resources.ApplyResources(this.pnlCap, "pnlCap");
            this.pnlCap.Controls.Add(this.cmbStart);
            this.pnlCap.Name = "pnlCap";
            this.toolTip1.SetToolTip(this.pnlCap, resources.GetString("pnlCap.ToolTip"));
            // 
            // cmbStart
            // 
            resources.ApplyResources(this.cmbStart, "cmbStart");
            this.cmbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStart.FormattingEnabled = true;
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.TabStop = false;
            this.toolTip1.SetToolTip(this.cmbStart, resources.GetString("cmbStart.ToolTip"));
            // 
            // ScrapPaintPenTool
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScrapPaintPenTool";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrapPaintPenTool_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlPen.ResumeLayout(false);
            this.pnlPen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPenSize)).EndInit();
            this.pnlOpacity.ResumeLayout(false);
            this.pnlOpacity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            this.pnlCap.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000357 RID: 855
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000358 RID: 856
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x04000359 RID: 857
		private global::System.Windows.Forms.Panel pnlPen;

		// Token: 0x0400035A RID: 858
		private global::System.Windows.Forms.Panel pnlOpacity;

		// Token: 0x0400035B RID: 859
		private global::System.Windows.Forms.NumericUpDown numOpacity;

		// Token: 0x0400035C RID: 860
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400035D RID: 861
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400035E RID: 862
		private global::System.Windows.Forms.Panel pnlCap;

		// Token: 0x0400035F RID: 863
		private global::System.Windows.Forms.ComboBox cmbStart;

		// Token: 0x04000360 RID: 864
		private global::SETUNA.Main.StyleItems.PenButton penButton1;

		// Token: 0x04000361 RID: 865
		private global::SETUNA.Main.StyleItems.PenButton penButton5;

		// Token: 0x04000362 RID: 866
		private global::SETUNA.Main.StyleItems.PenButton penButton4;

		// Token: 0x04000363 RID: 867
		private global::SETUNA.Main.StyleItems.PenButton penButton3;

		// Token: 0x04000364 RID: 868
		private global::SETUNA.Main.StyleItems.PenButton penButton2;

		// Token: 0x04000365 RID: 869
		private global::System.Windows.Forms.NumericUpDown numPenSize;

		// Token: 0x04000366 RID: 870
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000367 RID: 871
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000368 RID: 872
		private global::System.Windows.Forms.ToolTip toolTip1;
	}
}
