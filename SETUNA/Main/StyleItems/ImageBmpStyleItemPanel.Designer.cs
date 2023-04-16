namespace SETUNA.Main.StyleItems
{
	// Token: 0x0200008A RID: 138
	partial class ImageBmpStyleItemPanel
	{
		// Token: 0x06000479 RID: 1145 RVA: 0x0001CCB8 File Offset: 0x0001AEB8
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageBmpStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDupli = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoSaveAs = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoScrapName = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCopy = new System.Windows.Forms.CheckBox();
            this.chkWindow = new System.Windows.Forms.CheckBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
            this.groupBox1.Controls.Add(this.cmbDupli);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdoSaveAs);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.rdoScrapName);
            this.groupBox1.Controls.Add(this.rdoName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkCopy);
            this.groupBox1.Controls.Add(this.chkWindow);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // ImageBmpStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Name = "ImageBmpStyleItemPanel";
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x040002B4 RID: 692
		private global::System.Windows.Forms.Button btnRef;

		// Token: 0x040002B5 RID: 693
		private global::System.Windows.Forms.TextBox txtFolder;

		// Token: 0x040002B6 RID: 694
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002B7 RID: 695
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x040002B8 RID: 696
		private global::System.Windows.Forms.CheckBox chkWindow;

		// Token: 0x040002B9 RID: 697
		private global::System.Windows.Forms.CheckBox chkCopy;

		// Token: 0x040002BA RID: 698
		private global::System.Windows.Forms.RadioButton rdoScrapName;

		// Token: 0x040002BB RID: 699
		private global::System.Windows.Forms.RadioButton rdoName;

		// Token: 0x040002BC RID: 700
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002BD RID: 701
		private global::System.Windows.Forms.RadioButton rdoSaveAs;

		// Token: 0x040002BE RID: 702
		private global::System.Windows.Forms.TextBox txtName;

		// Token: 0x040002BF RID: 703
		private global::System.Windows.Forms.ComboBox cmbDupli;

		// Token: 0x040002C0 RID: 704
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002C1 RID: 705
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
