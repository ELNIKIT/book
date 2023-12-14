using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Shapes;

namespace BookShopWPF
{
	public class TableRow
	{
		public int ProductID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int StockQuantity { get; set; }
		public string CategoryID { get; set; }
		public string ManufacturerID { get; set; }

	}

	public partial class MainWindow : Window
    {
		public ObservableCollection<TableRow> Items { get; set; }

        public static MainWindow instance;

		public MainWindow()
        {
            InitializeComponent();
            instance= this;
            LoadData();
        }

        public void LoadData()
        {
			var context = ShopDbContext.Instance;
            Items = new();

           // MessageBox.Show(context.GetProducts().Count.ToString());

			foreach(var item in context.GetProducts())
            {
                Items.Add(new TableRow()
                {
                    ProductID = item.ProductID, 
                    Name = item.Name, 
                    Description = item.Description, 
                    CategoryID= item.CategoryID, 
                    ManufacturerID= item.ManufacturerID, 
                    Price = item.Price, 
                    StockQuantity=item.StockQuantity
                });
              //  MessageBox.Show("Добавлен");
            }
            dataGrid.ItemsSource = Items;

			//dataGrid.ItemsSource = context.GetProducts();
        }
        public void AddProduct(object sender, EventArgs e)
        {
			if (!ShopDbContext.Instance.CanGetAccess(AccessLevels.Admin))
			{
				MessageBox.Show("нету прав");
				return;
			}
			AddWindow addWindow = new AddWindow();

            addWindow.ShowDialog();
           // Close();
        }

        public void AddToCart(object sender, EventArgs e)
        {
            if (dataGrid.SelectedItem == null) return;
            var item = dataGrid.SelectedItem as TableRow;

            // Проверяем количество товара в базе данных
            var productInDb = ShopDbContext.Instance.Products.FirstOrDefault(p => p.ProductID == item.ProductID);
            if (productInDb == null || productInDb.StockQuantity <= 0)
            {
                MessageBox.Show("Товар отсутствует на складе.");
                return;
            }

            // Получаем корзину пользователя
            var cart = ShopDbContext.Instance.Cart.Where(x => x.UserID == ShopDbContext.Instance.activeUserID).FirstOrDefault();
            if (cart == null)
            {
                cart = new Cart()
                {
                    UserID = ShopDbContext.Instance.activeUserID,
                    ProductID = new List<int>() { item.ProductID }
                };
                ShopDbContext.Instance.Cart.Add(cart);
            }
            else
            {
                // Подсчитываем, сколько раз данный товар уже добавлен в корзину
                int countInCart = cart.ProductID.Count(id => id == item.ProductID);
                if (countInCart >= productInDb.StockQuantity)
                {
                    MessageBox.Show("Невозможно добавить больше товаров, чем есть на складе.");
                    return;
                }
                cart.ProductID.Add(item.ProductID);
            }

            ShopDbContext.Instance.SaveChanges();
            MessageBox.Show("Продукт добавлен в корзину");
        }


        public void OpenCart(object sender, EventArgs e)
		{
			CartWindow cart = new CartWindow();
			cart.ShowDialog();
            LoadData();
        }


		public void EditProduct(object sender, EventArgs e)
		{
			if (!ShopDbContext.Instance.CanGetAccess(AccessLevels.Manager))
			{
				MessageBox.Show("нету прав");
				return;
			}

			if (dataGrid.SelectedItem == null) return;

			var item = dataGrid.SelectedItem as TableRow;

			//MessageBox.Show(Items[dataGrid.SelectedIndex].Price);
			Product selectedProduct = new Product()
			{
				ProductID = item.ProductID,
				Name = item.Name,
				Description = item.Description,
				StockQuantity = item.StockQuantity,
				ManufacturerID = item.ManufacturerID,
				Price = item.Price,
				CategoryID = item.CategoryID
			};
			AddWindow addWindow = new AddWindow(selectedProduct, dataGrid.SelectedIndex);
			addWindow.ShowDialog();
            LoadData();

        }

		public void DeleteProduct(object sender, EventArgs e)
		{
			if (!ShopDbContext.Instance.CanGetAccess(AccessLevels.Admin))
			{
				MessageBox.Show("нету прав");
				return;
			}
			if (dataGrid.SelectedItem == null) return;
			var item = dataGrid.SelectedItem as TableRow;

			Product selectedProduct = ShopDbContext.Instance.Products.FirstOrDefault(x => x.ProductID == item.ProductID);
			ShopDbContext.Instance.Products.Remove(selectedProduct);
			ShopDbContext.Instance.SaveChanges();
			LoadData();
		}

	


    }
}

