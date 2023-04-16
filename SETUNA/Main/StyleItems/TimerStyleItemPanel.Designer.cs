namespace SETUNA.Main.StyleItems
{
	// Token: 0x02000096 RID: 150
	partial class TimerStyleItemPanel
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x0002349C File Offset: 0x0002169C
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numInterval);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // numInterval
            // 
            resources.ApplyResources(this.numInterval, "numInterval");
            this.numInterval.Name = "numInterval";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TimerStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Name = "TimerStyleItemPanel";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000330 RID: 816
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000331 RID: 817
		private global::System.Windows.Forms.NumericUpDown numInterval;

		// Token: 0x04000332 RID: 818
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000333 RID: 819
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
