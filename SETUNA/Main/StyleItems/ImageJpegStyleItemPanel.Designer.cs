namespace SETUNA.Main.StyleItems
{
	// Token: 0x02000092 RID: 146
	partial class ImageJpegStyleItemPanel
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x00021B04 File Offset: 0x0001FD04
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageJpegStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDupli = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoSaveAs = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoScrapName = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCopy = new System.Windows.Forms.CheckBox();
            this.chkWindow = new System.Windows.Forms.CheckBox();
            this.chkShowParam = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.barQuality = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRef = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barQuality)).BeginInit();
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
            this.groupBox1.Controls.Add(this.cmbDupli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoSaveAs);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.rdoScrapName);
            this.groupBox1.Controls.Add(this.rdoName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkCopy);
            this.groupBox1.Controls.Add(this.chkWindow);
            this.groupBox1.Controls.Add(this.chkShowParam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblQuality);
            this.groupBox1.Controls.Add(this.barQuality);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRef);
            this.groupBox1.Controls.Add(this.txtFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cmbDupli
            // 
            resources.ApplyResources(this.cmbDupli, "cmbDupli");
            this.cmbDupli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDupli.FormattingEnabled = true;
            this.cmbDupli.Items.AddRange(new object[] {
            resources.GetString("cmbDupli.Items"),
            resources.GetString("cmbDupli.Items1"),
            resources.GetString("cmbDupli.Items2")});
            this.cmbDupli.Name = "cmbDupli";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rdoSaveAs
            // 
            resources.ApplyResources(this.rdoSaveAs, "rdoSaveAs");
            this.rdoSaveAs.Name = "rdoSaveAs";
            this.rdoSaveAs.TabStop = true;
            this.rdoSaveAs.UseVisualStyleBackColor = true;
            this.rdoSaveAs.CheckedChanged += new System.EventHandler(this.rdoSaveAs_CheckedChanged);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // rdoScrapName
            // 
            resources.ApplyResources(this.rdoScrapName, "rdoScrapName");
            this.rdoScrapName.Name = "rdoScrapName";
            this.rdoScrapName.TabStop = true;
            this.rdoScrapName.UseVisualStyleBackColor = true;
            this.rdoScrapName.CheckedChanged += new System.EventHandler(this.rdoSaveAs_CheckedChanged);
            // 
            // rdoName
            // 
            resources.ApplyResources(this.rdoName, "rdoName");
            this.rdoName.Name = "rdoName";
            this.rdoName.TabStop = true;
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoSaveAs_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // chkCopy
            // 
            resources.ApplyResources(this.chkCopy, "chkCopy");
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.UseVisualStyleBackColor = true;
            // 
            // chkWindow
            // 
            resources.ApplyResources(this.chkWindow, "chkWindow");
            this.chkWindow.Name = "chkWindow";
            this.chkWindow.UseVisualStyleBackColor = true;
            // 
            // chkShowParam
            // 
            resources.ApplyResources(this.chkShowParam, "chkShowParam");
            this.chkShowParam.Checked = true;
            this.chkShowParam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowParam.Name = "chkShowParam";
            this.chkShowParam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblQuality
            // 
            resources.ApplyResources(this.lblQuality, "lblQuality");
            this.lblQuality.Name = "lblQuality";
            // 
            // barQuality
            // 
            resources.ApplyResources(this.barQuality, "barQuality");
            this.barQuality.Maximum = 100;
            this.barQuality.Name = "barQuality";
            this.barQuality.TickFrequency = 10;
            this.barQuality.Value = 100;
            this.barQuality.Scroll += new System.EventHandler(this.barQuality_Scroll);
            this.barQuality.ValueChanged += new System.EventHandler(this.barQuality_Scroll);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnRef
            // 
            resources.ApplyResources(this.btnRef, "btnRef");
            this.btnRef.Name = "btnRef";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // txtFolder
            // 
            resources.ApplyResources(this.txtFolder, "txtFolder");
            this.txtFolder.Name = "txtFolder";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            // 
            // ImageJpegStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Name = "ImageJpegStyleItemPanel";
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barQuality)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x0400030D RID: 781
		private global::System.Windows.Forms.Button btnRef;

		// Token: 0x0400030E RID: 782
		private global::System.Windows.Forms.TextBox txtFolder;

		// Token: 0x0400030F RID: 783
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000310 RID: 784
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x04000311 RID: 785
		private global::System.Windows.Forms.TrackBar barQuality;

		// Token: 0x04000312 RID: 786
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000313 RID: 787
		private global::System.Windows.Forms.CheckBox chkShowParam;

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000315 RID: 789
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.Forms.Label lblQuality;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Forms.CheckBox chkWindow;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.CheckBox chkCopy;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Forms.ComboBox cmbDupli;

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400031B RID: 795
		private global::System.Windows.Forms.RadioButton rdoSaveAs;

		// Token: 0x0400031C RID: 796
		private global::System.Windows.Forms.TextBox txtName;

		// Token: 0x0400031D RID: 797
		private global::System.Windows.Forms.RadioButton rdoScrapName;

		// Token: 0x0400031E RID: 798
		private global::System.Windows.Forms.RadioButton rdoName;

		// Token: 0x0400031F RID: 799
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000320 RID: 800
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
