using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SETUNA.Main.StyleItems
{
    internal partial class MaskStyleItemPanel : ToolBoxForm
    {
        public MaskStyleItemPanel()
        {
        }

        public MaskStyleItemPanel(CMaskStyleItem item) : base(item)
        {
        }

        protected override void SetStyleToForm(object style)
        {
            var cmaskStyleItem = (CMaskStyleItem)style;
            InitializeComponent();
            Text = cmaskStyleItem.GetDisplayName();

            radioMosaic.Checked = cmaskStyleItem.MaskMosaic;
            radioSolid.Checked = cmaskStyleItem.MaskSolid;
            radioMonotone.Checked = cmaskStyleItem.MaskMonotone;
            radioNoise.Checked = cmaskStyleItem.MaskNoise;
            radioBlur.Checked = cmaskStyleItem.MaskBlur;
        }

        protected override object GetStyleFromForm()
        {
            return new CMaskStyleItem
            {
                MaskMonotone = radioMonotone.Checked,
                MaskMosaic = radioMosaic.Checked,
                MaskNoise = radioNoise.Checked,
                MaskSolid = radioSolid.Checked,
                MaskBlur = radioBlur.Checked,
            };
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioMonotone_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxMaskPreview.Image = Properties.Resources.Mask_monotone;
        }

        private void radioMosaic_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxMaskPreview.Image = Properties.Resources.Mask_mosaic;
        }

        private void radioSolid_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxMaskPreview.Image = Properties.Resources.Mask_solid;
        }

        private void radioNoise_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxMaskPreview.Image = Properties.Resources.Mask_noise;
        }

        private void radioBlur_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxMaskPreview.Image = Properties.Resources.Mask_blur;
        }
    }
}
