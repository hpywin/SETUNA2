namespace SETUNA.Main.StyleItems
{
	// Token: 0x02000028 RID: 40
	partial class LayerRenameWindow
	{
		// Token: 0x0600019F RID: 415 RVA: 0x0000961C File Offset: 0x0000781C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000963C File Offset: 0x0000783C
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayerRenameWindow));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtLayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.errorProvider1.SetError(this.btnOK, resources.GetString("btnOK.Error"));
            this.errorProvider1.SetIconAlignment(this.btnOK, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOK.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnOK, ((int)(resources.GetObject("btnOK.IconPadding"))));
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtLayerName
            // 
            resources.ApplyResources(this.txtLayerName, "txtLayerName");
            this.errorProvider1.SetError(this.txtLayerName, resources.GetString("txtLayerName.Error"));
            this.errorProvider1.SetIconAlignment(this.txtLayerName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLayerName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtLayerName, ((int)(resources.GetObject("txtLayerName.IconPadding"))));
            this.txtLayerName.Name = "txtLayerName";
            this.txtLayerName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // LayerRenameWindow
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLayerName);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LayerRenameWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040000BE RID: 190
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.TextBox txtLayerName;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
