﻿using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SETUNA.Main.StyleItems
{
    using System;
    using SETUNA.Main.Style;
    using SETUNA.Properties;

    // Token: 0x02000065 RID: 101
    public class CFillRectangleStyleItem : CStyleItem
    {
        // Token: 0x06000393 RID: 915 RVA: 0x00016110 File Offset: 0x00014310

        enum MASK_TYPE
        {
            SOLID,
            RANDOM,
            GLAYOUT,
            MOSAIC,
        }

        public override void Apply(ref ScrapBase scrap, Point clickpoint)
        {
            using (var trimWindow = new TrimWindow(scrap))
            {
                var mask_type = MASK_TYPE.MOSAIC;
                if (trimWindow.ShowDialog() == DialogResult.OK)
                {
                    using (var bitmap = new Bitmap(scrap.Width, scrap.Height, PixelFormat.Format24bppRgb))
                    using (var graphics = Graphics.FromImage(bitmap))
                    {

                        if (mask_type == MASK_TYPE.SOLID)
                        {
                            var c = Color.White;
                            var colorDialog1 = new ColorDialog();
                            colorDialog1.AnyColor = true;
                            colorDialog1.Color = c;
                            if (colorDialog1.ShowDialog() == DialogResult.OK)
                            {
                                c = colorDialog1.Color;
                            }
                            var rect = new Rectangle(trimWindow.TrimLeft, trimWindow.TrimTop, trimWindow.TrimRectangle.Width, trimWindow.TrimRectangle.Height);
                            Brush brush = new SolidBrush(c);
                            graphics.DrawImage(scrap.Image, 0, 0);
                            graphics.FillRectangle(brush, rect);
                        }
                        else
                        {
                            using (var rectBitmap = new Bitmap(trimWindow.TrimRectangle.Width, trimWindow.TrimRectangle.Height))
                            {
                                if (mask_type == MASK_TYPE.RANDOM)
                                {
                                    CreateMaskRand(trimWindow, rectBitmap);
                                }
                                else if (mask_type == MASK_TYPE.MOSAIC)
                                {
                                    CreateMaskMosaic(trimWindow, rectBitmap, scrap);
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

        private static void CreateMaskGray(TrimWindow trimWindow, Bitmap rectBitmap,  ScrapBase scrap)
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

        private static void CreateMaskMosaic(TrimWindow trimWindow, Bitmap rectBitmap,ScrapBase scrap)
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
                            g2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                            g2.DrawImage(resizeBmp, 0, 0, trimWindow.TrimRectangle.Width, trimWindow.TrimRectangle.Height);
                        }
                    }
                }
            }
        }

        // Token: 0x06000394 RID: 916 RVA: 0x0001622C File Offset: 0x0001442C
        public override string GetName()
        {
            return "FillRectangle";
        }

        // Token: 0x06000395 RID: 917 RVA: 0x00016233 File Offset: 0x00014433
        public override string GetDisplayName()
        {
            return "FillRectangle"; // Properties.Resources.label123;// "修剪";
        }

        // Token: 0x06000396 RID: 918 RVA: 0x0001623A File Offset: 0x0001443A
        public override string GetDescription()
        {
            return "FillRectangle"; // Properties.Resources.label124;// "您可以删除不需要的部分。";
        }

        // Token: 0x06000397 RID: 919 RVA: 0x00016241 File Offset: 0x00014441
        protected override ToolBoxForm GetToolBoxForm()
        {
            return new NothingStyleItemPanel(this);
        }

        // Token: 0x06000398 RID: 920 RVA: 0x00016249 File Offset: 0x00014449
        protected override void SetTunedStyleItem(CStyleItem newOwn)
        {
        }

        // Token: 0x06000399 RID: 921 RVA: 0x0001624B File Offset: 0x0001444B
        public override Bitmap GetIcon()
        {
            return Resources.Icon_Trim;
        }
    }
}
