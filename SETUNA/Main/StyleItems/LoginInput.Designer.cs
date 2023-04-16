namespace SETUNA.Main.StyleItems
{
	// Token: 0x02000079 RID: 121
	partial class LoginInput
	{
		// Token: 0x060003F6 RID: 1014 RVA: 0x00018B97 File Offset: 0x00016D97
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00018BB8 File Offset: 0x00016DB8
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInput));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.Name = "txtPass";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // LoginInput
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LoginInput";
            this.Shown += new System.EventHandler(this.LoginInput_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000251 RID: 593
#pragma warning disable CS0649 // 从未对字段“LoginInput.components”赋值，字段将一直保持其默认值 null
		private global::System.ComponentModel.IContainer components;
#pragma warning restore CS0649 // 从未对字段“LoginInput.components”赋值，字段将一直保持其默认值 null

		// Token: 0x04000252 RID: 594
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000253 RID: 595
		private global::System.Windows.Forms.TextBox txtID;

		// Token: 0x04000254 RID: 596
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000255 RID: 597
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000256 RID: 598
		private global::System.Windows.Forms.TextBox txtPass;

		// Token: 0x04000257 RID: 599
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000258 RID: 600
		private global::System.Windows.Forms.Button btnOK;
	}
}
