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
		var parentView = (Page)this.Parent;
		parentView.BackgroundColor = Colors.Transparent;
	}
}