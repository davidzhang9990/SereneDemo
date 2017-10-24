
using Serenity.Navigation;

using MyPages = BowenSerene.Default.Pages;
[assembly: NavigationLink(int.MaxValue, "Default/Products", typeof(MyPages.ProductsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Suppliers", typeof(MyPages.SuppliersController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Purchase Order", typeof(MyPages.PurchaseOrderController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Purchase Order Detail", typeof(MyPages.PurchaseOrderDetailController), icon: null)]