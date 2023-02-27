using Microsoft.Maui.Platform;

namespace winui_contentpage_not_transparent;

public partial class BottomModal : ContentPage
{
	public BottomModal()
	{
		InitializeComponent();

		//ApplyWorkaround(); // Throws exception inside function. Makes some sense, as there is no parent at this moment..
		// System.NullReferenceException: 'Object reference not set to an instance of an object.'
	}

    async void CloseClicked(object sender, EventArgs e) => await Application.Current.MainPage.Navigation.PopModalAsync(true);

	public void ApplyWorkaround()
	{
		// Workaraound provided by eddie010 
		// https://github.com/dotnet/maui/issues/7450#issuecomment-1294906779
		var parentView = (Page)this.Parent;
		parentView.BackgroundColor = Colors.Transparent;
	}

	public void ApplyWorkaroundPureWeen()
	{
		// Try to set background color of windowRootView as noted by PureWeen
		// https://github.com/dotnet/maui/issues/7450#issue-1246971442
		var windowManager = Handler.MauiContext.Services.GetRequiredService<NavigationRootManager>();

		var windowRootView = windowManager.RootView as WindowRootView;
		// var rootNavigationView = windowRootView!.Content as RootNavigationView;
		// var contentPanel = rootNavigationView!.Content as ContentPanel;
		// var windowRootViewContainer = windowRootView!.Parent as Panel;

		windowRootView.Background = SolidColorBrush.Transparent.Color.ToPlatform(); // Still a white background. Even if using e.g. 'Blue' instead of 'Transparent'
		// rootNavigationView.Background = SolidColorBrush.Transparent.Color.ToPlatform();
		// contentPanel!.Background = SolidColorBrush.Transparent.Color.ToPlatform();
	}
}
