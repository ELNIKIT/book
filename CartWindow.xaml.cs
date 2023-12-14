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

namespace BookShopWPF
{
    public partial class CartWindow : Window
    {
        public decimal finalCostOfCart;
        public ObservableCollection<TableRow> Items { get; private set; }

        public CartWindow()
        {
            InitializeComponent();
            Items = new ObservableCollection<TableRow>();
            dataGrid.ItemsSource = Items;
            LoadCart();
        }

        public void LoadCart()
        {
            Items.Clear();
            finalCostOfCart = 0;
            var cart = ShopDbContext.Instance.Cart.FirstOrDefault(x => x.UserID == ShopDbContext.Instance.activeUserID);

            if (cart == null)
            {
                MessageBox.Show("Корзина пуста", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            foreach (int product in cart.ProductID)
            {
                var item = ShopDbContext.Instance.GetProducts().FirstOrDefault(x => x.ProductID == product);
                if (item == null) continue;

                var existingItem = Items.FirstOrDefault(x => x.ProductID == item.ProductID);
                if (existingItem != null)
                {
                    existingItem.StockQuantity++;
                }
                else
                {
                    Items.Add(new TableRow
                    {
                        ProductID = item.ProductID,
                        Name = item.Name,
                        Description = item.Description,
                        CategoryID = item.CategoryID,
                        ManufacturerID = item.ManufacturerID,
                        Price = item.Price,
                        StockQuantity = 1
                    });
                }
                finalCostOfCart += item.Price;
            }

            TotalCostText.Text = $"Итого к оплате: {finalCostOfCart}";
        }


        public void RemoveFromCarts(object sender, EventArgs e)
        {
            if (dataGrid.SelectedItem == null) return;
            var item = dataGrid.SelectedItem as TableRow;
            var cart = ShopDbContext.Instance.Cart.Where(x => x.UserID == ShopDbContext.Instance.activeUserID).FirstOrDefault();
            cart.ProductID.Remove(item.ProductID);
            LoadCart();
        }

        public void CloseCart(object sender, EventArgs e)
        {
            // Сохраняем все несохраненные изменения в базе данных
            ShopDbContext.Instance.SaveChanges();

            // Закрываем окно
            Close();
        }


        public void BuyProducts(object sender, EventArgs e)
        {
            var cart = ShopDbContext.Instance.Cart.FirstOrDefault(x => x.UserID == ShopDbContext.Instance.activeUserID);

            if (cart == null || !cart.ProductID.Any())
            {
                MessageBox.Show("Корзина пуста", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Список для отслеживания товаров с недостаточным количеством
            var insufficientStockProducts = new List<string>();

            // Используем HashSet для уникальности ProductID
            var uniqueProductIds = new HashSet<int>(cart.ProductID);

            foreach (var productId in uniqueProductIds)
            {
                var productInDB = ShopDbContext.Instance.Products.FirstOrDefault(p => p.ProductID == productId);
                if (productInDB != null)
                {
                    int countInCart = cart.ProductID.Count(id => id == productId);

                    if (productInDB.StockQuantity >= countInCart)
                    {
                        productInDB.StockQuantity -= countInCart; // Уменьшаем количество товара на количество в корзине
                    }
                    else
                    {
                        insufficientStockProducts.Add(productInDB.Name);
                    }
                }
            }

            if (insufficientStockProducts.Any())
            {
                MessageBox.Show($"Недостаточно товаров на складе: {string.Join(", ", insufficientStockProducts)}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ShopDbContext.Instance.SaveChanges();

                // Очистить корзину после покупки
                cart.ProductID.Clear();
                ShopDbContext.Instance.SaveChanges();

                MessageBox.Show("Покупка прошла успешно");

            }

            LoadCart();
        }


    }
}