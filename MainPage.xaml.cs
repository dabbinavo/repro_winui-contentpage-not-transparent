namespace winui_contentpage_not_transparent;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new BottomModal(), true);
	}
}

