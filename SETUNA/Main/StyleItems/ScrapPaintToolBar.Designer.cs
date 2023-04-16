namespace SETUNA.Main.StyleItems
{
	// Token: 0x02000024 RID: 36
	partial class ScrapPaintToolBar
	{
		// Token: 0x06000181 RID: 385 RVA: 0x0000895F File Offset: 0x00006B5F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00008980 File Offset: 0x00006B80
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrapPaintToolBar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picColorA = new System.Windows.Forms.PictureBox();
            this.picColorB = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkPen = new System.Windows.Forms.CheckBox();
            this.chkText = new System.Windows.Forms.CheckBox();
            this.chkErase = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorB)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picColorA);
            this.panel1.Controls.Add(this.picColorB);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // picColorA
            // 
            resources.ApplyResources(this.picColorA, "picColorA");
            this.picColorA.BackColor = System.Drawing.Color.White;
            this.picColorA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picColorA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picColorA.Name = "picColorA";
            this.picColorA.TabStop = false;
            this.toolTip1.SetToolTip(this.picColorA, resources.GetString("picColorA.ToolTip"));
            this.picColorA.BackColorChanged += new System.EventHandler(this.picColorA_BackColorChanged);
            this.picColorA.Click += new System.EventHandler(this.picColorA_Click);
            // 
            // picColorB
            // 
            resources.ApplyResources(this.picColorB, "picColorB");
            this.picColorB.BackColor = System.Drawing.Color.Black;
            this.picColorB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picColorB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picColorB.Name = "picColorB";
            this.picColorB.TabStop = false;
            this.toolTip1.SetToolTip(this.picColorB, resources.GetString("picColorB.ToolTip"));
            this.picColorB.Click += new System.EventHandler(this.picColorB_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.chkPen, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkText, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkErase, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.toolTip1.SetToolTip(this.tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // chkPen
            // 
            resources.ApplyResources(this.chkPen, "chkPen");
            this.chkPen.AutoCheck = false;
            this.chkPen.Image = global::SETUNA.Properties.Resources.pi_pen;
            this.chkPen.Name = "chkPen";
            this.toolTip1.SetToolTip(this.chkPen, resources.GetString("chkPen.ToolTip"));
            this.chkPen.UseVisualStyleBackColor = true;
            this.chkPen.Click += new System.EventHandler(this.chkPen_Click);
            // 
            // chkText
            // 
            resources.ApplyResources(this.chkText, "chkText");
            this.chkText.AutoCheck = false;
            this.chkText.Image = global::SETUNA.Properties.Resources.pi_text;
            this.chkText.Name = "chkText";
            this.toolTip1.SetToolTip(this.chkText, resources.GetString("chkText.ToolTip"));
            this.chkText.UseVisualStyleBackColor = true;
            this.chkText.Click += new System.EventHandler(this.chkPen_Click);
            // 
            // chkErase
            // 
            resources.ApplyResources(this.chkErase, "chkErase");
            this.chkErase.AutoCheck = false;
            this.chkErase.Image = global::SETUNA.Properties.Resources.pi_erase;
            this.chkErase.Name = "chkErase";
            this.toolTip1.SetToolTip(this.chkErase, resources.GetString("chkErase.ToolTip"));
            this.chkErase.UseVisualStyleBackColor = true;
            this.chkErase.Click += new System.EventHandler(this.chkPen_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // ScrapPaintToolBar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "ScrapPaintToolBar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrapPaintToolBar_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picColorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorB)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x040000AB RID: 171
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.CheckBox chkPen;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.PictureBox picColorB;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.PictureBox picColorA;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.CheckBox chkErase;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.CheckBox chkText;
	}
}
