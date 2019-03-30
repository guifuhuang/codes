using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTest.models
{
    [BsonIgnoreExtraElements]
    public class OrderItem : INotifyPropertyChanged
    {
        public int ItemSn { get; set; }
        public String DishImagePath { get; set; }
        public String DishId { get; set; }
        public String DishName { get; set; }
        public decimal DishPrice { get; set; }
        private int _Qty = 0;
        public int Qty
        {
            get
            {
                return this._Qty;
            }
            set
            {
                this._Qty = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //private void NotifyPropertyChanged(String propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
