using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConvertBmpToPng
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitmapImage bitmap;

        public BitmapImage Bitmap { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        //public void ConfertFunction()
        //{
        //    Bitmap bitmap = (Bitmap)pictureBox1.Image;
        //}

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Вернуться, если ничего не получится
            //OpenFileDialog openfiledialog = new OpenFileDialog();

            //openfiledialog.Title = "Open Image";
            //openfiledialog.Filter = "Image File|*.bmp; *.gif; *.jpg; *.jpeg; *.png;";

            //if (openfiledialog.ShowDialog() == true)
            //{
            //    ??? var image = new Bitmap();
            //}

            //RenderTargetBitmap _renderTargetBitmap = new RenderTargetBitmap();
            //_renderTargetBitmap .Show();

            _();

            ProcessFile();

            LoadImageToBitmap();
        }

        public void ProcessFile()
        {
            // Загрузить все файлы и создать новую папку для модификации данных
            string[] files = Directory.GetFiles(@"C:\Projects\Spotweld_New\Spotweld\BMP", "*.bmp; *.png;", SearchOption.AllDirectories);
            string newDir = @"c:\NewPictures";
            Directory.CreateDirectory(newDir);

            // Обработать данные изображений в блокирующей манере
            foreach (string currentFile in files)
            {
                string filename = System.IO.Path.GetFileName(currentFile);

                using (Bitmap bitmap = new Bitmap(currentFile))
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitmap.Save(System.IO.Path.Combine(newDir, filename));

                    // Вывести идентификатор потокаб обрабатываеющего текущее изоражение
                    this.Text = string.Format("Processing {0} on tread {1}", filename, Thread.CurrentThread.ManagedThreadId);
                }
            }
        }

        // Преобразование Bitmap в ImageSource
        //public BitmapImage BitmapeToImageSource(Bitmap bitmap)
        //{
        //    using (MemoryStream memory = new MemoryStream())
        //    {
        //        bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
        //        memory.Position = 0;
        //        BitmapImage bitmapImage = new BitmapImage();
        //        bitmapImage.BeginInit();
        //        bitmapImage.StreamSource = memory;
        //        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
        //        bitmapImage.EndInit();

        //        return bitmapImage;
        //    }
        //}

        //// Удаление белого цвета из Bitmap
        //public void RemoveWhiteColorFromBitmapFunction()
        //{
        //    BitmapImage myBitmap = new BitmapImage();
        //    myBitmap.Clear(System.Windows.Media.Colors.White);
        //}

        public void _()
        {
            Grid layoutRoot = new Grid();

            layoutRoot.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            layoutRoot.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });

            TextBox tb = new TextBox() { Text = "W(O_o)w" };
            layoutRoot.Children.Add(tb);

            Image image = new Image();
            //image = System.IO.Path.Combine(@"C:\Projects\Spotweld_New\Spotweld\BMP\Cursor.bmp");
            layoutRoot.Children.Add(image);

            this.Content = layoutRoot;

            BitmapImage bitmapImage = new BitmapImage();

            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"C:\Projects\Spotweld_New\Spotweld\BMP\Cursor.bmp");
            bitmapImage.DecodePixelWidth = 200;
            bitmapImage.EndInit();
            //bitmapImage.Show();
            //bitmapImage.

            //var image = new BitmapImage(@"C:\Projects\Spotweld_New\Spotweld\BMP\Cursor.bmp");
        }

        // Список файлов BitmapImage
        List<BitmapImage> images = new List<BitmapImage>();

        // Текущая позиция в списке
        private int currImage = 0;
        private const int MAX_IMAGES = 2;

        private void LoadImageToBitmap(object senderm, RoutedEventArgs e)
        {
            try
            {
                string path = Environment.CurrentDirectory;

                // Загрузить эти изображения при загрузке окна
                images.Add(new BitmapImage(new Uri(string.Format(@"C:\Projects\Spotweld_New\Spotweld\BMP\Cursor.bmp", path))));

                // Показать изображение
                imageHolder.Source = images[currImage];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
