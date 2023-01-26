namespace winui_contentpage_not_transparent;

public partial class BottomModal : ContentPage
{
	public BottomModal()
	{
		InitializeComponent();
	}

    async void CloseClicked(object sender, EventArgs e) => await Application.Current.MainPage.Navigation.PopModalAsync(true);
}