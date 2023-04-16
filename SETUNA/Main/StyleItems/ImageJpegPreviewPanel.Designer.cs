namespace SETUNA.Main.StyleItems
{
	// Token: 0x02000091 RID: 145
	partial class ImageJpegPreviewPanel
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x00020FD0 File Offset: 0x0001F1D0
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageJpegPreviewPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barQuality = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSize = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barQuality)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.barQuality);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblQuality);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // barQuality
            // 
            resources.ApplyResources(this.barQuality, "barQuality");
            this.barQuality.Maximum = 100;
            this.barQuality.Name = "barQuality";
            this.barQuality.TickFrequency = 10;
            this.barQuality.Scroll += new System.EventHandler(this.barQuality_Scroll);
            this.barQuality.ValueChanged += new System.EventHandler(this.barQuality_Scroll);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picPreview);
            this.panel1.Name = "panel1";
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseUp);
            // 
            // picPreview
            // 
            resources.ApplyResources(this.picPreview, "picPreview");
            this.picPreview.Name = "picPreview";
            this.picPreview.TabStop = false;
            this.picPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseDown);
            this.picPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseUp);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblQuality
            // 
            resources.ApplyResources(this.lblQuality, "lblQuality");
            this.lblQuality.Name = "lblQuality";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            // 
            // lblSize
            // 
            resources.ApplyResources(this.lblSize, "lblSize");
            this.lblSize.Name = "lblSize";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ImageJpegPreviewPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ImageJpegPreviewPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImageJpegPreviewPanel_FormClosed);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblSize, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barQuality)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x040002FB RID: 763
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x040002FC RID: 764
		private global::System.Windows.Forms.TrackBar barQuality;

		// Token: 0x040002FD RID: 765
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002FE RID: 766
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040002FF RID: 767
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000300 RID: 768
		private global::System.Windows.Forms.Label lblQuality;

		// Token: 0x04000301 RID: 769
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000303 RID: 771
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000304 RID: 772
		private global::System.Windows.Forms.PictureBox picPreview;

		// Token: 0x04000308 RID: 776
		private global::System.Windows.Forms.Label lblSize;

		// Token: 0x04000309 RID: 777
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400030A RID: 778
		private global::System.ComponentModel.IContainer components;
	}
}
