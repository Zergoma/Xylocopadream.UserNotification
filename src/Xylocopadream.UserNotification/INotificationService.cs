namespace Xylocopadream.UserNotification;

public interface INotificationService
{
    Task ShowErrorAsync(string message);
    Task ShowWarningAsync(string message);
    Task ShowInfoAsync(string message);

}
