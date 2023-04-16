namespace SETUNA.Main.StyleItems
{
	// Token: 0x0200008D RID: 141
	partial class MoveStyleItemPanel
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x0001DAFC File Offset: 0x0001BCFC
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numRight = new System.Windows.Forms.NumericUpDown();
            this.numLeft = new System.Windows.Forms.NumericUpDown();
            this.numDown = new System.Windows.Forms.NumericUpDown();
            this.numUp = new System.Windows.Forms.NumericUpDown();
            this.chkLeft = new System.Windows.Forms.CheckBox();
            this.chkRight = new System.Windows.Forms.CheckBox();
            this.chkUp = new System.Windows.Forms.CheckBox();
            this.chkDown = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUp)).BeginInit();
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
            this.groupBox1.Controls.Add(this.numRight);
            this.groupBox1.Controls.Add(this.numLeft);
            this.groupBox1.Controls.Add(this.numDown);
            this.groupBox1.Controls.Add(this.numUp);
            this.groupBox1.Controls.Add(this.chkLeft);
            this.groupBox1.Controls.Add(this.chkRight);
            this.groupBox1.Controls.Add(this.chkUp);
            this.groupBox1.Controls.Add(this.chkDown);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // numRight
            // 
            resources.ApplyResources(this.numRight, "numRight");
            this.numRight.Name = "numRight";
            // 
            // numLeft
            // 
            resources.ApplyResources(this.numLeft, "numLeft");
            this.numLeft.Name = "numLeft";
            // 
            // numDown
            // 
            resources.ApplyResources(this.numDown, "numDown");
            this.numDown.Name = "numDown";
            // 
            // numUp
            // 
            resources.ApplyResources(this.numUp, "numUp");
            this.numUp.Name = "numUp";
            // 
            // chkLeft
            // 
            resources.ApplyResources(this.chkLeft, "chkLeft");
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.UseVisualStyleBackColor = true;
            this.chkLeft.CheckedChanged += new System.EventHandler(this.chkLeft_CheckedChanged);
            // 
            // chkRight
            // 
            resources.ApplyResources(this.chkRight, "chkRight");
            this.chkRight.Name = "chkRight";
            this.chkRight.UseVisualStyleBackColor = true;
            this.chkRight.CheckedChanged += new System.EventHandler(this.chkRight_CheckedChanged);
            // 
            // chkUp
            // 
            resources.ApplyResources(this.chkUp, "chkUp");
            this.chkUp.Name = "chkUp";
            this.chkUp.UseVisualStyleBackColor = true;
            this.chkUp.CheckedChanged += new System.EventHandler(this.chkUp_CheckedChanged);
            // 
            // chkDown
            // 
            resources.ApplyResources(this.chkDown, "chkDown");
            this.chkDown.Name = "chkDown";
            this.chkDown.UseVisualStyleBackColor = true;
            this.chkDown.CheckedChanged += new System.EventHandler(this.chkDown_CheckedChanged);
            // 
            // MoveStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Name = "MoveStyleItemPanel";
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUp)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x040002C5 RID: 709
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040002C6 RID: 710
		private global::System.Windows.Forms.NumericUpDown numRight;

		// Token: 0x040002C7 RID: 711
		private global::System.Windows.Forms.NumericUpDown numLeft;

		// Token: 0x040002C8 RID: 712
		private global::System.Windows.Forms.NumericUpDown numDown;

		// Token: 0x040002C9 RID: 713
		private global::System.Windows.Forms.CheckBox chkRight;

		// Token: 0x040002CA RID: 714
		private global::System.Windows.Forms.CheckBox chkLeft;

		// Token: 0x040002CB RID: 715
		private global::System.Windows.Forms.CheckBox chkUp;

		// Token: 0x040002CC RID: 716
		private global::System.Windows.Forms.CheckBox chkDown;

		// Token: 0x040002CD RID: 717
		private global::System.Windows.Forms.NumericUpDown numUp;
	}
}
