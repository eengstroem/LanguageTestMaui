using LanguageTestMaui.Resources.Strings;
using System.Globalization;

namespace LanguageTestMaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("da");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("da");
        CultureInfo.CurrentCulture = new CultureInfo("da-DK", false);
        CultureInfo.CurrentUICulture = new CultureInfo("da-DK", false);
        DisplayAlert(strings.CurrentLanguageText, "", "OK");
    }
}

