using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using Realms;

namespace TailorResume
{
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();

            var realmConfig = new RealmConfiguration("AppDb.realm");
            
            builder.Services.AddScoped(sp => Realm.GetInstance(realmConfig));
            
#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            var app = builder.Build();
            
            return app;
        }
    }
}
