using PImageTools.Shrinker.Helpers;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PImageTools.Shrinker
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ButtonOutputFolder_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ListViewFiles_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var file in files)
                {
                    GetImageInfo(file);
                }
            }
        }

        private void GetImageInfo(string inputFile)
        {
            try
            {
                var bitmap = new BitmapImage(new Uri(inputFile));
                ListViewFiles.Items.Add(new ImageProperties()
                {
                    FileName = Path.GetFileName(inputFile),
                    Dimensions = string.Format("{0}x{1}", bitmap.PixelWidth, bitmap.PixelHeight),
                    Size = GetFileSize(inputFile)
                });
            }
            catch
            {
            }
        }

        private void ResizeImage(string inputPath, string outputPath, int width, int height)
        {
            var bitmap = new BitmapImage();

            using (var stream = new FileStream(inputPath, FileMode.Open))
            {
                bitmap.BeginInit();
                bitmap.DecodePixelWidth = width;
                bitmap.DecodePixelHeight = height;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.StreamSource = stream;
                bitmap.EndInit();
            }

            var encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmap));

            using (var stream = new FileStream(outputPath, FileMode.Create))
            {
                encoder.Save(stream);
            }
        }

        private string GetFileSize(string inputFile)
        {
            var fi = new FileInfo(inputFile);
            return fi.Length.ToFileSize();
        }
    }
}