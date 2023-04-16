namespace SETUNA.Main.StyleItems
{
	// Token: 0x0200000C RID: 12
	partial class ImagePngPreviewPanel
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00004E0C File Offset: 0x0000300C
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagePngPreviewPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barQuality = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
            // ImagePngPreviewPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Name = "ImagePngPreviewPanel";
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barQuality)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.TrackBar barQuality;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label lblQuality;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.PictureBox picPreview;
	}
}
