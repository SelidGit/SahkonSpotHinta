using System.ComponentModel;
using SahkonSpotHinta.Services;

namespace SahkonSpotHinta;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		SetTheme();
		SettingsService.Instance.PropertyChanged += OnSettingsPropertyChanged;
	}
	private void OnSettingsPropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		if (e.PropertyName == nameof(SettingsService.Theme))
		{
			SetTheme();
		}
	}

	private void SetTheme()
	{
		UserAppTheme = SettingsService.Instance?.Theme != null
					 ? SettingsService.Instance.Theme.AppTheme
					 : AppTheme.Unspecified;
	}

}
