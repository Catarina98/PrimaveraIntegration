using System.Drawing;
using QRCodeDecoderLibrary;

namespace QRCode.Reader
{
    public interface IQrCodeReader
    {
        string ReadQrCode(string imagePath);
    }

    public class QrCodeReader : IQrCodeReader
    {
        private readonly QRDecoder decoder;

        public QrCodeReader()
        {
            // create QR Code decoder object
            this.decoder = new QRDecoder();
        }

        public string ReadQrCode(string imagePath)
        {
            // load image to bitmap
            var qrCodeInputImage = new Bitmap(imagePath);
                
                
            // decode image
            var dataByteArray = decoder.ImageDecoder(qrCodeInputImage);

            // convert binary result to text string
            var result = QRDecoder.ByteArrayToStr(dataByteArray[0]);
            return result;
        }
    }
}
