using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System;

namespace SETUNA.Main.StyleItems
{
    using SETUNA.Properties;

    public class CMaskStyleItem : CStyleItem
    {
        public CMaskStyleItem()
        {
            MaskMosaic = false;
            MaskSolid = false;
            MaskMonotone = false;
            MaskNoise = false;
            MaskBlur = false;
        }
        enum MASK_TYPE
        {
            SOLID,
            NOISE,
            GLAYOUT,
            MOSAIC,
            BLUR,
        }

        public override void Apply(ref ScrapBase scrap, Point clickpoint)
        {
            var mask_type = MASK_TYPE.MOSAIC;
            if (MaskMosaic)
            {
                mask_type = MASK_TYPE.MOSAIC;
            }
            else if (MaskSolid)
            {
                mask_type = MASK_TYPE.SOLID;
            }
            else if (MaskMonotone)
            {
                mask_type = MASK_TYPE.GLAYOUT;

            }
            else if (MaskNoise)
            {
                mask_type = MASK_TYPE.NOISE;
            }
            else if (MaskBlur)
            {
                mask_type = MASK_TYPE.BLUR;
            }

            using (var trimWindow = new TrimWindow(scrap))
            {
                if (trimWindow.ShowDialog() == DialogResult.OK)
                {
                    using (var bitmap = new Bitmap(scrap.Width, scrap.Height, PixelFormat.Format24bppRgb))
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        if (mask_type == MASK_TYPE.SOLID)
                        {
                            var color = Color.White;
                            var colorDialog1 = new ColorDialog();
                            colorDialog1.AnyColor = true;
                            colorDialog1.Color = color;
                            if (colorDialog1.ShowDialog() == DialogResult.OK)
                            {
                                color = colorDialog1.Color;
                            }
                            var rect = new Rectangle(trimWindow.TrimLeft, trimWindow.TrimTop, trimWindow.TrimRectangle.Width, trimWindow.TrimRectangle.Height);
                            Brush brush = new SolidBrush(color);
                            graphics.DrawImage(scrap.Image, 0, 0);
                            graphics.FillRectangle(brush, rect);
                        }
                        else
                        {
                            using (var rectBitmap = new Bitmap(trimWindow.TrimRectangle.Width, trimWindow.TrimRectangle.Height))
                            {
                                if (mask_type == MASK_TYPE.NOISE)
                                {
                                    CreateMaskRand(trimWindow, rectBitmap);
                                }
                                else if (mask_type == MASK_TYPE.MOSAIC)
                                {
                                    CreateMaskMosaic(trimWindow, rectBitmap, scrap);
                                }
                                else if (mask_type == MASK_TYPE.BLUR)
                                {
                                    CreateMaskBlur(trimWindow, rectBitmap, scrap);
                                }
                                else
                                {
                                    CreateMaskGray(trimWindow, rectBitmap, scrap);
                                }
                                graphics.DrawImage(scrap.Image, 0, 0);
                                graphics.DrawImage(rectBitmap, trimWindow.TrimLeft, trimWindow.TrimTop, rectBitmap.Width, rectBitmap.Height);
                            }
                        }
                        scrap.Image = bitmap;
                        scrap.Focus();
                    }
                }
            }
            scrap.Refresh();
        }

        private static void CreateMaskGray(TrimWindow trimWindow, Bitmap rectBitmap, ScrapBase scrap)
        {
            using (var myBitmap = new Bitmap(scrap.Image))
            {
                for (var y = 0; y < trimWindow.TrimRectangle.Height; y++)
                {
                    for (var x = 0; x < trimWindow.TrimRectangle.Width; x++)
                    {
                        var p = myBitmap.GetPixel(trimWindow.TrimLeft + x, trimWindow.TrimTop + y);
                        var na = p.A;
                        var nc = (p.R + p.G + p.B) / 3;
                        var c2 = Color.FromArgb(na, nc, nc, nc);
                        rectBitmap.SetPixel(x, y, c2);
                    }
                }
            }
        }

