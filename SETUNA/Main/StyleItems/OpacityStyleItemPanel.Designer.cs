namespace SETUNA.Main.StyleItems
{
	// Token: 0x0200008F RID: 143
	partial class OpacityStyleItemPanel
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpacityStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numPreview = new System.Windows.Forms.NumericUpDown();
            this.btnPreview = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.barOpacity2 = new System.Windows.Forms.TrackBar();
            this.barOpacity = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.numOpacity2 = new System.Windows.Forms.NumericUpDown();
            this.rdoIncrement = new System.Windows.Forms.RadioButton();
            this.rdoFixed = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOpacity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity2)).BeginInit();
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.barOpacity2);
            this.groupBox1.Controls.Add(this.barOpacity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numOpacity2);
            this.groupBox1.Controls.Add(this.rdoIncrement);
            this.groupBox1.Controls.Add(this.rdoFixed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numOpacity);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numPreview);
            this.groupBox2.Controls.Add(this.btnPreview);
            this.groupBox2.Controls.Add(this.picPreview);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // numPreview
            // 
            resources.ApplyResources(this.numPreview, "numPreview");
            this.numPreview.Name = "numPreview";
            this.numPreview.ValueChanged += new System.EventHandler(this.numPreview_ValueChanged);
            // 
            // btnPreview
            // 
            resources.ApplyResources(this.btnPreview, "btnPreview");
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // picPreview
            // 
            resources.ApplyResources(this.picPreview, "picPreview");
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPreview.Name = "picPreview";
            this.picPreview.TabStop = false;
            this.picPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.picPreview_Paint);
            // 
            // barOpacity2
            // 
            resources.ApplyResources(this.barOpacity2, "barOpacity2");
            this.barOpacity2.Name = "barOpacity2";
            this.barOpacity2.TickFrequency = 10;
            this.barOpacity2.Scroll += new System.EventHandler(this.barOpacity_Scroll);
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
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // numOpacity2
            // 
            resources.ApplyResources(this.numOpacity2, "numOpacity2");
            this.numOpacity2.Name = "numOpacity2";
            this.numOpacity2.ValueChanged += new System.EventHandler(this.numOpacity_ValueChanged);
            this.numOpacity2.Enter += new System.EventHandler(this.numOpacity_Enter);
            // 
            // rdoIncrement
            // 
            resources.ApplyResources(this.rdoIncrement, "rdoIncrement");
            this.rdoIncrement.Name = "rdoIncrement";
            this.rdoIncrement.UseVisualStyleBackColor = true;
            // 
            // rdoFixed
            // 
            resources.ApplyResources(this.rdoFixed, "rdoFixed");
            this.rdoFixed.Checked = true;
            this.rdoFixed.Name = "rdoFixed";
            this.rdoFixed.TabStop = true;
            this.rdoFixed.UseVisualStyleBackColor = true;
            this.rdoFixed.CheckedChanged += new System.EventHandler(this.rdoFixed_CheckedChanged);
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
            // OpacityStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "OpacityStyleItemPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpacityStyleItemPanel_FormClosed);
            this.Shown += new System.EventHandler(this.OpacityStyleItemPanel_Shown);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOpacity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x040002DA RID: 730
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040002DB RID: 731
		private global::System.Windows.Forms.RadioButton rdoIncrement;

		// Token: 0x040002DC RID: 732
		private global::System.Windows.Forms.RadioButton rdoFixed;

		// Token: 0x040002DD RID: 733
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002DE RID: 734
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002DF RID: 735
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002E0 RID: 736
		private global::System.Windows.Forms.NumericUpDown numOpacity2;

		// Token: 0x040002E1 RID: 737
		private global::System.Windows.Forms.TrackBar barOpacity;

		// Token: 0x040002E2 RID: 738
		private global::System.Windows.Forms.TrackBar barOpacity2;

		// Token: 0x040002E3 RID: 739
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040002E4 RID: 740
		private global::System.Windows.Forms.Button btnPreview;

		// Token: 0x040002E5 RID: 741
		private global::System.Windows.Forms.PictureBox picPreview;

		// Token: 0x040002E6 RID: 742
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040002E7 RID: 743
		private global::System.Windows.Forms.NumericUpDown numPreview;

		// Token: 0x040002E8 RID: 744
		private global::System.Windows.Forms.NumericUpDown numOpacity;
	}
}
