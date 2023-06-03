﻿using app_myconference.Pages;
using app_myconference.ViewModels;

namespace app_myconference;

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

        builder.Services.AddSingleton<ScheduleDay1Page>();
        builder.Services.AddTransient<ScheduleDay2Page>();
        builder.Services.AddTransient<ScheduleViewModel>();

        return builder.Build();
	}
}