        private static void CreateMaskRand(TrimWindow trimWindow, Bitmap rectBitmap)
        {
            var rnd = new Random();
            for (var y = 0; y < trimWindow.TrimRectangle.Height; y++)
            {
                for (var x = 0; x < trimWindow.TrimRectangle.Width; x++)
                {
                    var c2 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    //img.SetPixel(rnd.Next(img.Width), rnd.Next(img.Height), c);
                    rectBitmap.SetPixel(x, y, c2);
                }
            }
        }

        private static void CreateMaskMosaic(TrimWindow trimWindow, Bitmap rectBitmap, ScrapBase scrap)
        {
            var upconvert_mode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            ApplyMask(trimWindow, rectBitmap, scrap, upconvert_mode);
        }

        private static void CreateMaskBlur(TrimWindow trimWindow, Bitmap rectBitmap, ScrapBase scrap)
        {
            var upconvert_mode = System.Drawing.Drawing2D.InterpolationMode.Low;
            ApplyMask(trimWindow, rectBitmap, scrap, upconvert_mode);
        }

        private static void ApplyMask(TrimWindow trimWindow, Bitmap rectBitmap, ScrapBase scrap, System.Drawing.Drawing2D.InterpolationMode upconvert_mode)
        {
            using (var myBitmap = new Bitmap(scrap.Image))
            {
                var rect = new Rectangle(trimWindow.TrimLeft, trimWindow.TrimTop, trimWindow.TrimRectangle.Width, trimWindow.TrimRectangle.Height);
                using (var bmp = myBitmap.Clone(rect, myBitmap.PixelFormat))
                {
                    var pixel_max_width = 5;
                    var resizeWidth = 0;
                    var resizeHeight = 0;
                    while (true)
                    {
                        resizeWidth = bmp.Width / pixel_max_width;
                        resizeHeight = (int)(bmp.Height * ((double)resizeWidth / (double)bmp.Width));
                        if (resizeWidth > 2 && resizeHeight > 2) break;
                        pixel_max_width -= 1;
                        if (pixel_max_width == 0) return;
                    }

                    using (var resizeBmp = new Bitmap(resizeWidth, resizeHeight))
                    {
                        using (var g = Graphics.FromImage(resizeBmp))
                        {
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            g.DrawImage(bmp, 0, 0, resizeWidth, resizeHeight);
                        }

                        using (var g2 = Graphics.FromImage(rectBitmap))
                        {
                            g2.InterpolationMode = upconvert_mode;
                            g2.DrawImage(resizeBmp, 0, 0, trimWindow.TrimRectangle.Width, trimWindow.TrimRectangle.Height);
                        }
                    }
                }
            }
        }

        public override string GetName()
        {
            return "Mask";
        }

        public override string GetDisplayName()
        {
            return "Mask"; // Properties.Resources.labe***;
        }

        public override string GetDescription()
        {
            return "Mask"; //Properties.Resources.label***;
        }

        protected override ToolBoxForm GetToolBoxForm()
        {
            return new MaskStyleItemPanel(this);
        }

        protected override void SetTunedStyleItem(CStyleItem newOwn)
        {
            var cmaskStyleItem = (CMaskStyleItem)newOwn;

            MaskMosaic = cmaskStyleItem.MaskMosaic;
            MaskSolid = cmaskStyleItem.MaskSolid;
            MaskMonotone = cmaskStyleItem.MaskMonotone;
            MaskNoise = cmaskStyleItem.MaskNoise;
            MaskBlur = cmaskStyleItem.MaskBlur;
        }

        public override bool IsTerminate => true;

        public override Bitmap GetIcon()
        {
            return Resources.Icon_Compact;
        }

        public bool MaskMosaic;
        public bool MaskSolid;
        public bool MaskMonotone;
        public bool MaskNoise;
        public bool MaskBlur;

    }
}
