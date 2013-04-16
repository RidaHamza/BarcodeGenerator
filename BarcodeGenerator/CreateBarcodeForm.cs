using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IDAutomation_FontEncoder;

namespace BarcodeGenerator
{
    public partial class CreateBarcodeForm : Form
    {
        private Int32 barcodeHeight = 100, barcodeWidth = 600;
        private Bitmap bmpBarcode;

        public CreateBarcodeForm()
        {
            InitializeComponent();
            bmpBarcode = new Bitmap(barcodeWidth, barcodeHeight);
            bmpBarcode.SetResolution(100, 100);
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (StringToConvertTextBox.Text == "") return;
            // draw the barcode and text to the bitmap
            clsBarCode barcodeGenerator = new clsBarCode();
            String barcodeReadyData = barcodeGenerator.Code128(StringToConvertTextBox.Text, false);
            using (Font drawFont = new Font("IDAutomationC128XS", 24), readableFont = new Font("Arial", 12))
            {
                using (SolidBrush drawBrush = new SolidBrush(Color.Black))
                {
                    using (Graphics dc = Graphics.FromImage(bmpBarcode))
                    {
                        // paint the whole bitmap white
                        dc.FillRectangle(new SolidBrush(Color.White), new RectangleF(0, 0, bmpBarcode.Width, bmpBarcode.Height));
                        // draw the barcode
                        dc.DrawString(barcodeReadyData, drawFont, drawBrush, new RectangleF(0, 0, barcodeWidth, barcodeHeight - 70));
                        // draw the human readable
                        dc.DrawString(StringToConvertTextBox.Text, readableFont, drawBrush, new RectangleF(0, 30, barcodeWidth, barcodeHeight));
                    }
                }
            }
            BarcodePictureBox.Image = bmpBarcode;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bmpBarcode.Save(FileNameToSaveTextBox.Text);
        }

        private void ToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(BarcodePictureBox.Image, true);
        }
    }
}
