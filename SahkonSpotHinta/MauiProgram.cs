﻿using SahkonSpotHinta.Services;
using SahkonSpotHinta.ViewModel;

namespace SahkonSpotHinta;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<PricesService>();

		builder.Services.AddSingleton<PriceViewModel>();	

		builder.Services.AddSingleton<SahkonHintaSeuranta>();

		return builder.Build();
	}
}
