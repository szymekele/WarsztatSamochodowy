using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public static class AppBranding
    {
        private static Icon cachedIcon = null;

        /// <summary>
        /// Generuje i buforuje dynamiczną ikonę aplikacji w stylu Dark Slate z monogramem WDB.
        /// </summary>
        public static Icon AppIcon
        {
            get
            {
                if (cachedIcon == null)
                {
                    try
                    {
                        using (Bitmap bmp = new Bitmap(48, 48))
                        {
                            using (Graphics g = Graphics.FromImage(bmp))
                            {
                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                                // Zaokrąglone tło
                                using (SolidBrush brushBg = new SolidBrush(Color.FromArgb(15, 23, 42))) // #0F172A
                                {
                                    g.FillEllipse(brushBg, 2, 2, 44, 44);
                                }

                                // Obwódka
                                using (Pen penBorder = new Pen(Color.FromArgb(37, 99, 235), 3f)) // #2563EB
                                {
                                    g.DrawEllipse(penBorder, 3, 3, 42, 42);
                                }

                                // Monogram "W"
                                using (Font font = new Font("Segoe UI", 16f, FontStyle.Bold, GraphicsUnit.Pixel))
                                using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(96, 165, 250))) // #60A5FA
                                {
                                    StringFormat sf = new StringFormat
                                    {
                                        Alignment = StringAlignment.Center,
                                        LineAlignment = StringAlignment.Center
                                    };
                                    g.DrawString("W", font, textBrush, new RectangleF(0, 0, 48, 48), sf);
                                }
                            }
                            IntPtr hIcon = bmp.GetHicon();
                            cachedIcon = Icon.FromHandle(hIcon);
                        }
                    }
                    catch
                    {
                        // Fallback jeśli platforma nie pozwala na GetHicon
                        cachedIcon = SystemIcons.Application;
                    }
                }
                return cachedIcon;
            }
        }

        /// <summary>
        /// Przypisuje unikalną ikonę aplikacji do zadanego formularza.
        /// </summary>
        public static void ApplyWindowIcon(Form form)
        {
            if (form == null)
                return;

            try
            {
                form.Icon = AppIcon;
                form.ShowIcon = true;
            }
            catch
            {
            }
        }
    }
}
