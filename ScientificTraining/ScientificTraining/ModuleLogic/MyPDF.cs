using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
//用户自定义
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ModuleLogic
{
    public class MyPDF
    {
        private void CreateImage(Grid grid, int dpi, string filename)
        {
            var rtb = new RenderTargetBitmap(1920, 768, dpi, dpi, PixelFormats.Pbgra32);
            rtb.Render(grid);
            var enc = new PngBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(rtb));

            using (var stream = File.Create(filename))
            {
                enc.Save(stream);
            }
        }

        public void CreatePDF(Grid grid, string saveImage, string savePdf)
        {
            CreateImage(grid, 96, saveImage);

            PdfDocument doc = new PdfDocument();
            doc.Pages.Add(new PdfPage());
            doc.Pages[0].Width = 1920;
            doc.Pages[0].Height = 768;
            XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[0]);
            XImage img = XImage.FromFile(saveImage);
            xgr.DrawImage(img, 80, 0);
            doc.Save(savePdf);
            doc.Close();
        }
    }
}
