using Serenity.Navigation;
using Administration = BowenSerene.Administration.Pages;
using MyPages = BowenSerene.Default.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "icon-speedometer")]
[assembly: NavigationLink(2000, "Movie Database/Movies", typeof(MyPages.MovieController), icon: "icon-camrecorder")]