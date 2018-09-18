using System;
using System.Drawing;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Interop;
using System.Windows;
using System.Drawing.Imaging;

namespace ConvertBmpToPng
{
    internal class ImageToBitmapConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var _path = (string)value;

            using (var myBitmap = new Bitmap(_path))
            {
                myBitmap.MakeTransparent(System.Drawing.Color.White);

                myBitmap.Save(_path, ImageFormat.Png);
            }

            return _path;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private object GetBackgrounColor()
        {
            


            Bitmap bitmap = new Bitmap(@"C:\Projects\Spotweld_New\Spotweld\BMP\Cursor.bmp");
            bitmap.MakeTransparent();

            Imaging.CreateBitmapSourceFromHBitmap(
                bitmap.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
            return bitmap;
        }
    }
}
