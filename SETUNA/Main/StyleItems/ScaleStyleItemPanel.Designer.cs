namespace SETUNA.Main.StyleItems
{
	// Token: 0x0200008E RID: 142
	partial class ScaleStyleItemPanel
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x0001E580 File Offset: 0x0001C780
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInterpolation = new System.Windows.Forms.Label();
            this.cmbInterpolation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numRelativeScale = new System.Windows.Forms.NumericUpDown();
            this.barRelative = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.barFixed = new System.Windows.Forms.TrackBar();
            this.rdoIncrement = new System.Windows.Forms.RadioButton();
            this.rdoFixed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numFixedScale = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRelativeScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRelative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barFixed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedScale)).BeginInit();
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
            this.groupBox1.Controls.Add(this.lblInterpolation);
            this.groupBox1.Controls.Add(this.cmbInterpolation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numRelativeScale);
            this.groupBox1.Controls.Add(this.barRelative);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.barFixed);
            this.groupBox1.Controls.Add(this.rdoIncrement);
            this.groupBox1.Controls.Add(this.rdoFixed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numFixedScale);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblInterpolation
            // 
            resources.ApplyResources(this.lblInterpolation, "lblInterpolation");
            this.lblInterpolation.Name = "lblInterpolation";
            // 
            // cmbInterpolation
            // 
            resources.ApplyResources(this.cmbInterpolation, "cmbInterpolation");
            this.cmbInterpolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterpolation.FormattingEnabled = true;
            this.cmbInterpolation.Name = "cmbInterpolation";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // numRelativeScale
            // 
            resources.ApplyResources(this.numRelativeScale, "numRelativeScale");
            this.numRelativeScale.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numRelativeScale.Name = "numRelativeScale";
            this.numRelativeScale.ValueChanged += new System.EventHandler(this.numFixedScale_ValueChanged);
            // 
            // barRelative
            // 
            resources.ApplyResources(this.barRelative, "barRelative");
            this.barRelative.Maximum = 190;
            this.barRelative.Minimum = -190;
            this.barRelative.Name = "barRelative";
            this.barRelative.TickFrequency = 20;
            this.barRelative.Scroll += new System.EventHandler(this.barFixed_Scroll);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // barFixed
            // 
            resources.ApplyResources(this.barFixed, "barFixed");
            this.barFixed.Maximum = 200;
            this.barFixed.Minimum = 10;
            this.barFixed.Name = "barFixed";
            this.barFixed.TickFrequency = 10;
            this.barFixed.Value = 100;
            this.barFixed.Scroll += new System.EventHandler(this.barFixed_Scroll);
            // 
            // rdoIncrement
            // 
            resources.ApplyResources(this.rdoIncrement, "rdoIncrement");
            this.rdoIncrement.Name = "rdoIncrement";
            this.rdoIncrement.UseVisualStyleBackColor = true;
            this.rdoIncrement.CheckedChanged += new System.EventHandler(this.rdoFixed_CheckedChanged);
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numFixedScale
            // 
            resources.ApplyResources(this.numFixedScale, "numFixedScale");
            this.numFixedScale.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numFixedScale.Name = "numFixedScale";
            this.numFixedScale.ValueChanged += new System.EventHandler(this.numFixedScale_ValueChanged);
            // 
            // ScaleStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Name = "ScaleStyleItemPanel";
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRelativeScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRelative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barFixed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedScale)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x040002CE RID: 718
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040002CF RID: 719
		private global::System.Windows.Forms.RadioButton rdoIncrement;

		// Token: 0x040002D0 RID: 720
		private global::System.Windows.Forms.RadioButton rdoFixed;

		// Token: 0x040002D1 RID: 721
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002D2 RID: 722
		private global::System.Windows.Forms.TrackBar barFixed;

		// Token: 0x040002D3 RID: 723
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002D4 RID: 724
		private global::System.Windows.Forms.TrackBar barRelative;

		// Token: 0x040002D5 RID: 725
		private global::System.Windows.Forms.Label lblInterpolation;

		// Token: 0x040002D6 RID: 726
		private global::System.Windows.Forms.ComboBox cmbInterpolation;

		// Token: 0x040002D7 RID: 727
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002D8 RID: 728
		private global::System.Windows.Forms.NumericUpDown numRelativeScale;

		// Token: 0x040002D9 RID: 729
		private global::System.Windows.Forms.NumericUpDown numFixedScale;
	}
}
