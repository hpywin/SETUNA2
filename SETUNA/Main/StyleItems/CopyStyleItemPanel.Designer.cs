namespace SETUNA.Main.StyleItems
{
	// Token: 0x02000012 RID: 18
	partial class CopyStyleItemPanel
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00006664 File Offset: 0x00004864
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkWindow = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.chkWindow);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkWindow
            // 
            resources.ApplyResources(this.chkWindow, "chkWindow");
            this.chkWindow.Name = "chkWindow";
            this.chkWindow.UseVisualStyleBackColor = true;
            // 
            // CopyStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Name = "CopyStyleItemPanel";
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.CheckBox chkWindow;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
