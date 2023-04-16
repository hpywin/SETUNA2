namespace SETUNA.Main.StyleItems
{
	// Token: 0x020000B2 RID: 178
	partial class SaveImageStyleItemPanel
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x0002658C File Offset: 0x0002478C
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveImageStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPng = new System.Windows.Forms.TabPage();
            this.tabJpeg = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblJpegQuality = new System.Windows.Forms.Label();
            this.barJpegQuality = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tabBmp = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabJpeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barJpegQuality)).BeginInit();
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
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPng);
            this.tabControl1.Controls.Add(this.tabJpeg);
            this.tabControl1.Controls.Add(this.tabBmp);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPng
            // 
            resources.ApplyResources(this.tabPng, "tabPng");
            this.tabPng.Name = "tabPng";
            this.tabPng.UseVisualStyleBackColor = true;
            // 
            // tabJpeg
            // 
            resources.ApplyResources(this.tabJpeg, "tabJpeg");
            this.tabJpeg.Controls.Add(this.label5);
            this.tabJpeg.Controls.Add(this.label4);
            this.tabJpeg.Controls.Add(this.lblJpegQuality);
            this.tabJpeg.Controls.Add(this.barJpegQuality);
            this.tabJpeg.Controls.Add(this.label2);
            this.tabJpeg.Name = "tabJpeg";
            this.tabJpeg.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblJpegQuality
            // 
            resources.ApplyResources(this.lblJpegQuality, "lblJpegQuality");
            this.lblJpegQuality.Name = "lblJpegQuality";
            // 
            // barJpegQuality
            // 
            resources.ApplyResources(this.barJpegQuality, "barJpegQuality");
            this.barJpegQuality.Maximum = 100;
            this.barJpegQuality.Name = "barJpegQuality";
            this.barJpegQuality.TickFrequency = 10;
            this.barJpegQuality.Scroll += new System.EventHandler(this.barJpegQuality_Scroll);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tabBmp
            // 
            resources.ApplyResources(this.tabBmp, "tabBmp");
            this.tabBmp.Name = "tabBmp";
            this.tabBmp.UseVisualStyleBackColor = true;
            // 
            // SaveImageStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Name = "SaveImageStyleItemPanel";
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabJpeg.ResumeLayout(false);
            this.tabJpeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barJpegQuality)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000385 RID: 901
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000386 RID: 902
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000387 RID: 903
		private global::System.Windows.Forms.TabPage tabPng;

		// Token: 0x04000388 RID: 904
		private global::System.Windows.Forms.TabPage tabJpeg;

		// Token: 0x04000389 RID: 905
		private global::System.Windows.Forms.TabPage tabBmp;

		// Token: 0x0400038A RID: 906
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400038B RID: 907
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400038C RID: 908
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400038D RID: 909
		private global::System.Windows.Forms.Label lblJpegQuality;

		// Token: 0x0400038E RID: 910
		private global::System.Windows.Forms.TrackBar barJpegQuality;

		// Token: 0x0400038F RID: 911
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000390 RID: 912
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000391 RID: 913
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000392 RID: 914
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x04000393 RID: 915
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
