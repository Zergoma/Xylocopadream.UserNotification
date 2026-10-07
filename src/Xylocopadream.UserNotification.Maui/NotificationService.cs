namespace Xylocopadream.UserNotification.Maui;

// All the code in this file is included in all platforms.
public class NotificationService : INotificationService
{
    public Task ShowErrorAsync(string message)
        => ShowAlertAsync("Error", message);

    public Task ShowInfoAsync(string message)
        => ShowAlertAsync("Info", message);

    public Task ShowWarningAsync(string message)
        => ShowAlertAsync("Warning", message);

    private static Task ShowAlertAsync(string title, string message)
    {
        // Alerts must be displayed from the UI thread, whatever thread the caller is on
        return MainThread.InvokeOnMainThreadAsync(async () =>
        {
            Page? page =
                Application.Current?.Windows is { Count: > 0 } windows
                    ? windows[0].Page
                    : null;

            if (page is null)
            {
                return;
            }

            await page.DisplayAlertAsync(title, message, "OK");
        });
    }
}
