namespace SETUNA.Main
{
	// Token: 0x02000051 RID: 81
	partial class HotkeyMsg
	{
		// Token: 0x06000307 RID: 775 RVA: 0x00014BEC File Offset: 0x00012DEC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00014C0C File Offset: 0x00012E0C
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeyMsg));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblKey
            // 
            resources.ApplyResources(this.lblKey, "lblKey");
            this.lblKey.Name = "lblKey";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::SETUNA.Properties.Resources.icon;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // HotkeyMsg
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HotkeyMsg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040001BB RID: 443
#pragma warning disable CS0649 // 从未对字段“HotkeyMsg.components”赋值，字段将一直保持其默认值 null
		private global::System.ComponentModel.IContainer components;
#pragma warning restore CS0649 // 从未对字段“HotkeyMsg.components”赋值，字段将一直保持其默认值 null

		// Token: 0x040001BC RID: 444
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001BD RID: 445
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001BE RID: 446
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x040001C0 RID: 448
		private global::System.Windows.Forms.Label lblKey;

		// Token: 0x040001C1 RID: 449
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
