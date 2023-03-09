namespace CollectionViewAutoTap.Views;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		var vm = new MainPage();
		this.BindingContext = vm;
	}

	
}

