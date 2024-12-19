using CommunityToolkit.Maui.Alerts;

namespace TechnicalAxos_CarlosLuevano.Services
{
    public interface IToastService
    {
        public Task DisplayErrorToastAsync(string message);
        public Task DisplaySuccessToastAsync(string message);
    }

    /// <summary>
    /// Implementation of <seealso cref="IToastService"/> for .Net MAUI
    /// </summary>
    internal class ToastService : IToastService
    {
        public Task DisplayErrorToastAsync(string message)
        {
            return Shell.Current.Dispatcher.DispatchAsync(() =>
                Shell.Current.DisplaySnackbar(message, actionButtonText: "", duration: TimeSpan.FromSeconds(2),
                    visualOptions: new CommunityToolkit.Maui.Core.SnackbarOptions
                    {
                        BackgroundColor = Application.Current!.RequestedTheme == AppTheme.Dark
                                          ? (Color)Application.Current.Resources["ErrorDark"]
                                          : (Color)Application.Current.Resources["Error"],
                        TextColor = Application.Current!.RequestedTheme == AppTheme.Dark
                                    ? Colors.Black : Colors.White,
                    }));
        }

        public Task DisplaySuccessToastAsync(string message)
        {
            return Shell.Current.Dispatcher.DispatchAsync(() =>
                Shell.Current.DisplaySnackbar(message, actionButtonText: "", duration: TimeSpan.FromSeconds(2),
                    visualOptions: new CommunityToolkit.Maui.Core.SnackbarOptions
                    {
                        BackgroundColor = Application.Current!.RequestedTheme == AppTheme.Dark
                                          ? (Color)Application.Current.Resources["PrimaryDark"]
                                          : (Color)Application.Current.Resources["Tertiary"],
                        TextColor = Application.Current!.RequestedTheme == AppTheme.Dark
                                    ? Colors.Black : Colors.White,
                    }));
        }
    }
}
