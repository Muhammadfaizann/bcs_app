using SystemCore.ViewModels;

namespace SystemCore;
public static class BuilderExtensions
{
    public static MauiAppBuilder UseSystemCore(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<MainPageViewModel>();

        return builder;
    }
}