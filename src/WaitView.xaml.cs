using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test;

public partial class WaitView : ContentPage
{
    public WaitView()
    {
        InitializeComponent();
    }

    private void Button_OnClickedAsNavigationPage(object? sender, EventArgs e)
    {
        RootPage p = new RootPage();
        var navigationPage = new NavigationPage(p);
        Microsoft.Maui.Controls.Application.Current.MainPage = navigationPage;
    }

    private void Button_OnClickedAsTabbedPage(object? sender, EventArgs e)
    {
        RootPage rp = new RootPage();
        Microsoft.Maui.Controls.Application.Current.MainPage = rp;
    }

}