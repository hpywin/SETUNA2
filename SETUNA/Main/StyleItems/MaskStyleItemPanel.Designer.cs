namespace SETUNA.Main.StyleItems
{
    // Token: 0x0200007A RID: 122
    partial class MaskStyleItemPanel
    {
        // Token: 0x060003F8 RID: 1016 RVA: 0x00019030 File Offset: 0x00017230
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaskStyleItemPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxMaskPreview = new System.Windows.Forms.PictureBox();
            this.radioNoise = new System.Windows.Forms.RadioButton();
            this.radioMonotone = new System.Windows.Forms.RadioButton();
            this.radioSolid = new System.Windows.Forms.RadioButton();
            this.radioMosaic = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.radioBlur = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaskPreview)).BeginInit();
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
            this.groupBox1.Controls.Add(this.radioBlur);
            this.groupBox1.Controls.Add(this.pictureBoxMaskPreview);
            this.groupBox1.Controls.Add(this.radioNoise);
            this.groupBox1.Controls.Add(this.radioMonotone);
            this.groupBox1.Controls.Add(this.radioSolid);
            this.groupBox1.Controls.Add(this.radioMosaic);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxMaskPreview
            // 
            this.pictureBoxMaskPreview.Image = global::SETUNA.Properties.Resources.Mask_org;
            resources.ApplyResources(this.pictureBoxMaskPreview, "pictureBoxMaskPreview");
            this.pictureBoxMaskPreview.Name = "pictureBoxMaskPreview";
            this.pictureBoxMaskPreview.TabStop = false;
            this.pictureBoxMaskPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // radioNoise
            // 
            resources.ApplyResources(this.radioNoise, "radioNoise");
            this.radioNoise.Name = "radioNoise";
            this.radioNoise.TabStop = true;
            this.radioNoise.UseVisualStyleBackColor = true;
            this.radioNoise.CheckedChanged += new System.EventHandler(this.radioNoise_CheckedChanged);
            // 
            // radioMonotone
            // 
            resources.ApplyResources(this.radioMonotone, "radioMonotone");
            this.radioMonotone.Name = "radioMonotone";
            this.radioMonotone.TabStop = true;
            this.radioMonotone.UseVisualStyleBackColor = true;
            this.radioMonotone.CheckedChanged += new System.EventHandler(this.radioMonotone_CheckedChanged);
            // 
            // radioSolid
            // 
            resources.ApplyResources(this.radioSolid, "radioSolid");
            this.radioSolid.Name = "radioSolid";
            this.radioSolid.TabStop = true;
            this.radioSolid.UseVisualStyleBackColor = true;
            this.radioSolid.CheckedChanged += new System.EventHandler(this.radioSolid_CheckedChanged);
            // 
            // radioMosaic
            // 
            resources.ApplyResources(this.radioMosaic, "radioMosaic");
            this.radioMosaic.Name = "radioMosaic";
            this.radioMosaic.TabStop = true;
            this.radioMosaic.UseVisualStyleBackColor = true;
            this.radioMosaic.CheckedChanged += new System.EventHandler(this.radioMosaic_CheckedChanged);
            // 
            // radioBlur
            // 
            resources.ApplyResources(this.radioBlur, "radioBlur");
            this.radioBlur.Name = "radioBlur";
            this.radioBlur.TabStop = true;
            this.radioBlur.UseVisualStyleBackColor = true;
            this.radioBlur.CheckedChanged += new System.EventHandler(this.radioBlur_CheckedChanged);
            // 
            // MaskStyleItemPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "MaskStyleItemPanel";
            this.Controls.SetChildIndex(this.cmdCancel, 0);
            this.Controls.SetChildIndex(this.cmdOK, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaskPreview)).EndInit();
            this.ResumeLayout(false);

        }

        // Token: 0x04000259 RID: 601
        private global::System.Windows.Forms.GroupBox groupBox1;

        // Token: 0x04000267 RID: 615
        private global::System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RadioButton radioMonotone;
        private System.Windows.Forms.RadioButton radioSolid;
        private System.Windows.Forms.RadioButton radioMosaic;
        private System.Windows.Forms.RadioButton radioNoise;
        private System.Windows.Forms.PictureBox pictureBoxMaskPreview;
        private System.Windows.Forms.RadioButton radioBlur;
    }
}
