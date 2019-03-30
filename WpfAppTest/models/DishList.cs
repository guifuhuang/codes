using System.Collections.ObjectModel;
using System.IO;

namespace WpfAppTest.models
{
    public class DishList : ObservableCollection<Dish>
    {
        private DirectoryInfo _directory;

        public DishList()
        {
        }

        public DishList(string path) : this(new DirectoryInfo(path))
        {
        }

        public DishList(DirectoryInfo directory)
        {
            _directory = directory;
            Update();
        }

        public string Path
        {
            set
            {
                _directory = new DirectoryInfo(value);
                Update();
            }
            get { return _directory.FullName; }
        }

        public DirectoryInfo Directory
        {
            set
            {
                _directory = value;
                Update();
            }
            get { return _directory; }
        }

        private void Update()
        {
            foreach (var f in _directory.GetFiles("*.jpg"))
            {
                Add(new Dish(f.FullName));
            }
        }
    }
}
