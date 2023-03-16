using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
