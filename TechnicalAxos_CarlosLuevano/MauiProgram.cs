using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace TechnicalAxos_CarlosLuevano
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .RegisterAppServices()
                .RegisterViewModels()
                .RegisterPages()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }

    public static class MauiAppBuilderExtensions
    {
        /// <summary>
        /// Register all pages for DI
        /// </summary>
        /// <returns>Same <seealso cref="MauiAppBuilder"/> instance.</returns>
        public static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<Pages.MainPage>();

            return mauiAppBuilder;
        }

        /// <summary>
        /// Register all viewmodels for DI
        /// </summary>
        /// <returns>Same <seealso cref="MauiAppBuilder"/> instance.</returns>
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<ViewModels.MainViewModel>();

            return mauiAppBuilder;
        }

        /// <summary>
        /// Register all services for DI
        /// </summary>
        /// <returns>Same <seealso cref="MauiAppBuilder"/> instance.</returns>
        public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton(AppInfo.Current);
            mauiAppBuilder.Services.AddSingleton<Services.IToastService, Services.ToastService>();
            mauiAppBuilder.Services.AddTransient<Services.CountryService>();

            return mauiAppBuilder;
        }
    }
}
