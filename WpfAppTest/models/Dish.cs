using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfAppTest.models
{
    [BsonIgnoreExtraElements]
    public class Dish 
    {
        public Dish(string path)
        {
            ImagePath = path;
            ImageUri = new Uri(ImagePath);
            Image = BitmapFrame.Create(ImageUri);
        }
        public String ImagePath { get; set; }
        public Uri ImageUri { get; set; }
        public BitmapFrame Image { get; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString() => ImagePath;
        public DishCategoryEnum Category { get; set; }

        public enum DishCategoryEnum
        {
            StapleFood = 0,// 主食
            ColdDish = 1, // 冷菜
            HotDishe = 2, // 热菜
            Barbecue = 3, // 烤肉
            Drinks = 4, // 饮料
            Wine = 5, // 酒水
            Other = 9 // 其他
        }
    }
}
