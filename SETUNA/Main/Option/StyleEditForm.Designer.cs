namespace SETUNA.Main.Option
{
	// Token: 0x02000081 RID: 129
	partial class StyleEditForm
	{
		// Token: 0x0600043D RID: 1085 RVA: 0x0001AECB File Offset: 0x000190CB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0001AEEC File Offset: 0x000190EC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtStyleName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hotkey = new SETUNA.Main.HotkeyControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKeyDelete = new System.Windows.Forms.Button();
            this.listKeys = new System.Windows.Forms.ListBox();
            this.btnKeyEntry = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listStyleItem = new SETUNA.Main.StyleItemListBox();
            this.listAllStyleItem = new SETUNA.Main.StyleItemListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnItemDown = new System.Windows.Forms.Button();
            this.btnItemUp = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            // 
            // txtStyleName
            // 
            this.txtStyleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            resources.ApplyResources(this.txtStyleName, "txtStyleName");
            this.txtStyleName.Name = "txtStyleName";
            this.toolTip2.SetToolTip(this.txtStyleName, resources.GetString("txtStyleName.ToolTip"));
            this.txtStyleName.TextChanged += new System.EventHandler(this.txtStyleName_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Active = false;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "aaa";
            this.toolTip1.UseAnimation = false;
            this.toolTip1.UseFading = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtStyleName);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.btnCancel);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hotkey);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnKeyDelete);
            this.groupBox1.Controls.Add(this.listKeys);
            this.groupBox1.Controls.Add(this.btnKeyEntry);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // hotkey
            // 
            this.hotkey.Hotkey = System.Windows.Forms.Keys.None;
            resources.ApplyResources(this.hotkey, "hotkey");
            this.hotkey.Name = "hotkey";
            this.toolTip2.SetToolTip(this.hotkey, resources.GetString("hotkey.ToolTip"));
            this.toolTip1.SetToolTip(this.hotkey, resources.GetString("hotkey.ToolTip1"));
            this.hotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hotkey_KeyUp);
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
            // btnKeyDelete
            // 
            resources.ApplyResources(this.btnKeyDelete, "btnKeyDelete");
            this.btnKeyDelete.Name = "btnKeyDelete";
            this.btnKeyDelete.UseVisualStyleBackColor = true;
            this.btnKeyDelete.Click += new System.EventHandler(this.btnKeyDelete_Click);
            // 
            // listKeys
            // 
            this.listKeys.FormattingEnabled = true;
            resources.ApplyResources(this.listKeys, "listKeys");
            this.listKeys.Name = "listKeys";
            this.toolTip1.SetToolTip(this.listKeys, resources.GetString("listKeys.ToolTip"));
            this.toolTip2.SetToolTip(this.listKeys, resources.GetString("listKeys.ToolTip1"));
            // 
            // btnKeyEntry
            // 
            resources.ApplyResources(this.btnKeyEntry, "btnKeyEntry");
            this.btnKeyEntry.Name = "btnKeyEntry";
            this.btnKeyEntry.UseVisualStyleBackColor = true;
            this.btnKeyEntry.Click += new System.EventHandler(this.btnKeyEntry_Click);
            this.btnKeyEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotkey_KeyPress);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.listStyleItem);
            this.groupBox2.Controls.Add(this.listAllStyleItem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnItemDelete);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.btnItemDown);
            this.groupBox2.Controls.Add(this.btnItemUp);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // listStyleItem
            // 
            resources.ApplyResources(this.listStyleItem, "listStyleItem");
            this.listStyleItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listStyleItem.FormattingEnabled = true;
            this.listStyleItem.HelpFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listStyleItem.HelpForeColor = System.Drawing.Color.SteelBlue;
            this.listStyleItem.ItemDragMove = true;
            this.listStyleItem.ItemKeyDelete = true;
            this.listStyleItem.ItemLine = true;
            this.listStyleItem.ItemLineColor = System.Drawing.Color.LightSteelBlue;
            this.listStyleItem.Items.AddRange(new object[] {
            resources.GetString("listStyleItem.Items"),
            resources.GetString("listStyleItem.Items1"),
            resources.GetString("listStyleItem.Items2")});
            this.listStyleItem.LeftSpace = 34;
            this.listStyleItem.Name = "listStyleItem";
            this.listStyleItem.TerminateEnd = true;
            this.toolTip1.SetToolTip(this.listStyleItem, resources.GetString("listStyleItem.ToolTip"));
            this.toolTip2.SetToolTip(this.listStyleItem, resources.GetString("listStyleItem.ToolTip1"));
            this.listStyleItem.Click += new System.EventHandler(this.listAllStyleItem_Click);
            this.listStyleItem.DoubleClick += new System.EventHandler(this.listStyleItem_DoubleClick);
            // 
            // listAllStyleItem
            // 
            resources.ApplyResources(this.listAllStyleItem, "listAllStyleItem");
            this.listAllStyleItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listAllStyleItem.FormattingEnabled = true;
            this.listAllStyleItem.HelpFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listAllStyleItem.HelpForeColor = System.Drawing.Color.SteelBlue;
            this.listAllStyleItem.ItemDragMove = false;
            this.listAllStyleItem.ItemKeyDelete = false;
            this.listAllStyleItem.ItemLine = true;
            this.listAllStyleItem.ItemLineColor = System.Drawing.Color.LightSteelBlue;
            this.listAllStyleItem.Items.AddRange(new object[] {
            resources.GetString("listAllStyleItem.Items"),
            resources.GetString("listAllStyleItem.Items1"),
            resources.GetString("listAllStyleItem.Items2")});
            this.listAllStyleItem.LeftSpace = 34;
            this.listAllStyleItem.Name = "listAllStyleItem";
            this.listAllStyleItem.TerminateEnd = false;
            this.listAllStyleItem.Click += new System.EventHandler(this.listAllStyleItem_Click);
            this.listAllStyleItem.DoubleClick += new System.EventHandler(this.listAllStyleItem_DoubleClick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnItemDelete
            // 
            resources.ApplyResources(this.btnItemDelete, "btnItemDelete");
            this.btnItemDelete.Image = global::SETUNA.Properties.Resources.Close;
            this.btnItemDelete.Name = "btnItemDelete";
            this.toolTip1.SetToolTip(this.btnItemDelete, resources.GetString("btnItemDelete.ToolTip"));
            this.toolTip2.SetToolTip(this.btnItemDelete, resources.GetString("btnItemDelete.ToolTip1"));
            this.btnItemDelete.UseVisualStyleBackColor = true;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // btnInsert
            // 
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnItemDown
            // 
            resources.ApplyResources(this.btnItemDown, "btnItemDown");
            this.btnItemDown.Image = global::SETUNA.Properties.Resources.ArrowDown;
            this.btnItemDown.Name = "btnItemDown";
            this.toolTip1.SetToolTip(this.btnItemDown, resources.GetString("btnItemDown.ToolTip"));
            this.toolTip2.SetToolTip(this.btnItemDown, resources.GetString("btnItemDown.ToolTip1"));
            this.btnItemDown.UseVisualStyleBackColor = true;
            this.btnItemDown.Click += new System.EventHandler(this.btnItemDown_Click);
            // 
            // btnItemUp
            // 
            resources.ApplyResources(this.btnItemUp, "btnItemUp");
            this.btnItemUp.Image = global::SETUNA.Properties.Resources.ArrowUp;
            this.btnItemUp.Name = "btnItemUp";
            this.toolTip1.SetToolTip(this.btnItemUp, resources.GetString("btnItemUp.ToolTip"));
            this.toolTip2.SetToolTip(this.btnItemUp, resources.GetString("btnItemUp.ToolTip1"));
            this.btnItemUp.UseVisualStyleBackColor = true;
            this.btnItemUp.Click += new System.EventHandler(this.btnItemUp_Click);
            // 
            // StyleEditForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StyleEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Shown += new System.EventHandler(this.StyleEditForm_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000281 RID: 641
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000282 RID: 642
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000283 RID: 643
		private global::System.Windows.Forms.TextBox txtStyleName;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000285 RID: 645
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000286 RID: 646
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000287 RID: 647
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000288 RID: 648
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000289 RID: 649
		private global::System.Windows.Forms.Button btnKeyDelete;

		// Token: 0x0400028B RID: 651
		private global::System.Windows.Forms.ListBox listKeys;

		// Token: 0x0400028C RID: 652
		private global::System.Windows.Forms.Button btnKeyEntry;

		// Token: 0x0400028D RID: 653
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x0400028E RID: 654
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400028F RID: 655
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000290 RID: 656
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000291 RID: 657
		private global::SETUNA.Main.StyleItemListBox listStyleItem;

		// Token: 0x04000292 RID: 658
		private global::SETUNA.Main.StyleItemListBox listAllStyleItem;

		// Token: 0x04000293 RID: 659
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000294 RID: 660
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000295 RID: 661
		private global::System.Windows.Forms.Button btnItemDelete;

		// Token: 0x04000296 RID: 662
		private global::System.Windows.Forms.Button btnInsert;

		// Token: 0x04000297 RID: 663
		private global::System.Windows.Forms.Button btnItemDown;

		// Token: 0x04000298 RID: 664
		private global::System.Windows.Forms.Button btnItemUp;

		// Token: 0x04000299 RID: 665
		private global::System.Windows.Forms.ToolTip toolTip2;
        private HotkeyControl hotkey;
    }
}
