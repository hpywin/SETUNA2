namespace SETUNA
{
	// Token: 0x02000037 RID: 55
	sealed partial class Mainform
	{
		// Token: 0x060001EC RID: 492 RVA: 0x0000A164 File Offset: 0x00008364
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A184 File Offset: 0x00008384
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timPool = new System.Windows.Forms.Timer(this.components);
            this.windowTimer = new System.Windows.Forms.Timer(this.components);
            this.setunaIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.setunaIconMenu = new SETUNA.Main.ContextStyleMenuStrip(this.components);
            this.subMenu = new SETUNA.Main.ContextStyleMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.delayInitTimer = new System.Windows.Forms.Timer(this.components);
            this.subMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.Gray;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timPool
            // 
            this.timPool.Tick += new System.EventHandler(this.timPool_Tick);
            // 
            // windowTimer
            // 
            this.windowTimer.Enabled = true;
            this.windowTimer.Interval = 500;
            this.windowTimer.Tick += new System.EventHandler(this.window_Tick);
            // 
            // setunaIcon
            // 
            this.setunaIcon.ContextMenuStrip = this.setunaIconMenu;
            resources.ApplyResources(this.setunaIcon, "setunaIcon");
            this.setunaIcon.DoubleClick += new System.EventHandler(this.setunaIcon_MouseDoubleClick);
            this.setunaIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.setunaIcon_MouseClick);
            // 
            // setunaIconMenu
            // 
            this.setunaIconMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.setunaIconMenu.Name = "setunaIconMenu";
            this.setunaIconMenu.Scrap = null;
            resources.ApplyResources(this.setunaIconMenu, "setunaIconMenu");
            this.setunaIconMenu.Opening += new System.ComponentModel.CancelEventHandler(this.setunaIconMenu_Opening);
            // 
            // subMenu
            // 
            this.subMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.subMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.subMenu.Name = "subMenu";
            this.subMenu.Scrap = null;
            resources.ApplyResources(this.subMenu, "subMenu");
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            resources.ApplyResources(this.testToolStripMenuItem, "testToolStripMenuItem");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // delayInitTimer
            // 
            this.delayInitTimer.Interval = 1000;
            this.delayInitTimer.Tick += new System.EventHandler(this.delayInitTimer_Tick);
            // 
            // Mainform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.ContextMenuStrip = this.setunaIconMenu;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.Shown += new System.EventHandler(this.Mainform_Shown);
            this.subMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x040000D8 RID: 216
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.NotifyIcon setunaIcon;

		// Token: 0x040000DC RID: 220
		private global::SETUNA.Main.ContextStyleMenuStrip setunaIconMenu;

		// Token: 0x040000DD RID: 221
		private global::SETUNA.Main.ContextStyleMenuStrip subMenu;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Timer timPool;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.ToolTip toolTip1;

        private global::System.Windows.Forms.Timer windowTimer;
        private System.Windows.Forms.Timer delayInitTimer;
    }
}
