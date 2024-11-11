using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIA;

namespace Scanner.Code
{
    internal static class ScannerHelper
    {
        internal static Task<List<string>> GetAllDevices()
        {
            List<string> devices = new List<string>();
            devices.Clear();

            try
            {
                DeviceManager deviceManager = new DeviceManager();
                foreach (DeviceInfo deviceInfo in deviceManager.DeviceInfos)
                {
                    if (deviceInfo.Type == WiaDeviceType.ScannerDeviceType)
                        devices.Add((string)deviceInfo.Properties["Name"].get_Value());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Task.FromResult(devices);
        }
        
        internal static async Task<Image> ScanAsImageAsync(string scannerName, string paperSize, int colorMode, int imageDPI)
        {
            try
            {
                return await Task.Run(() =>
                {
                    // Get Scanner Device
                    var SelectedDevice = GetDeviceInfo(scannerName);

                    if (SelectedDevice == null)
                    {
                        throw new Exception("الجهاز غير متصل");
                    }

                    // Connect to scanner device
                    Device device = SelectedDevice.Connect();
                    Item scannerItem = device.Items[1];

                    // Set scanner settings
                    SetScannerProperties(scannerItem, imageDPI, colorMode, paperSize);

                    // Scan and get image
                    ImageFile imageFile = null;
                    try
                    {
                        imageFile = (ImageFile)scannerItem.Transfer(WIA.FormatID.wiaFormatJPEG);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

                    // convert imagefile to image
                    return ConvertImageFileToImage(imageFile);
                });
            }
            catch { return null;};
        }

        private static void SetScannerProperties(Item scannerItem, int imageDPI, int colorMode, string paperSize)
        {
            // number as name inside library wia
            const string WIA_HORIZONTAL_DPI = "6147";
            const string WIA_VERTICAL_DPI = "6148";
            const string WIA_HORIZONTAL_EXTENT = "6151";
            const string WIA_VERTICAL_EXTENT = "6152";
            const string WIA_COLOR_MODE = "6146";

            int width = 0, hieght = 0;

            try
            {
                GetPaperWidthAndHieth(paperSize, imageDPI, ref width, ref hieght);

                SetWIAPropertie(scannerItem.Properties, WIA_HORIZONTAL_DPI, imageDPI);
                SetWIAPropertie(scannerItem.Properties, WIA_VERTICAL_DPI, imageDPI);
                SetWIAPropertie(scannerItem.Properties, WIA_COLOR_MODE, colorMode);
                SetWIAPropertie(scannerItem.Properties, WIA_HORIZONTAL_EXTENT, width);
                SetWIAPropertie(scannerItem.Properties, WIA_VERTICAL_EXTENT, hieght);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private static void SetWIAPropertie(IProperties properties, object propertyName, object propertyValue)
        {
            Property property = properties[ref propertyName];
            property.set_Value(propertyValue);
        }

        private static void GetPaperWidthAndHieth(string paperSize, int Dpi,ref int width, ref int hieght)
        {
            switch (paperSize.ToUpper())
            {
                case "A4":
                    width = (int)(8.27 * Dpi);
                    hieght = (int)(11.69* Dpi);
                    break;
                case "A5":
                    width = (int)(5.84 * Dpi);
                    hieght = (int)(8.27 * Dpi);
                    break;
                case "Letter":
                    width = (int)(8.5 * Dpi);
                    hieght = (int)(11 * Dpi);
                    break;
                default: throw new Exception("حجم الورقة غير معروف");
            }
        }

        private static DeviceInfo GetDeviceInfo(string scannerName)
        {

            DeviceManager manager = new DeviceManager();
            foreach(DeviceInfo deviceInfo in manager.DeviceInfos)
            {
                if(deviceInfo.Type == WiaDeviceType.ScannerDeviceType && (string)deviceInfo.Properties["Name"].get_Value() == scannerName)
                    return deviceInfo;
            }
            return null;
        }

        private static Image ConvertImageFileToImage(ImageFile imageFile)
        {
            if (imageFile == null) return null;

            byte[] imageBytes = (byte[])imageFile.FileData.get_BinaryData();
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
