﻿// ****************************************************************** *'
//  Copyright - Accusoft Corporation, Tampa Florida.                  *'
//  This sample code is provided to Accusoft licensees "as is"        *'
//  with no restrictions on use or modification. No warranty for      *'
//  use of this sample code is provided by Accusoft.                  *'
//                                                                    *'
//  SAMPLE PURPOSE                                                    *'
//                                                                    *'
//  This sample illustrates how to specify barcode types to search    *'
//  for, acquire a Bitmap object, search for barcodes in a Bitmap,    *'
//  and retrieve returned barcode result data.                        *'
// ****************************************************************** *'

using System;
using System.Drawing;
using Accusoft.BarcodeXpressSdk;
using Newtonsoft.Json;

namespace ReadBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes an argument for an image path, then prints out any barcodes found on that image.
            string imagePath = (args.Length > 0) ? args[0] : "test-barcodes.bmp";
            // Search for specific types of barcodes in an image file (by default all 1D barcodes).
            // For the full list of options, see the API reference
            // at https://help.accusoft.com/BarcodeXpress/latest/BxNetCore/webframe.html#API_Reference.html
            using (BarcodeXpress barcodeXpress = new BarcodeXpress("."))
            using (Bitmap bitmap = new Bitmap(imagePath))
            {
                // Tell BarcodeXpress what types of barcodes you would like to search for.
                barcodeXpress.reader.BarcodeTypes = Enum.GetValues(typeof(BarcodeType));
                
                Accusoft.BarcodeXpressSdk.Result[] results = barcodeXpress.reader.Analyze(bitmap);

                Console.WriteLine("Results:");
                Console.WriteLine(JsonConvert.SerializeObject(results, Formatting.Indented));
            }
        }

    }
}
