namespace SETUNA.Main.StyleItems
{
	// Token: 0x02000003 RID: 3
	partial class MarginStyleItemPanel
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000230C File Offset: 0x0000050C
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarginStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.rdoSolid = new System.Windows.Forms.RadioButton();
            this.rdo3D = new System.Windows.Forms.RadioButton();
            this.rdoWindow = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMargin = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMargin)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.chkTopMost);
            this.groupBox1.Controls.Add(this.rdoSolid);
            this.groupBox1.Controls.Add(this.rdo3D);
            this.groupBox1.Controls.Add(this.rdoWindow);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numMargin);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkTopMost
            // 
            resources.ApplyResources(this.chkTopMost, "chkTopMost");
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.UseVisualStyleBackColor = true;
            // 
            // rdoSolid
            // 
            resources.ApplyResources(this.rdoSolid, "rdoSolid");
            this.rdoSolid.Name = "rdoSolid";
            this.rdoSolid.TabStop = true;
            this.rdoSolid.UseVisualStyleBackColor = true;
            this.rdoSolid.CheckedChanged += new System.EventHandler(this.rdoWindow_CheckedChanged);
            // 
            // rdo3D
            // 
            resources.ApplyResources(this.rdo3D, "rdo3D");
            this.rdo3D.Name = "rdo3D";
            this.rdo3D.TabStop = true;
            this.rdo3D.UseVisualStyleBackColor = true;
            this.rdo3D.CheckedChanged += new System.EventHandler(this.rdoWindow_CheckedChanged);
            // 
            // rdoWindow
            // 
            resources.ApplyResources(this.rdoWindow, "rdoWindow");
            this.rdoWindow.Name = "rdoWindow";
            this.rdoWindow.TabStop = true;
            this.rdoWindow.UseVisualStyleBackColor = true;
            this.rdoWindow.CheckedChanged += new System.EventHandler(this.rdoWindow_CheckedChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // numMargin
            // 
            resources.ApplyResources(this.numMargin, "numMargin");
            this.numMargin.Name = "numMargin";
            this.numMargin.ValueChanged += new System.EventHandler(this.rdoWindow_CheckedChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.picPreview);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // picPreview
            // 
            resources.ApplyResources(this.picPreview, "picPreview");
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPreview.Name = "picPreview";
            this.picPreview.TabStop = false;
            this.picPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.picPreview_Paint);
            // 
            // MarginStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MarginStyleItemPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarginStyleItemPanel_FormClosed);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMargin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.PictureBox picPreview;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.NumericUpDown numMargin;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.RadioButton rdoWindow;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.RadioButton rdoSolid;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.RadioButton rdo3D;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.CheckBox chkTopMost;
	}
}
