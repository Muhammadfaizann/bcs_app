﻿using SystemCore;
using Microsoft.Extensions.Logging;

using APES.UI.XF;
using Bilateral_Corneal_Symmetry_3D_Analyzer.Popups;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseSystemCore()
            .ConfigureFonts(fonts =>
			{
                fonts.AddFont("Font-Awesome-6-Brands-Regular-400.otf", "FABrandsRegular");
                fonts.AddFont("Font-Awesome-6-Free-Regular-400.otf", "FARegular");
                fonts.AddFont("Font-Awesome-6-Free-Solid-900.otf", "FASolid");

                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureContextMenuContainer();


        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<ImportPopup>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}