using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTest.models
{
    [BsonIgnoreExtraElements]
    public class Table
    {
        public int No { get; set; }
        public string Name { get; set; }
        public int MinSize { get; set; }
        public int MaxSize { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsJoinAbleTable { get; set; }
        public TableUseStatusEnum Status { get; set; }
        public enum TableUseStatusEnum
        {
            NotUsed = 0,
            InUse = 1
        }
    }
}
