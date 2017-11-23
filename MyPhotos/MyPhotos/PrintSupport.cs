using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using Manning.MyPhotoAlbum;

namespace MyPhotos
{
    static class PrintSupport
    {
        static private PrintDocument _printDoc;
        static private PrintDocument Document
        {
            get { return _printDoc; }
        }

        static PrintSupport()
        {
            _printDoc = new PrintDocument();
            _printDoc.PrintPage += printDoc_PrintPage;
        }

        static public void PageSetup()
        {
            PageSetupDialog dlg = new PageSetupDialog();
            dlg.Document = Document;
            dlg.ShowDialog();
        }

        static public void PrintPreview()
        {
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = Document;
            dlg.ShowDialog();
        }

        static public void Print()
        {
            PrintDialog dlg = new PrintDialog();
            dlg.Document = Document;
            if (dlg.ShowDialog() == DialogResult.OK)
                Document.Print();
        }

        static void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Form f = Application.OpenForms[0];
            if (f != null && f.IsMdiContainer)
                f = f.ActiveMdiChild;

            MainForm mf = f as MainForm;
            Photograph photo = null;
            if (mf != null && mf.Manager != null)
                photo = mf.Manager.Current;

            if (photo == null)
                e.Cancel = true;
            else
                PrintPhoto(photo, e);
        }

        static private void PrintPhoto(Photograph photo, PrintPageEventArgs e)
        {
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            float bottomMargin = e.MarginBounds.Bottom;
            float printableWidth = e.MarginBounds.Width;
            float printableHeight = e.MarginBounds.Height;
            Graphics g = e.Graphics;

            Font printFont = new Font("Times New Roman", 12);
            float fontHeight = printFont.GetHeight(g);
            float spaceWidth = g.MeasureString(" ", printFont).Width;
            float imageBoxLength;
            float xPos = leftMargin;
            float yPos = topMargin + fontHeight;
            if (printableWidth < printableHeight)
            {
                imageBoxLength = printableWidth * 75 / 100;
                yPos += imageBoxLength;
            }
            else
            {
                imageBoxLength = printableHeight * 75 / 100;
                xPos += imageBoxLength + spaceWidth;
            }

            Rectangle imageBox = new Rectangle((int)leftMargin + 1, (int)topMargin + 1,
                                               (int)imageBoxLength, (int)imageBoxLength);
            Rectangle targetBox = ImageUtility.ScaleToFit(photo.Image, imageBox);
            g.DrawImage(photo.Image, targetBox);

            RectangleF printArea = new RectangleF(xPos, yPos, rightMargin - xPos,
                                                              bottomMargin - yPos);

            PrintTextString(g, printFont, "FileName:", photo.FileName, ref printArea);
            PrintTextString(g, printFont, "Caption:", photo.Caption, ref printArea);
            PrintTextString(g, printFont, "Photographer:", photo.Photographer,
                            ref printArea);
            PrintTextString(g, printFont, "Notes:", photo.Notes, ref printArea);
        }

        static private void PrintTextString(Graphics g, Font printFont, string name,
                                            string text, ref RectangleF printArea)
        {
            float leftMargin = printArea.Left;
            float rightMargin = printArea.Right;
            float topMargin = printArea.Top;
            float bottomMargin = printArea.Bottom;
            float fontHeight = printFont.GetHeight(g);
            float xPos = printArea.Left;
            float yPos = topMargin + fontHeight;
            float spaceWidth = g.MeasureString(" ", printFont).Width;
            float nameWidth = g.MeasureString(name, printFont).Width;
            if (!printArea.Contains(xPos + nameWidth, yPos))
                throw new ApplicationException( "Print name does not fit");

            g.DrawString(name, printFont, Brushes.Black, new PointF(xPos, yPos));
            leftMargin += nameWidth + spaceWidth;
            xPos = leftMargin;

            string[] words = text.Split(" \r\t\n\0".ToCharArray());
            foreach (string word in words)
            {
                float wordWidth = g.MeasureString(word, printFont).Width;
                if (wordWidth == 0.0)
                    continue;
                if (xPos + wordWidth > rightMargin)
                {
                    xPos = leftMargin;
                    yPos += fontHeight;
                    if (yPos > bottomMargin)
                        break;
                }

                g.DrawString(word, printFont, Brushes.Black, new PointF(xPos, yPos));
                xPos += wordWidth;
            }

            printArea.Y = yPos;
            printArea.Height = bottomMargin - yPos;
        }
    }
}