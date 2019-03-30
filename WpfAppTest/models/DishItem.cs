using System;
using System.Windows.Media.Imaging;

namespace WpfAppTest.models
{
    public class DishItem
    {
        public DishItem(string path)
        {
            Path = path;
            Uri = new Uri(Path);
            Image = BitmapFrame.Create(Uri);
        }

        public string Path { get; }
        public Uri Uri { get; }
        public BitmapFrame Image { get; }

        public override string ToString() => Path;
    }
}