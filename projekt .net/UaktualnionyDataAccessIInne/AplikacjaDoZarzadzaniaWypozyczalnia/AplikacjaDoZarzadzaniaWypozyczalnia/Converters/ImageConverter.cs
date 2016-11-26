using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AplikacjaDoZarzadzaniaWypozyczalnia.Converters
{
    public static class ImageConverter
    {
        public static BitmapImage ByteToBitmapConvert(byte[] value)
        {
            byte[] array = (byte[])value;
            if (array == null || array.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(array))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
        public static byte[] BitmapToByte(BitmapImage imageSource)
        {
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            byte[] bytes = null;
            var bitmapSource = imageSource as BitmapSource;

            if (bitmapSource != null)
            {
                encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

                using (var stream = new MemoryStream())
                {
                    encoder.Save(stream);
                    bytes = stream.ToArray();
                }
            }

            return bytes;

        }
    }
}
