# Hello Barcode Xpress for .NET Core

A minimal [Barcode Xpress for .NET Core](https://www.nuget.org/packages/Accusoft.BarcodeXpress.NetCore/)
application which detects barcodes on a given bitmap image.

## Requirements

For the list of requirements to run the sample,
refer to the [Barcode Xpress for .NET Core help](https://help.accusoft.com/BarcodeXpress/latest/BxNetCore/webframe.html#system-requirements.html).

## Running the Sample

Start the app:

    dotnet run

This will run the sample and you should see output like this:

    Results:
    [
      {
        "Area": "496, 81, 646, 99",
        "Point1": "496, 81",
        "Point2": "1142, 82",
        "Point3": "1142, 180",
        "Point4": "496, 180",
        "Skew": 0,
        "Confidence": 100,
        "ValidCheckSum": true,
        "NumberCheckSumChars": 0,
        "Length": 45,
        "BarcodeValue": "441231234561234567** UNLICENSED accusoft.com",
        "BarcodeData": [
          "4",
          "4",
          "1",
          "2",
          "3",
          "1",
          "2",
          "3",
          "4",
          "5",
          "6",
          "1",
          "2",
          "3",
          "4",
          "5",
          "6",
          "7",
          "*",
          "*",
          " ",
          "U",
          "N",
          "L",
          "I",
          "C",
          "E",
          "N",
          "S",
          "E",
          "D",
          " ",
          "a",
          "c",
          "c",
          "u",
          "s",
          "o",
          "f",
          "t",
          ".",
          "c",
          "o",
          "m",
          "\u0000"
        ],
        "BarcodeDataAsByte": "NDQxMjMxMjM0NTYxMjM0NTY3KiogVU5MSUNFTlNFRCBhY2N1c29mdC5jb20A",
        "BarcodeName": "IntelligentMail",
        "BarcodeType": 27,
        "ModeTransitions": [],
        "Info2D": {
          "RowsDetected": 0,
          "ColumnsDetected": 0,
          "Rows": 0,
          "Columns": 0,
          "ErrorCorrectionLevel": 0
        }
      },
      {
        "Area": "60, 89, 349, 84",
        "Point1": "60, 89",
        "Point2": "409, 89",
        "Point3": "409, 173",
        "Point4": "60, 173",
        "Skew": 0,
        "Confidence": 100,
        "ValidCheckSum": false,
        "NumberCheckSumChars": 0,
        "Length": 32,
        "BarcodeValue": "CODE ** UNLICENSED accusoft.com",
        "BarcodeData": [
          "C",
          "O",
          "D",
          "E",
          " ",
          "*",
          "*",
          " ",
          "U",
          "N",
          "L",
          "I",
          "C",
          "E",
          "N",
          "S",
          "E",
          "D",
          " ",
          "a",
          "c",
          "c",
          "u",
          "s",
          "o",
          "f",
          "t",
          ".",
          "c",
          "o",
          "m",
          "\u0000"
        ],
        "BarcodeDataAsByte": "Q09ERSAqKiBVTkxJQ0VOU0VEIGFjY3Vzb2Z0LmNvbQA=",
        "BarcodeName": "Code 39",
        "BarcodeType": 9,
        "ModeTransitions": [],
        "Info2D": {
          "RowsDetected": 0,
          "ColumnsDetected": 0,
          "Rows": 0,
          "Columns": 0,
          "ErrorCorrectionLevel": 0
        }
      },
      ...
    ]

_**NOTE:** Barcode Xpress runs in Watermark evaluation mode if started without
a license and the barcode value will be partially hidden. If you would like to
do a full-featured evaluation of the product, [contact us](mailto:info@accusoft.com)._
