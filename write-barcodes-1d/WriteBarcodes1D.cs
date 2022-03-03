using Accusoft.BarcodeXpressSdk;
using System;
using System.Drawing;

namespace WriteBarcodes1D
{
    class WriteBarcodes1D
    {
        static void Main(string[] args)
        {
            // Search for specific types of barcodes in an image file (by default all 1D barcodes).
            // For the full list of options, see the API reference
            // at https://help.accusoft.com/BarcodeXpress/latest/BxNetCore/webframe.html#API_Reference.html
            using (BarcodeXpress bx = new BarcodeXpress("."))
            {
                // The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be
                // called to distribute the runtime.  Note that the SolutionName, SolutionKey and 
                // OEMLicenseKey values shown below are only examples.
                //bx.Licensing.SetSolutionName("YourSolutionName");
                //bx.Licensing.SetSolutionKey(1, 2, 3, 4);
                //bx.Licensing.SetOEMLicenseKey("2.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation...");

                // Set Barcode Type and Value from the command line arguments, defaulting to Code 39 if none are provided.
                bx.writer.BarcodeValue = (args.Length > 0) ? args[0] : "CODE39";
                bx.writer.BarcodeType = (args.Length > 1) ? (BarcodeType)Enum.Parse(typeof(BarcodeType), args[1]) : BarcodeType.Code39Barcode;

                // Create a Bitmap with Barcode Xpress.
                System.Drawing.Bitmap bitmap = bx.writer.CreateBitmap();

                // Save the created bitmap to a local file.
                bitmap.Save("testfile.bmp");
            }

            Console.WriteLine("Barcode image has been created successfully");
        }
    }
}
