
using Serenity.Navigation;

using MyPages = BowenSerene.Default.Pages;
[assembly: NavigationLink(int.MaxValue, "Default/Products", typeof(MyPages.ProductsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Suppliers", typeof(MyPages.SuppliersController), icon: null)]