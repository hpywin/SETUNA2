using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SETUNA.Main.StyleItems
{
    using System;
    using SETUNA.Properties;

    // Token: 0x02000065 RID: 101
    public class CFillRectangleStyleItem : CStyleItem
    {
        // Token: 0x06000393 RID: 915 RVA: 0x00016110 File Offset: 0x00014310
        public override void Apply(ref ScrapBase scrap, Point clickpoint)
        {
            using (var trimWindow = new TrimWindow(scrap))
            {
                var rnd = new Random();
                var isSolid = false;
                var isRandom = true;
                var c = Color.White;
                if (trimWindow.ShowDialog() == DialogResult.OK)
                {
                    if (isSolid)
                    {
                        var colorDialog1 = new ColorDialog();
                        colorDialog1.AnyColor = true;
                        colorDialog1.Color = c;
                        if (colorDialog1.ShowDialog() == DialogResult.OK)
                        {
                            c = colorDialog1.Color;
                        }
                    }

                    using (var rectBitmap = new Bitmap(trimWindow.TrimRectangle.Width, trimWindow.TrimRectangle.Height))
                    using (var bitmap = new Bitmap(scrap.Width, scrap.Height, PixelFormat.Format24bppRgb))
                    {
                        if (!isSolid)
                        {
                            using (var myBitmap = new Bitmap(scrap.Image))
                            {
                                for (var y = 0; y < trimWindow.TrimRectangle.Height; y++)
                                {
                                    for (var x = 0; x < trimWindow.TrimRectangle.Width; x++)
                                    {

                                        if (isRandom)
                                        {
                                            //random color
                                            c = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                                        }
                                        else
                                        {
                                            //gray scale
                                            var p = myBitmap.GetPixel(trimWindow.TrimLeft + x, trimWindow.TrimTop + y);
                                            var na = p.A;
                                            var nc = (p.R + p.G + p.B) / 3;
                                            c = Color.FromArgb(na, nc, nc, nc); //p.A, p.R, p.G, p.B);//
                                        }
                                        //img.SetPixel(rnd.Next(img.Width), rnd.Next(img.Height), c);
                                        rectBitmap.SetPixel(x, y, c);
                                    }
                                }
                            }
                        }

                        using (var graphics = Graphics.FromImage(bitmap))
                        {
                            graphics.DrawImage(scrap.Image, 0, 0);
                            if (isSolid)
                            {
                                var rect = new Rectangle(trimWindow.TrimLeft, trimWindow.TrimTop, trimWindow.TrimRectangle.Width, trimWindow.TrimRectangle.Height);
                                Brush brush = new SolidBrush(c);
                                graphics.FillRectangle(brush, rect);
                            }
                            else
                            {
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
