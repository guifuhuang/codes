using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfAppTest.models.Table;

namespace WpfAppTest.models
{
    [BsonIgnoreExtraElements]
    public class Order
    {
        public int TableNo { get; set; }
        public ObservableCollection<OrderItem> OrderItemList { get; set; }
        public decimal Amount { get; set; } = 0;
        public decimal ActualAmount { get; set; }=0;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double DiscountRate { get; set; } = 1;
        public TableUseStatusEnum Status { get; set; }
    }
}
