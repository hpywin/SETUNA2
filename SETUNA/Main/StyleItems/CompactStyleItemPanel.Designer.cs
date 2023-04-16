namespace SETUNA.Main.StyleItems
{
	// Token: 0x0200007A RID: 122
	partial class CompactStyleItemPanel
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x00019030 File Offset: 0x00017230
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompactStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDashed = new System.Windows.Forms.RadioButton();
            this.rdoSolid = new System.Windows.Forms.RadioButton();
            this.picLineColor = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.barOpacity = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLineColor)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            resources.ApplyResources(this.cmdOK, "cmdOK");
            // 
            // cmdCancel
            // 
            resources.ApplyResources(this.cmdCancel, "cmdCancel");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDashed);
            this.groupBox1.Controls.Add(this.rdoSolid);
            this.groupBox1.Controls.Add(this.picLineColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.barOpacity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numOpacity);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rdoDashed
            // 
            resources.ApplyResources(this.rdoDashed, "rdoDashed");
            this.rdoDashed.Name = "rdoDashed";
            this.rdoDashed.TabStop = true;
            this.rdoDashed.UseVisualStyleBackColor = true;
            // 
            // rdoSolid
            // 
            resources.ApplyResources(this.rdoSolid, "rdoSolid");
            this.rdoSolid.Name = "rdoSolid";
            this.rdoSolid.TabStop = true;
            this.rdoSolid.UseVisualStyleBackColor = true;
            this.rdoSolid.CheckedChanged += new System.EventHandler(this.rdoSolid_CheckedChanged);
            // 
            // picLineColor
            // 
            this.picLineColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLineColor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.picLineColor, "picLineColor");
            this.picLineColor.Name = "picLineColor";
            this.picLineColor.TabStop = false;
            this.picLineColor.Click += new System.EventHandler(this.picLineColor_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picPreview);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.picPreview, "picPreview");
            this.picPreview.Name = "picPreview";
            this.picPreview.TabStop = false;
            this.picPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.picPreview_Paint);
            // 
            // barOpacity
            // 
            resources.ApplyResources(this.barOpacity, "barOpacity");
            this.barOpacity.Maximum = 100;
            this.barOpacity.Minimum = 1;
            this.barOpacity.Name = "barOpacity";
            this.barOpacity.TickFrequency = 10;
            this.barOpacity.Value = 1;
            this.barOpacity.Scroll += new System.EventHandler(this.barOpacity_Scroll);
            this.barOpacity.ValueChanged += new System.EventHandler(this.barOpacity_ValueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numOpacity
            // 
            resources.ApplyResources(this.numOpacity, "numOpacity");
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.ValueChanged += new System.EventHandler(this.numOpacity_ValueChanged);
            this.numOpacity.Enter += new System.EventHandler(this.numOpacity_Enter);
            // 
            // CompactStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "CompactStyleItemPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpacityStyleItemPanel_FormClosed);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLineColor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000259 RID: 601
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400025A RID: 602
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400025B RID: 603
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400025C RID: 604
		private global::System.Windows.Forms.TrackBar barOpacity;

		// Token: 0x0400025D RID: 605
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400025E RID: 606
		private global::System.Windows.Forms.PictureBox picPreview;

		// Token: 0x0400025F RID: 607
		private global::System.Windows.Forms.NumericUpDown numOpacity;

		// Token: 0x04000263 RID: 611
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000264 RID: 612
		private global::System.Windows.Forms.RadioButton rdoDashed;

		// Token: 0x04000265 RID: 613
		private global::System.Windows.Forms.RadioButton rdoSolid;

		// Token: 0x04000266 RID: 614
		private global::System.Windows.Forms.PictureBox picLineColor;

		// Token: 0x04000267 RID: 615
		private global::System.Windows.Forms.ColorDialog colorDialog1;
	}
}
