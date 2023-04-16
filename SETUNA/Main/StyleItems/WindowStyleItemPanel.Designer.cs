namespace SETUNA.Main.StyleItems
{
	// Token: 0x0200007C RID: 124
	partial class WindowStyleItemPanel
	{
		// Token: 0x06000419 RID: 1049 RVA: 0x0001A354 File Offset: 0x00018554
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoIncrement = new System.Windows.Forms.RadioButton();
            this.rdoFixed = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.rdoIncrement);
            this.panel1.Controls.Add(this.rdoFixed);
            this.panel1.Name = "panel1";
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
            // 
            // WindowStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Name = "WindowStyleItemPanel";
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000270 RID: 624
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000271 RID: 625
		private global::System.Windows.Forms.RadioButton rdoIncrement;

		// Token: 0x04000272 RID: 626
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000273 RID: 627
		private global::System.Windows.Forms.RadioButton rdoFixed;
	}
}
