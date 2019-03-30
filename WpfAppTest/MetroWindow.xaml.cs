using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MongoDB.Driver;
using WpfAppTest.controls;
using WpfAppTest.models;
using static WpfAppTest.models.Table;

namespace WpfAppTest
{
    /// <summary>
    /// MetroWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MetroWindow : MahApps.Metro.Controls.MetroWindow
    {
        public DishList Dishs;
        public models.Table _currentTable = null;
        //private MongoDbHelper _dbhlper = MongoDbHelper.GetInstance();
        private AzureMongoDbHelper _dbhlper = AzureMongoDbHelper.GetInstance();
        public MetroWindow()
        {
            InitializeComponent();
        }
        private void init()
        {
            ObservableCollection<OrderItem> lstItems = new ObservableCollection<OrderItem>();
            //lstItems.Add(new OrderItem() { ItemSn = 1, DishId = "001", DishName = "宫保鸡丁", DishImagePath = "meals/meal1.jpg", DishPrice = 20, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 2, DishId = "002", DishName = "宫保鸡丁", DishImagePath = "meals/meal2.jpg", DishPrice = 22, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 3, DishId = "003", DishName = "宫保鸡丁", DishImagePath = "meals/meal3.jpg", DishPrice = 23, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 4, DishId = "004", DishName = "宫保鸡丁", DishImagePath = "meals/meal4.jpg", DishPrice = 24, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 5, DishId = "005", DishName = "宫保鸡丁", DishImagePath = "meals/meal5.jpg", DishPrice = 25, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 6, DishId = "006", DishName = "宫保鸡丁", DishImagePath = "meals/meal6.jpg", DishPrice = 206, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 7, DishId = "007", DishName = "宫保鸡丁", DishImagePath = "meals/meal1.jpg", DishPrice = 27, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 8, DishId = "008", DishName = "宫保鸡丁", DishImagePath = "meals/meal2.jpg", DishPrice = 28, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 9, DishId = "009", DishName = "宫保鸡丁", DishImagePath = "meals/meal3.jpg", DishPrice = 29, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 10, DishId = "010", DishName = "宫保鸡丁", DishImagePath = "meals/mea14.jpg", DishPrice = 23, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 11, DishId = "011", DishName = "宫保鸡丁", DishImagePath = "meals/meal5.jpg", DishPrice = 22, Qty = 1 });
            this.lvOrderedDish.ItemsSource = lstItems;
            this.BindDishList();
            this.BindTableList();
            //this.Dishs = new DishList();
            //this.Dishs = (DishList)(Application.Current.Resources["Dishs"] as ObjectDataProvider)?.Data;
            this.Dishs = (DishList)(Resources["Dishs"] as ObjectDataProvider)?.Data;
            this.Dishs.Path = "..\\..\\meals";
            //this.DishListBox.ItemsSource = this.Dishs;
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            //this.exMenu.IsExpanded = false;
            //this.scrollLeftTool.Visibility = Visibility.Collapsed;
            this.scrollLeftMenu.Visibility = Visibility.Collapsed;
            this.scrollLeftTable.Visibility = Visibility.Visible;
            this.BindTableList();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.scrollLeftSetting.Visibility = Visibility.Collapsed;
            this.scrollLeftMenu.Visibility = Visibility.Visible;
            this.scrollLeftTable.Visibility = Visibility.Collapsed;
        }
        private void TableButton_Click(object sender, RoutedEventArgs e)
        {
            this.scrollLeftSetting.Visibility = Visibility.Collapsed;
            this.scrollLeftMenu.Visibility = Visibility.Visible;
            this.scrollLeftTable.Visibility = Visibility.Collapsed;
            Button btn = sender as Button;
            this._currentTable = btn.Tag as models.Table;
            if (this._currentTable != null)
            {
                this.BindOrderItemList(this._currentTable.No);
            }

        }
        private void DishButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.lvOrderedDish.ItemsSource != null)
            {
                MessageBox.Show(this.lvOrderedDish.ItemsSource.GetType().ToString());
            }
            List<OrderItem> lstItems = new List<OrderItem>();
            //lstItems.Add(new OrderItem() { ItemSn = 1, DishId = "001", DishName = "宫保鸡丁", DishImagePath = "meals/meal1.jpg", DishPrice = 20, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 2, DishId = "002", DishName = "宫保鸡丁", DishImagePath = "meals/meal2.jpg", DishPrice = 22, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 3, DishId = "003", DishName = "宫保鸡丁", DishImagePath = "meals/meal3.jpg", DishPrice = 23, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 4, DishId = "004", DishName = "宫保鸡丁", DishImagePath = "meals/meal4.jpg", DishPrice = 24, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 5, DishId = "005", DishName = "宫保鸡丁", DishImagePath = "meals/meal5.jpg", DishPrice = 25, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 6, DishId = "006", DishName = "宫保鸡丁", DishImagePath = "meals/meal6.jpg", DishPrice = 206, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 7, DishId = "007", DishName = "宫保鸡丁", DishImagePath = "meals/meal1.jpg", DishPrice = 27, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 8, DishId = "008", DishName = "宫保鸡丁", DishImagePath = "meals/meal2.jpg", DishPrice = 28, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 9, DishId = "009", DishName = "宫保鸡丁", DishImagePath = "meals/meal3.jpg", DishPrice = 29, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 10, DishId = "010", DishName = "宫保鸡丁", DishImagePath = "meals/mea14.jpg", DishPrice = 23, Qty = 1 });
            //lstItems.Add(new OrderItem() { ItemSn = 11, DishId = "011", DishName = "宫保鸡丁", DishImagePath = "meals/meal5.jpg", DishPrice = 22, Qty = 1 });
            this.lvOrderedDish.ItemsSource = lstItems;
        }

        private void usrctrlTable_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.init();
        }

        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {
            this.scrollLeftMenu.Visibility = Visibility.Collapsed;
            this.scrollLeftTable.Visibility = Visibility.Collapsed;
            this.scrollLeftSetting.Visibility = Visibility.Visible;
            //this.DishListBox.Visibility = Visibility.Visible;
        }
        private void test()
        {
            var collections = _dbhlper.GetCollection<models.Table>(Enums.CollectionEnum.tables.ToString());
            //var filter = Builders<models.Table>.Filter.Gt("No", 0);
            var filter = Builders<models.Table>.Filter.Eq("IsAvailable", true);
            long cnt = collections.CountDocuments(filter);
            MessageBox.Show(cnt.ToString());
        }
        private void BindDishList()
        {
            var collections = _dbhlper.GetCollection<models.Dish>(Enums.CollectionEnum.dishs.ToString());
            var filterBuilder = Builders<models.Dish>.Filter;
            var filter = filterBuilder.Eq("IsAvailable", true);
            var documents = collections.Find(filter).ToList();
            foreach (models.Dish document in documents)
            {
                RBImageButton btnDishItem = new RBImageButton
                {
                    ImagePath = document.ImagePath,
                    ImageSize = 256,
                    IsEnabled= document.IsAvailable
                };
                btnDishItem.Click += DishButton_Click;

                this.wpPnlDishs.Children.Add(btnDishItem);
            }
        }
        private void BindTableList()
        {
            var collections = _dbhlper.GetCollection<models.Table>(Enums.CollectionEnum.tables.ToString());
            var filterBuilder = Builders<models.Table>.Filter;
            var filter = filterBuilder.Eq("IsAvailable", true);
            var documents = collections.Find(filter).ToList();
            foreach (models.Table document in documents)
            {
                Button btnTableItem = new Button
                {
                    Content = document.Name
                    , Height = 128
                    , Width = 128
                    , Style = Resources["HgfButtonStyle1"] as Style
                    , Tag = document
                };
                btnTableItem.Click += TableButton_Click;

                this.wpPnlTables.Children.Add(btnTableItem);
            }
        }
        private void BindOrderItemList(int tableNo)
        {
            var collections = _dbhlper.GetCollection<models.Order>(Enums.CollectionEnum.orders.ToString());
            var filterBuilder = Builders<models.Order>.Filter;
            var filter = filterBuilder.Eq("TableNo", tableNo) & filterBuilder.Eq("Status", TableUseStatusEnum.InUse);
            var order = collections.Find(filter).FirstOrDefault();
            if (order != null)
            {
                this.lvOrderedDish.ItemsSource = order.OrderItemList;
            }
            else
            {
                ObservableCollection<OrderItem> lstItems = this.lvOrderedDish.ItemsSource as ObservableCollection<OrderItem>;
                if (lstItems != null)
                {
                    lstItems.Clear();
                }
            }
        }
        private void btnBrowseImage_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog =  new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "图片文件|*.png;*.jpg";
            if (dialog.ShowDialog() == true)
            {
                this.txtImgPath.Text = dialog.FileName;
                this.imgPreview.Source = new BitmapImage(new Uri(dialog.FileName));
            }
        }

        private void btnSaveDish_Click(object sender, RoutedEventArgs e)
        {
            //var collections = _dbhlper.GetCollection<models.Dish>(Enums.CollectionEnum.dishs.ToString());
            //var filterBuilder = Builders<models.Dish>.Filter;
            //var filter = filterBuilder.Eq("Name", this.txtd);
            //var documents = collections.Find(filter).ToList();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (this.DishListBox.SelectedItem != null && e.ClickCount ==2)
            {
                Dish dish = this.DishListBox.SelectedItem as Dish;
                ObservableCollection<OrderItem> lstItems = this.lvOrderedDish.ItemsSource as ObservableCollection<OrderItem>;
                if (lstItems == null)
                {
                    lstItems = new ObservableCollection<OrderItem>();
                }
                if (lstItems.Where(i => i.DishId == dish.ToString()).Count<OrderItem>()>0)
                {
                    lstItems.Single<OrderItem>(i => i.DishId == dish.ToString()).Qty++;
                }
                else
                {
                    OrderItem order = new OrderItem();
                    order.ItemSn = lstItems.Count + 1;
                    order.DishId = dish.ToString();
                    order.DishName = dish.Name;
                    order.DishImagePath = dish.ToString();
                    order.DishPrice = dish.Price;
                    order.Qty = 1;
                    lstItems.Add(order);
                }
                //this.lvOrderedDish.ItemsSource = null;
                //this.lvOrderedDish.ItemsSource = lstItems;
                //if (this.lvOrderedDish.ItemsSource == null)
                //{
                //    this.lvOrderedDish.ItemsSource = lstItems;
                //}
                //this.lvOrderedDish.ItemsSource = lstItems;
            }
        }
        /// <summary>
        /// 【事件】点击【下单】按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderSave_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<OrderItem> lstItems = this.lvOrderedDish.ItemsSource as ObservableCollection<OrderItem>;


            var collections = _dbhlper.GetCollection<models.Order>(Enums.CollectionEnum.orders.ToString());
            var filterBuilder = Builders<models.Order>.Filter;
            var filter = filterBuilder.Eq("TableNo", this._currentTable.No) & filterBuilder.Eq("Status", TableUseStatusEnum.InUse);
            var savedOrder = collections.Find(filter).FirstOrDefault();
            var update = Builders<models.Order>.Update.Set("OrderItemList", lstItems);
            UpdateResult ur = collections.UpdateOne(filter, update, new UpdateOptions { IsUpsert = true });
            lstItems.Clear();
            //if (savedOrder != null)
            //{
            //    var update = Builders<models.Order>.Update.Set("OrderItemList", lstItems);
            //    collections.UpdateOne(filter, update);
            //}
            //else
            //{
            //    Order order = new Order();
            //    order.TableNo = this._currentTable.No;
            //    order.OrderItemList = lstItems;
            //    order.StartTime = System.DateTime.Now;
            //    order.Status = TableUseStatusEnum.InUse;
            //    collections.InsertOne(order);
            //}
        }
        /// <summary>
        /// 【事件】点击【结账】按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderBill_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<OrderItem> lstItems = this.lvOrderedDish.ItemsSource as ObservableCollection<OrderItem>;
            var collections = _dbhlper.GetCollection<models.Order>(Enums.CollectionEnum.orders.ToString());
            var filterBuilder = Builders<models.Order>.Filter;
            var filter = filterBuilder.Eq("TableNo", this._currentTable.No) & filterBuilder.Eq("Status", TableUseStatusEnum.InUse);
            var savedOrder = collections.Find(filter).FirstOrDefault();
            var update = Builders<models.Order>.Update.Set("OrderItemList", lstItems)
                .Set("EndTime", System.DateTime.Now)
                .Set("Status", TableUseStatusEnum.NotUsed)
                .Set("Amount", lstItems.Sum(o => o.DishPrice))
                .Set("ActualAmount", lstItems.Sum(o => o.DishPrice));
            //update.Set("EndTime", System.DateTime.Now);
            //update.Set("Status", TableUseStatusEnum.NotUsed);
            //update.Set("Amount", lstItems.Sum(o => o.DishPrice));
            //update.Set("ActualAmount", lstItems.Sum(o => o.DishPrice));
            UpdateResult ur = collections.UpdateMany(filter, update, new UpdateOptions { IsUpsert = true });
            lstItems.Clear();
            //if (savedOrder != null)
            //{
            //    var update = Builders<models.Order>.Update.Set("OrderItemList", lstItems);
            //    update.AddToSet("EndTime", System.DateTime.Now);
            //    update.AddToSet("Status", TableUseStatusEnum.NotUsed);
            //    update.AddToSet("Amount", lstItems.Sum(o=>o.DishPrice));
            //    update.AddToSet("ActualAmount", lstItems.Sum(o => o.DishPrice));
            //    UpdateResult ur = collections.UpdateMany(filter, update,, new UpdateOptions { IsUpsert=true});
            //    MessageBox.Show(ur.ToString());
            //}
            //else
            //{
            //    Order order = new Order();
            //    order.TableNo = this._currentTable.No;
            //    order.OrderItemList = lstItems;
            //    order.StartTime = System.DateTime.Now;
            //    order.EndTime = System.DateTime.Now;
            //    order.Amount = lstItems.Sum(o => o.DishPrice);
            //    order.ActualAmount = lstItems.Sum(o => o.DishPrice);
            //    order.Status = TableUseStatusEnum.NotUsed;
            //    collections.InsertOne(order);
            //}
        }

        private void btnOrderCancel_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<OrderItem> lstItems = this.lvOrderedDish.ItemsSource as ObservableCollection<OrderItem>;
            if (lstItems != null)
            {
                lstItems.Clear();
            }
        }
        /// <summary>
        /// 【事件】点击【保存】按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveTable_Click(object sender, RoutedEventArgs e)
        {
            var collections = _dbhlper.GetCollection<models.Table>(Enums.CollectionEnum.tables.ToString());
            var filterBuilder = Builders<models.Table>.Filter;
            var filter = filterBuilder.Eq("No", int.Parse(this.txtNo.Text));
            var savedTable = collections.Find(filter).FirstOrDefault();
            var update = Builders<models.Table>.Update.Set("No", int.Parse(this.txtNo.Text))
                .Set("Name", this.txtName.Text)
                .Set("MinSize", int.Parse(this.txtMin.Text))
                .Set("MaxSize", int.Parse(this.txtMax.Text))
                .Set("Status", TableUseStatusEnum.NotUsed)
                .Set("IsAvailable",true)
                .Set("IsJoinAbleTable",this.chkJoinAble.IsChecked);
            UpdateResult ur = collections.UpdateOne(filter, update, new UpdateOptions { IsUpsert = true });
        }
    }
}
