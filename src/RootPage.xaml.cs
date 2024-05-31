namespace test;

public partial class RootPage : FlyoutPage
{
    public static RootPage? Current { get; private set; }
   // private readonly IMessengerService? _messenger;
   public RootPage()
   {
       InitializeComponent();
   }
    // public RootPage(INavigationService navigationService, IMessengerService? messengerService)
    // {
    //     InitializeComponent();
    //     _messenger = messengerService;
    //     _messenger?.RegisterOnMainThread<DisableMenuMessage>(this, OnDisableMenuMessage);
    //
    //     Detail = new NavigationPage(new ContentPage() { Title = "Detail" });
    //     Flyout = navigationService.GetMenuPage<MenuViewModel>();
    //     Current = this;
    //
    // }
    // private void OnDisableMenuMessage(object recipient, DisableMenuMessage message)
    // {
    //     IsGestureEnabled = !message.ShoulIDisable;
    //     Flyout.IsVisible = !message.ShoulIDisable;
    // }
}