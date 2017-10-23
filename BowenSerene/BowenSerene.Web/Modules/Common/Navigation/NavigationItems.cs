﻿using Serenity.Navigation;
using Administration = BowenSerene.Administration.Pages;
using MyPages = BowenSerene.Default.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "icon-speedometer")]

[assembly: NavigationMenu(1100, "Purchase Manage", icon: "icon-film")]
[assembly: NavigationLink(1110, "Purchase Manage/Purchase Order", typeof(MyPages.PurchaseOrderController), icon: null)]
[assembly: NavigationLink(1120, "Purchase Manage/Purchase Order Detail", typeof(MyPages.PurchaseOrderDetailController), icon: null)]

[assembly: NavigationMenu(2000, "Movie Database", icon: "icon-film")]
[assembly: NavigationLink(2100, "Movie Database/Movies", typeof(MyPages.MovieController), icon: "icon-camrecorder")]
[assembly: NavigationLink(2200, "Movie Database/Genre", typeof(MyPages.GenreController), icon: "icon-pin")]
[assembly: NavigationLink(2300, "Movie Database/Person", typeof(MyPages.PersonController), icon: "fa fa-fw fa-user-md")]

[assembly: NavigationLink(9100, "Administration/Tenants", typeof(MyPages.TenantsController), icon: null)]