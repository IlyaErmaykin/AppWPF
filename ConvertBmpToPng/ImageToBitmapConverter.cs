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
        public BitmapImage ConvertByteArrayToImage(byte[] imageByteArray)
        {
            BitmapImage img = new BitmapImage();

            using (MemoryStream memoryStream = new MemoryStream(imageByteArray))
            {
                return null;
            }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            using (MemoryStream memoryStrem = new MemoryStream())
            {
                var _path = (string)value;

                using (var myBitmap = new Bitmap(_path))
                {
                    myBitmap.MakeTransparent(System.Drawing.Color.White);

                    myBitmap.Save(memoryStrem, System.Drawing.Imaging.ImageFormat.Png);

                    //MesageBox.Show(myBitmap);
                    return myBitmap;

                }

                //myBitmap.Save(_path, ImageFormat.Png);
            }

            //return _path;

            //using (var myBitmap = new Bitmap(_path))
            //{
            //    myBitmap.MakeTransparent(Color.White);

            //    //Переделать
            //    //_path = _path.Replace(".bmp", ".png");

            //    //myBitmap.Save(_path, ImageFormat.Png);
            //}

            //byte[] file = File.ReadAllBytes(_path);

            //using (MemoryStream byteStream = new MemoryStream(file))
            //{
            //    using (BinaryReader reader = new BinaryReader(byteStream))
            //    {
            //        for (int i = 0; i < file.Length; i++)
            //        {
            //            byte result;
            //            using (Bitmap myBitmap = new Bitmap(reader.ToString()))
            //            {
            //                myBitmap.MakeTransparent(Color.White);
            //                result = reader.ReadByte();
            //            }

            //            //result = reader.ReadByte();
            //            MessageBox.Show(result.ToString());
            //        }
            //    }
            //}
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
