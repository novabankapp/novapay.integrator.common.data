using IronBarCode;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.QRCodeGenerate
{
    public class IronQRCodeService : IQRCodeService
    {
        public async Task<byte[]> GenerateQRCode(string content, string filePath)
        {
            var barcode = QRCodeWriter.CreateQrCode(content);
            var result = barcode.SaveAsPng(filePath);
            return result.BinaryValue;
        }
        public async Task<byte[]> GenerateBarCode(string content, string filePath)
        {
            GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(content, BarcodeEncoding.Code128);
            var result = barcode.SaveAsPng(filePath);
            return result.BinaryValue;
        }
    }
}
