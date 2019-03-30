using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTest.models;

namespace WpfAppTest
{
    public class MongoDbHelper
    {
        private static MongoDbHelper _mongoDbHelper = new MongoDbHelper();
        private MongoDbHelper()
        {
            this.init();
        }
        public static MongoDbHelper GetInstance()
        {
            return _mongoDbHelper;
        }
        private const string connectionString = "mongodb://localhost:27017";
        MongoClient client = null;
        private IMongoDatabase db = null;
        private void init()
        {
            client = new MongoClient(connectionString);
            db = client.GetDatabase("Bamama");
        }
        //public void InsertTestData_Tables()
        //{
        //    MongoClient client = new MongoClient(connectionString);
        //    var db = client.GetDatabase("Bamama");
        //    var collection = db.GetCollection<Table>("tables");
        //    collection.InsertOne(new Table { No = 1, Name = "一号桌", IsAvailable = true, IsJoinAbleTable = false, MinSize = 1, MaxSize = 2, Status = Table.TableUseStatusEnum.NotUsed });
        //    collection.InsertOne(new Table { No = 2, Name = "二号桌", IsAvailable = true, IsJoinAbleTable = false, MinSize = 1, MaxSize = 2, Status = Table.TableUseStatusEnum.NotUsed });
        //    collection.InsertOne(new Table { No = 3, Name = "三号桌", IsAvailable = true, IsJoinAbleTable = false, MinSize = 1, MaxSize = 2, Status = Table.TableUseStatusEnum.NotUsed });
        //    collection.InsertOne(new Table { No = 4, Name = "四号桌", IsAvailable = true, IsJoinAbleTable = false, MinSize = 1, MaxSize = 2, Status = Table.TableUseStatusEnum.NotUsed });
        //    collection.InsertOne(new Table { No = 5, Name = "五号桌", IsAvailable = true, IsJoinAbleTable = false, MinSize = 1, MaxSize = 2, Status = Table.TableUseStatusEnum.NotUsed });
        //    collection.InsertOne(new Table { No = 6, Name = "六号桌", IsAvailable = true, IsJoinAbleTable = false, MinSize = 1, MaxSize = 2, Status = Table.TableUseStatusEnum.NotUsed });
        //    collection.InsertOne(new Table { No = 7, Name = "七号桌", IsAvailable = true, IsJoinAbleTable = false, MinSize = 1, MaxSize = 2, Status = Table.TableUseStatusEnum.NotUsed });
        //    collection.InsertOne(new Table { No = 8, Name = "八号桌", IsAvailable = true, IsJoinAbleTable = false, MinSize = 1, MaxSize = 2, Status = Table.TableUseStatusEnum.NotUsed });
        //    collection.InsertOne(new Table { No = 9, Name = "九号桌", IsAvailable = true, IsJoinAbleTable = false, MinSize = 1, MaxSize = 2, Status = Table.TableUseStatusEnum.NotUsed });
        //}
        public IMongoCollection<TDocument> GetCollection<TDocument>(string name, MongoCollectionSettings settings = null)
        {
            var collection = db.GetCollection<TDocument>(name, settings);
            return collection;
        }
        //public long GetTables(string name, MongoCollectionSettings settings = null)
        //{
        //    MongoClient client = new MongoClient(connectionString);
        //    var db = client.GetDatabase("Bamama");
        //    var collection = this.GetCollection<Table>(name);
        //    var filter = Builders<Table>.Filter.Gt("No", 0);
        //    long cnt = collection.CountDocuments(filter);
        //    return cnt;
        //}
    }
}
