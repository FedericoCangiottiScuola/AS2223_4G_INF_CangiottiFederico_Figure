using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace AS2223_4G_INF_CangiottiFederico_Figure;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
