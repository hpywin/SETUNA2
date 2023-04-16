namespace SETUNA.Main.StyleItems
{
	// Token: 0x02000099 RID: 153
	partial class ScrapPaintTextTool
	{
		// Token: 0x06000510 RID: 1296 RVA: 0x00023AC8 File Offset: 0x00021CC8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00023AE8 File Offset: 0x00021CE8
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrapPaintTextTool));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPen = new System.Windows.Forms.Panel();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlEditing = new System.Windows.Forms.Panel();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlPen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.pnlEditing.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.pnlPen);
            this.flowLayoutPanel1.Controls.Add(this.pnlEditing);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip1.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // pnlPen
            // 
            resources.ApplyResources(this.pnlPen, "pnlPen");
            this.pnlPen.Controls.Add(this.cmbFont);
            this.pnlPen.Controls.Add(this.label5);
            this.pnlPen.Controls.Add(this.numFontSize);
            this.pnlPen.Controls.Add(this.label4);
            this.pnlPen.Controls.Add(this.label3);
            this.pnlPen.Name = "pnlPen";
            this.toolTip1.SetToolTip(this.pnlPen, resources.GetString("pnlPen.ToolTip"));
            // 
            // cmbFont
            // 
            resources.ApplyResources(this.cmbFont, "cmbFont");
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.DropDownWidth = 230;
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Name = "cmbFont";
            this.toolTip1.SetToolTip(this.cmbFont, resources.GetString("cmbFont.ToolTip"));
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // numFontSize
            // 
            resources.ApplyResources(this.numFontSize, "numFontSize");
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.TabStop = false;
            this.toolTip1.SetToolTip(this.numFontSize, resources.GetString("numFontSize.ToolTip"));
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
            // pnlEditing
            // 
            resources.ApplyResources(this.pnlEditing, "pnlEditing");
            this.pnlEditing.Controls.Add(this.btnEditCancel);
            this.pnlEditing.Controls.Add(this.btnEditOK);
            this.pnlEditing.Name = "pnlEditing";
            this.toolTip1.SetToolTip(this.pnlEditing, resources.GetString("pnlEditing.ToolTip"));
            // 
            // btnEditCancel
            // 
            resources.ApplyResources(this.btnEditCancel, "btnEditCancel");
            this.btnEditCancel.Name = "btnEditCancel";
            this.toolTip1.SetToolTip(this.btnEditCancel, resources.GetString("btnEditCancel.ToolTip"));
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditOK
            // 
            resources.ApplyResources(this.btnEditOK, "btnEditOK");
            this.btnEditOK.Name = "btnEditOK";
            this.toolTip1.SetToolTip(this.btnEditOK, resources.GetString("btnEditOK.ToolTip"));
            this.btnEditOK.UseVisualStyleBackColor = true;
            this.btnEditOK.Click += new System.EventHandler(this.btnEditOK_Click);
            // 
            // ScrapPaintTextTool
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScrapPaintTextTool";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrapPaintTextTool_FormClosing);
            this.Shown += new System.EventHandler(this.ScrapPaintTextTool_Shown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlPen.ResumeLayout(false);
            this.pnlPen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.pnlEditing.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000336 RID: 822
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000337 RID: 823
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x04000338 RID: 824
		private global::System.Windows.Forms.Panel pnlPen;

		// Token: 0x04000339 RID: 825
		private global::System.Windows.Forms.NumericUpDown numFontSize;

		// Token: 0x0400033A RID: 826
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400033B RID: 827
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400033C RID: 828
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x0400033D RID: 829
		private global::System.Windows.Forms.ComboBox cmbFont;

		// Token: 0x0400033E RID: 830
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400033F RID: 831
		private global::System.Windows.Forms.Panel pnlEditing;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.Button btnEditCancel;

		// Token: 0x04000341 RID: 833
		private global::System.Windows.Forms.Button btnEditOK;
	}
}
