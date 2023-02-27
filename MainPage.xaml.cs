namespace winui_contentpage_not_transparent;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		var modal = new BottomModal();

		//modal.ApplyWorkaround(); // Throws exception inside function. Makes some sense, as there still is no parent at this moment..
		// System.NullReferenceException: 'Object reference not set to an instance of an object.'

		await Navigation.PushModalAsync(modal, false);
		modal.ApplyWorkaroundPureWeen();

		//modal.ApplyWorkaround(); // Trhows exception inside function:
		// System.InvalidCastException: 'Unable to cast object of type 'Microsoft.Maui.Controls.Window' to type 'Microsoft.Maui.Controls.Page'.'
	}
}

