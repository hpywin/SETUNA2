namespace SETUNA.Main.StyleItems
{
	// Token: 0x0200000B RID: 11
	partial class NothingStyleItemPanel
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00004CCC File Offset: 0x00002ECC
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NothingStyleItemPanel));
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NothingStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label1);
            this.Name = "NothingStyleItemPanel";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label label1;
	}
}
